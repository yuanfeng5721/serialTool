using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using System.Collections.Concurrent;

namespace SmartValve2Control
{
    public partial class SmartValveControl : Form
    {
        private BleControl blectl;
        private System.Timers.Timer time_timer = new System.Timers.Timer();
        private System.Timers.Timer loop_timer = new System.Timers.Timer();
        private System.Timers.Timer recv_timer = new System.Timers.Timer();

        //private int in_loop_timer = 0;
        private int in_recv_timer = 0;
        private int tn_show_time = 0;

        private string recv_file_path;// send_file_path;
        private bool _recv_file = false;

        private long count_send = 0, count_recv = 0;
        private ConcurrentQueue<byte> read_buffer = new ConcurrentQueue<byte>();
        private ConcurrentQueue<byte[]> serial_recv_buffer = new ConcurrentQueue<byte[]>();

        Encoding encoder = Encoding.Default;
        const int cmdlistcount = 15;

        TextBox[] TextBox_Cmds = new TextBox[cmdlistcount];
        Button[] Button_Cmds = new Button[cmdlistcount];
        CheckBox[] CheckBox_Cmds = new CheckBox[cmdlistcount];

        public SmartValveControl()
        {
            InitializeComponent();

            string[] port_names = SerialPort.GetPortNames();
            Array.Sort(port_names, new CustomComparer());
            comboBoxCom.Items.AddRange(port_names);
            comboBoxCom.SelectedIndex = comboBoxCom.Items.Count > 0 ? 0 : -1;

            string[] baud_rates = { /*"110", "300", "600",*/ "1200", "2400", "4800", "9600", "14400", "19200", "38400", /*"56000",*/ "57600", "115200", "230400", "460800", "921600"/*"128000", "256000"*/ };
            comboBoxBaudRate.Items.AddRange(baud_rates);
            comboBoxBaudRate.Text = "9600";

            string[] paritys = { "None", "Odd", "Even", "Mark", "Space" };
            comboBoxParity.Items.AddRange(paritys);
            comboBoxParity.Text = "None";

            string[] data_bits = { "5", "6", "7", "8" };
            comboBoxByteSize.Items.AddRange(data_bits);
            comboBoxByteSize.Text = "8";

            string[] stop_bits = { "1", "1.5", "2" };
            comboBoxStopBit.Items.AddRange(stop_bits);
            comboBoxStopBit.Text = "1";

            //serialPort.Encoding = Encoding.GetEncoding("gb2312");  // 设置串口的编码
            //Control.CheckForIllegalCrossThreadCalls = false;  // 忽略多线程

            time_timer.Interval = 1;
            time_timer.Start();
            recv_timer.Interval = 10;
            recv_timer.Start();

            serialPort.DataReceived += serial_DataReceived;
            time_timer.Elapsed += time_timer_ElapsedEventHandler;
            //loop_timer.Elapsed += loop_timer_ElapsedEventHandler;
            recv_timer.Elapsed += recv_timer_ElapsedEventHandler;

            comboBoxCom.SelectionChangeCommitted += new System.EventHandler(comboBoxCom_SelectionChangeCommitted);
            comboBoxBaudRate.SelectionChangeCommitted += new System.EventHandler(comboBoxCom_SelectionChangeCommitted);
            comboBoxParity.SelectionChangeCommitted += new System.EventHandler(comboBoxCom_SelectionChangeCommitted);
            comboBoxByteSize.SelectionChangeCommitted += new System.EventHandler(comboBoxCom_SelectionChangeCommitted);
            comboBoxStopBit.SelectionChangeCommitted += new System.EventHandler(comboBoxCom_SelectionChangeCommitted);

            for (int i=0; i< cmdlistcount; i++)
            {
                int index = i + 1;
                TextBox_Cmds[i] = GetControlInstance(this, "textBoxCmd" + index) as TextBox;
                Button_Cmds[i] = GetControlInstance(this, "buttonCmdSend" + index) as Button;
                CheckBox_Cmds[i] = GetControlInstance(this, "checkBoxBR" + index) as CheckBox;
                Button_Cmds[i].Click += new System.EventHandler(buttonCmdSend_Click);
            }

            //init disable some controls
            buttonLog.Enabled = false;
            textBoxLogPath.Enabled = false;
        }

        /// <summary>
        /// 根据指定容器和控件名字，获得控件
        /// </summary>
        /// <param name="obj">容器</param>
        /// <param name="strControlName">控件名字</param>
        /// <returns>控件</returns>
        private object GetControlInstance(object obj, string strControlName)
        {
            IEnumerator Controls = null;//所有控件
            Control c = null;//当前控件
            Object cResult = null;//查找结果
            if (obj.GetType() == this.GetType())//窗体
            {
                Controls = this.Controls.GetEnumerator();
            }
            else//控件
            {
                Controls = ((Control)obj).Controls.GetEnumerator();
            }
            while (Controls.MoveNext())//遍历操作
            {
                c = (Control)Controls.Current;//当前控件
                if (c.HasChildren)//当前控件是个容器
                {
                    cResult = GetControlInstance(c, strControlName);//递归查找
                    if (cResult == null)//当前容器中没有，跳出，继续查找
                        continue;
                    else//找到控件，返回
                        return cResult;
                }
                else if (c.Name == strControlName)//不是容器，同时找到控件，返回
                {
                    return c;
                }
            }
            return null;//控件不存在
        }

        private void SmartValveControl_Load(object sender, EventArgs e)
        {
            Console.SetOut(new TextBoxWriter(richTextBoxState));
            //SearchCompleteSerial(serialPort, comboBoxCom);
            blectl = new BleControl(this);
        }


        private void SmartValveControl_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonCmdSend_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = int.Parse(btn.Text) - 1;

            if(index >= 0)
            {
                TextBox tb_cmd = TextBox_Cmds[index < 0 ? 0 : index];
                CheckBox cb_cmdbr = CheckBox_Cmds[index < 0 ? 0 : index];
                String str;

                if (cb_cmdbr.Checked)
                {
                    str = tb_cmd.Text + "\r\n";
                }
                else
                {
                    str = tb_cmd.Text;
                }
                serial_send_text(str);
            }
        }

        void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = serialPort.BytesToRead;
            int i;

            try
            {
                if (bytes > 0)
                {
                    byte[] buffer = new byte[bytes]; // 声明一个临时数组存储当前来的串口数据
                    serialPort.Read(buffer, 0, bytes); // 读取缓冲数据

                    for (i = 0; i < bytes; i++)
                    {
                        if (read_buffer.Count() >= 65536)
                        {
                            byte byte_tmp;
                            read_buffer.TryDequeue(out byte_tmp);
                        }
                        read_buffer.Enqueue(buffer[i]);
                    }

                    this.BeginInvoke((EventHandler)(delegate
                    {
                        count_recv += buffer.Length;
                        slab_recv.Text = "Receive:" + count_recv.ToString();

                        //if (chk_recv_show.Checked)
                        {
                            //serial_recv_data(buffer);
                            serial_recv_buffer.Enqueue(buffer);
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                this.BeginInvoke((EventHandler)(delegate
                {
                    serial_port_close();

                    MessageBoxEx.Show(this, ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }));
            }
        }

        void time_timer_ElapsedEventHandler(object sender, EventArgs e)
        {
            if (tn_show_time > 0)
            {
                tn_show_time--;
            }
        }

        void recv_timer_ElapsedEventHandler(object sender, EventArgs e)
        {
            if (System.Threading.Interlocked.Exchange(ref in_recv_timer, 1) == 0)
            {
                try
                {
                    List<byte> buffer = new List<byte>();
                    while (buffer.Count < 64 * 1024)
                    {
                        if (serial_recv_buffer.Count == 0)
                        {
                            break;
                        }
                        byte[] buffer_tmp;
                        if (serial_recv_buffer.TryDequeue(out buffer_tmp))
                        {
                            buffer.AddRange(buffer_tmp);
                        }
                    }
                    if (buffer.Count > 0)
                    {
                        this.BeginInvoke((EventHandler)(delegate
                        {
                            serial_recv_data(buffer.ToArray());
                        }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(this, ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                System.Threading.Interlocked.Exchange(ref in_recv_timer, 0);
            }
        }

        private void serial_port_open()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }

                serialPort.PortName = comboBoxCom.Text;
                serialPort.BaudRate = int.Parse(comboBoxBaudRate.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                serialPort.DataBits = int.Parse(comboBoxByteSize.Text);

                StopBits[] stop_bits = { StopBits.One, StopBits.OnePointFive, StopBits.Two };
                serialPort.StopBits = stop_bits[comboBoxStopBit.SelectedIndex];

                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (serialPort.IsOpen)
            {
                buttonOpenCom.Image = Properties.Resources.open;
                buttonOpenCom.Text = "Close";

                comboBoxCom.Enabled = false;
                comboBoxBaudRate.Enabled = false;
                comboBoxParity.Enabled = false;
                comboBoxByteSize.Enabled = false;
                comboBoxStopBit.Enabled = false;
            }
            else
            {
                buttonOpenCom.Image = Properties.Resources.close;
                buttonOpenCom.Text = "Open";

                comboBoxCom.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                comboBoxParity.Enabled = true;
                comboBoxByteSize.Enabled = true;
                comboBoxStopBit.Enabled = true;
            }
        }

        private void serial_port_close()
        {
            try
            {
                //if (loop_timer.Enabled)
                //{
                //    send_loop_stop();
                //}
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            catch
            {

            }

            buttonOpenCom.Image = Properties.Resources.close;
            buttonOpenCom.Text = "Open";
        }

        private void buttonOpenCom_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serial_port_close();
            }
            else
            {
                serial_port_open();
            }
        }

        private void comboBoxCom_DropDown(object sender, EventArgs e)
        {
            string port_name_old = comboBoxCom.Text;

            string[] port_names = SerialPort.GetPortNames();
            Array.Sort(port_names, new CustomComparer());
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(port_names);

            comboBoxCom.Text = port_name_old;

            if ((comboBoxCom.Items.Count > 0) && (comboBoxCom.SelectedIndex < 0))
            {
                comboBoxCom.SelectedIndex = 0;
            }
        }

        private void comboBoxCom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serial_port_open();
            }
        }

        private void send_loop_start()
        {
            loop_timer.Enabled = true;
            //btn_show_send.Text = "停止";
        }

        private void send_loop_stop()
        {
            //if (lua_thread != null)
            //{
            //    _lua_should_stop = true;
            //    lua_thread.Abort();
            //    while (lua_thread != null)
            //    {
            //        Application.DoEvents();
            //    }
            //    btn_show_send.Text = "发送";
            //}
            //else if (file_thread != null)
            //{
            //    while (file_thread != null)
            //    {
            //        _file_should_stop = true;
            //        Application.DoEvents();
            //    }
            //}

            loop_timer.Enabled = false;
            //btn_show_send.Text = "发送";
        }

        private bool serial_send_stop()
        {
            if (loop_timer.Enabled)
            {
                send_loop_stop();

                return true;
            }
            //else if (lua_thread != null)
            //{
            //    _lua_should_stop = true;
            //    lua_thread.Abort();
            //    while (lua_thread != null)
            //    {
            //        Application.DoEvents();
            //    }
            //    btn_show_send.Text = "发送";

            //    return true;
            //}
            //else if (file_thread != null)
            //{
            //    while (file_thread != null)
            //    {
            //        _file_should_stop = true;
            //        Application.DoEvents();
            //    }

            //    return true;
            //}

            byte byte_tmp;
            while (read_buffer.TryDequeue(out byte_tmp))
            {

            }

            return false;
        }

        private void serial_recv_data(byte[] buffer)
        {
            string str_tmp = "";

            if (checkBoxShowTime.Checked)
            {
                if (tn_show_time == 0)
                {
                    if (richTextBoxMessage.Text.Length > 0)
                    {
                        str_tmp += "\r\n";
                    }
                    str_tmp += "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "]";
                }

                tn_show_time = 10;
            }
            //if (chk_recv_hex.Checked)
            //{
            //    str_tmp += byte_to_hex(buffer);
            //}
            //else
            {
                str_tmp += encoder.GetString(buffer);
            }

            
            {
                if (_recv_file)
                {
                    File.AppendAllText(recv_file_path, str_tmp);
                }

                string[] strs = str_tmp.Split('\b');
                int i;

                for (i = 0; i < strs.Count(); i++)
                {
                    if ((richTextBoxMessage.TextLength >= 1) && (i > 0))
                    {
                        string str_select = "";
                        richTextBoxMessage.Select(richTextBoxMessage.TextLength - 1, 1);
                        if (richTextBoxMessage.SelectedText[0] == '\n')
                        {
                            if ((richTextBoxMessage.TextLength >= 2) && (richTextBoxMessage.Text[richTextBoxMessage.TextLength - 2] == '\r'))
                            {
                                richTextBoxMessage.Select(richTextBoxMessage.TextLength - 2, 2);
                            }
                        }
                        else
                        {
                            byte[] byte_tmp = encoder.GetBytes(richTextBoxMessage.SelectedText);
                            if (byte_tmp.Length > 1)
                            {
                                byte[] byte_select = new byte[byte_tmp.Length - 1];
                                Array.Copy(byte_tmp, byte_select, byte_select.Length);
                                str_select = encoder.GetString(byte_select);
                            }
                        }
                        richTextBoxMessage.SelectedText = str_select;
                    }

                    if (strs[i].LastIndexOf("\x1B[2K") >= 0)
                    {
                        strs[i] = strs[i].Substring(strs[i].LastIndexOf("\x1B[2K") + "\x1B[2K".Length);

                        int pos = richTextBoxMessage.Text.LastIndexOf("\r\n");
                        if (pos >= 0)
                        {
                            pos += "\r\n".Length;
                            richTextBoxMessage.Select(pos, richTextBoxMessage.Text.Length - pos);
                            richTextBoxMessage.SelectedText = "";
                        }
                        else
                        {
                            richTextBoxMessage.Text = "";
                        }
                    }

                    richTextBoxMessage.AppendText(strs[i]);

                    /*
                     * The color for terminal (foreground)
                     * BLACK    30
                     * RED      31
                     * GREEN    32
                     * YELLOW   33
                     * BLUE     34
                     * PURPLE   35
                     * CYAN     36
                     * WHITE    37
                     */
                }
            }
        }

        private void serial_send_data(byte[] buffer)
        {
            if (buffer.Length > 0)
            {
                if (serialPort.IsOpen)
                {
                    lock (serialPort)
                    {
                        serialPort.Write(buffer, 0, buffer.Length);
                    }

                    this.BeginInvoke((EventHandler)(delegate
                    {
                        count_send += buffer.Length;
                        slab_send.Text = "Send:" + count_send.ToString();

                        //if (chk_send_show.Checked)
                        {
                            //serial_recv_data(buffer);
                            serial_recv_buffer.Enqueue(buffer);
                        }
                    }));
                }
                else
                {
                    this.BeginInvoke((EventHandler)(delegate
                    {
                        //serial_recv_data(buffer);
                        serial_recv_buffer.Enqueue(buffer);
                    }));
                }
            }
        }

        int number_parse(string str, int len, int radio, out int num)
        {
            string str_hex = "0123456789ABCDEF";
            int i;

            num = 0;
            if (len > str.Length)
            {
                len = str.Length;
            }
            for (i = 0; i < len; i++)
            {
                int n = str_hex.IndexOf(Char.ToUpper(str[i]));
                if ((n < 0) || (n >= radio))
                {
                    break;
                }
                num *= radio;
                num += n;
            }

            return i;
        }

        string[] string_split(string input, string pattern)
        {
            List<string> list = new List<string>();
            int start = 0, index;
            while ((index = input.IndexOf(pattern, start)) >= 0)
            {
                list.Add(input.Substring(start, index - start));
                index += pattern.Length;
                start = index;
            }
            list.Add(input.Substring(start));

            return list.ToArray();
        }

        byte[] string_escape(string text)
        {
            List<byte> list = new List<byte>();
            string[] strs = string_split(text, "\\\\");
            string esc_string = "abfnrtv";
            string esc_value = "\a\b\f\n\r\t\v";

            for (int i = 0; i < strs.Length; i++)
            {
                if (i > 0)
                {
                    list.AddRange(encoder.GetBytes("\\"));
                }

                if (strs[i].Length > 0)
                {
                    string[] strc = strs[i].Split('\\');
                    list.AddRange(encoder.GetBytes(strc[0]));
                    for (int j = 1; j < strc.Length; j++)
                    {
                        int index = esc_string.IndexOf(strc[j][0]);
                        if (index >= 0)
                        {
                            list.AddRange(encoder.GetBytes(esc_value[index].ToString()));
                            list.AddRange(encoder.GetBytes(strc[j].Substring(1)));
                        }
                        else if (strc[j][0] == 'x')
                        {
                            int num;
                            int len = number_parse(strc[j].Substring(1), 2, 16, out num);
                            if (len <= 0)
                            {
                                throw new ArgumentException("无法解析的数值");
                            }
                            list.Add((byte)num);
                            list.AddRange(encoder.GetBytes(strc[j].Substring(1 + len)));
                        }
                        else if ((strc[j][0] >= '0') && (strc[j][0] <= '7'))
                        {
                            int num;
                            int len = number_parse(strc[j], 3, 8, out num);
                            if (len <= 0)
                            {
                                throw new ArgumentException("无法解析的数值");
                            }
                            list.Add((byte)num);
                            list.AddRange(encoder.GetBytes(strc[j].Substring(len)));
                        }
                        else
                        {
                            list.AddRange(encoder.GetBytes(strc[j]));
                        }
                    }
                }
            }

            return list.ToArray();
        }

        private void serial_send_text(string text)
        {
            byte[] buffer_tmp;
            List<byte> buffer = new List<byte>();

            try
            {
                //if (chk_pack_head.Checked)
                //{
                //    if (chk_send_hex.Checked)
                //    {
                //        buffer.AddRange(hex_to_byte(txt_pack_head.Text));
                //    }
                //    else
                //    {
                //        if (chk_esc_char.Checked)
                //        {
                //            buffer.AddRange(string_escape(txt_pack_head.Text));
                //        }
                //        else
                //        {
                //            buffer.AddRange(encoder.GetBytes(txt_pack_head.Text));
                //        }
                //    }
                //}

                //if (chk_send_hex.Checked)
                //{
                //    buffer_tmp = hex_to_byte(text);
                //}
                //else
                //{
                //    if (chk_esc_char.Checked)
                //    {
                //        buffer_tmp = string_escape(text);
                //    }
                //    else
                    {
                        buffer_tmp = encoder.GetBytes(text);
                    }
                //}
                buffer.AddRange(buffer_tmp);

                //if (chk_pack_check.Checked)
                //{
                //    byte[] check_buffer;
                //    byte byte_tmp;
                //    int check_type = 0;
                //    this.Invoke((EventHandler)(delegate
                //    {
                //        check_type = cbo_pack_check.SelectedIndex;
                //    }));
                //    switch (check_type)
                //    {
                //        case 0: // XOR异或校验 
                //            check_buffer = calc_xor(buffer_tmp);
                //            buffer.AddRange(check_buffer);
                //            break;
                //        case 1: // SUM8校验
                //            check_buffer = calc_sum_16(buffer_tmp);
                //            buffer.Add(check_buffer[0]);
                //            break;
                //        case 2: // ModBusLRC校验
                //            check_buffer = calc_sum_16(buffer_tmp);
                //            buffer.AddRange(new byte[] { (byte)(-check_buffer[0]) });
                //            break;
                //        case 3: // CRC16低字节在前
                //            check_buffer = calc_crc_16(0x1021, buffer_tmp);
                //            buffer.AddRange(check_buffer);
                //            break;
                //        case 4: // CRC16高字节在前
                //            check_buffer = calc_crc_16(0x1021, buffer_tmp);
                //            byte_tmp = check_buffer[0];
                //            check_buffer[0] = check_buffer[1];
                //            check_buffer[1] = byte_tmp;
                //            buffer.AddRange(check_buffer);
                //            break;
                //        case 5: // SUM16校验和低字节在前
                //            check_buffer = calc_sum_16(buffer_tmp);
                //            buffer.AddRange(check_buffer);
                //            break;
                //        case 6: // SUM16校验和高字节在前
                //            check_buffer = calc_sum_16(buffer_tmp);
                //            byte_tmp = check_buffer[0];
                //            check_buffer[0] = check_buffer[1];
                //            check_buffer[1] = byte_tmp;
                //            buffer.AddRange(check_buffer);
                //            break;
                //        case 7: // ModBusCRC低字节在前
                //            check_buffer = calc_modbus_crc(buffer_tmp);
                //            buffer.AddRange(check_buffer);
                //            break;
                //        case 8: // ModBusCRC高字节在前
                //            check_buffer = calc_modbus_crc(buffer_tmp);
                //            byte_tmp = check_buffer[0];
                //            check_buffer[0] = check_buffer[1];
                //            check_buffer[1] = byte_tmp;
                //            buffer.AddRange(check_buffer);
                //            break;
                //    }
                //}

                //if (chk_pack_end.Checked)
                //{
                //    if (chk_send_hex.Checked)
                //    {
                //        buffer.AddRange(hex_to_byte(txt_pack_end.Text));
                //    }
                //    else
                //    {
                //        if (chk_esc_char.Checked)
                //        {
                //            buffer.AddRange(string_escape(txt_pack_end.Text));
                //        }
                //        else
                //        {
                //            buffer.AddRange(encoder.GetBytes(txt_pack_end.Text));
                //        }
                //    }
                //}

                serial_send_data(buffer.ToArray());
            }
            catch (Exception ex)
            {
                this.BeginInvoke((EventHandler)(delegate
                {
                    //group_send_stop();
                    //serial_send_stop();

                    MessageBoxEx.Show(this, ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }));
            }
        }
        /* 串口自动扫描端口号  */
        //private void SearchCompleteSerial(SerialPort myport, ComboBox mybox)
        //{
        //    /* 先清空端口下拉列表 */
        //    mybox.Items.Clear();

        //    String[] mystring = SerialPort.GetPortNames(); // 获取计算机的端口名的数组
        //    for (int i = 0; i < mystring.Length; i++)
        //        mybox.Items.Add(mystring[i]); // 往下拉列表中添加端口号

        //    mybox.Text = mystring[0]; // 默认选中的是第一个端口（小的端口）
        //}

        /* 打开串口按键  点击监听事件 */
        //private void buttonOpenCom_Click(object sender, EventArgs e)
        //{

        //    /* 先判断当前串口是打开状态还是关闭状态 */
        //    if (buttonOpenCom.Text == "Open") // 串口还没有打开 需要打开串口 
        //    {
        //        try
        //        {

        //            serialPort.PortName = comboBoxCom.Text; // 端口号
        //            serialPort.BaudRate = int.Parse(comboBoxBaudRate.Text); // 串口通信的波特率
        //            if (comboBoxStopBit.Text == "1.5")
        //            {
        //                serialPort.StopBits = StopBits.OnePointFive; // 串口停止位1.5
        //            }
        //            else
        //            {
        //                serialPort.StopBits = (StopBits)int.Parse(comboBoxStopBit.Text);  // 串口停止位
        //            }

        //            if (comboBoxParity.Text == "None")      //串口奇偶校验位
        //            {
        //                serialPort.Parity = Parity.None;
        //            }
        //            else if (comboBoxParity.Text == "Odd")
        //            {
        //                serialPort.Parity = Parity.Odd;
        //            }
        //            else if (comboBoxParity.Text == "Even")
        //            {
        //                serialPort.Parity = Parity.Even;
        //            }
        //            else
        //            {
        //                serialPort.Parity = Parity.None;
        //            }

        //            serialPort.DataBits = int.Parse(comboBoxByteSize.Text);  //串口数据位

        //            serialPort.Open(); // 打开串口
        //            buttonOpenCom.Text = "Close";
        //            state_printf("Open sucessed!\r\n", Color.Black);
        //            //lab_Device_Connect.Text = "设备已连接";

        //        }
        //        catch
        //        {
        //            //MessageBox.Show("端口打开错误，请检查串口", "错误");
        //            state_printf("Open error, please check!\r\n", Color.Red);
        //        }
        //    }
        //    else  // 串口已经打开 需要关闭 
        //    {
        //        try
        //        {
        //            serialPort.Close(); // 关闭串口 
        //            buttonOpenCom.Text = "Open";
        //            state_printf("Close sucessed!\r\n", Color.Black);
        //            //lab_Device_Connect.Text = "设备已断开";
        //        }
        //        catch
        //        {
        //            //MessageBox.Show("关闭串口错误");
        //            state_printf("Close error!\r\n", Color.Red);
        //        }
        //    }

        //}/* 打开串口 按键监听*/

        /* 调试追踪*/
        public void DebugTrack(RichTextBox log, string str, Color color)
        {
            if (log.InvokeRequired)
            {
                Action<RichTextBox, string, Color> method = this.DebugTrack;
                log.Invoke(method, str, color);
            }
            else
            {
                /* 字符串的长度超过1000 自动清空接收显示界面 */
                if (log.TextLength > 1000)
                {
                    log.Clear(); // 清空
                }

                log.SelectionStart = log.Text.Length;
                log.SelectionColor = color;  // 选择打印的颜色

                /* 在接收数据前面显示时间 可选可不选 */
                if (checkBoxShowTime.Checked) // 如果显示时间被选中 
                {
                    /* 在打印出来的信息的前面追加时间字符串 */
                    log.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str);
                }
                else
                {
                    log.AppendText(str); // 不添加时间 直接在后面追加字符串
                    // this.log.AppendText("aaa"+"\r\n"); // 不添加时间 直接在后面追加字符串 
                }

                log.ScrollToCaret();  // 将控件内容滚动到当前插入符号位置 不加，光标在最初的位置，加上后，光标滚动到插入位置的最后面
            }
        }/* 调试追踪 */

        /* 打印字符串 */
        public void log_printf(string str, Color color)
        {
            DebugTrack(richTextBoxMessage, str, color);  // 打印出这个字符串 黑色显示
        }

        public void state_printf(string str, Color color)
        {
            DebugTrack(richTextBoxState, str, color);  // 打印出这个字符串 黑色显示
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonCmdSend1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (checkBoxSaveLog.Checked)
            {
                SaveFileDialog fileDialog = new SaveFileDialog();

                fileDialog.Title = "Receive data to file...";
                fileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    recv_file_path = fileDialog.FileName;
                }
                else
                {
                    checkBoxSaveLog.Checked = false;
                }
            }

            if (checkBoxSaveLog.Checked)
            {
                textBoxLogPath.Text = recv_file_path;
                textBoxLogPath.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                textBoxLogPath.Clear();
                textBoxLogPath.BackColor = System.Drawing.SystemColors.Window;
            }

            _recv_file = checkBoxSaveLog.Checked;
        }

        private void checkBoxSaveLog_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSaveLog.Checked)
            {
                buttonLog.Enabled = true;
                textBoxLogPath.Enabled = true;
            }
            else
            {
                buttonLog.Enabled = false;
                textBoxLogPath.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(buttonBleSearch.Text == "Search")
            {
                comboBoxBleDevice.Items.Clear();
                blectl.BleSearch(true);
                buttonBleSearch.Text = "Stop";
            }
            else if(buttonBleSearch.Text == "Stop")
            {
                blectl.BleSearch(false);
                buttonBleSearch.Text = "Search";
            }
            
        }

        public void BleItemAdd(string name)
        {
            /* 先清空端口下拉列表 */
            //comboBoxBleDevice.Items.Clear();
            //for (int i = 0; i < mystring.Length; i++)
            comboBoxBleDevice.Items.Add(name); // 往下拉列表中添加端口号

            comboBoxBleDevice.SelectedIndex = 0; // 默认选中的是第一个端口（小的端口）
        }
    }

    public class TextBoxWriter : System.IO.TextWriter
    {
        RichTextBox richBox;
        delegate void VoidAction();

        public TextBoxWriter(RichTextBox box)
        {
            richBox = box;
        }

        public override void Write(string value)
        {
            VoidAction action = delegate
            {
                richBox.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + value);
            };
            richBox.BeginInvoke(action);
        }

        public override void WriteLine(string value)
        {
            VoidAction action = delegate
            {
                richBox.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + value + "\r\n");
            };
            richBox.BeginInvoke(action);
        }

        public override System.Text.Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }

    public class CustomComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;

            if (s1.Length > s2.Length) return 1;
            if (s1.Length < s2.Length) return -1;
            return s1.CompareTo(s2);
        }
    }

    public class BleControl
    {
        private static SmartValveControl smartValve2control;
        private static BleCore bleCore = null;
        delegate void VoidAction();
        private static ArrayList bledevice;
        int item = 0;

        public BleControl(SmartValveControl svc)
        {
            smartValve2control = svc;
            bleCore = new BleCore();
            bledevice = new ArrayList();
            bleCore.DeviceWatcherChanged += DeviceWatcherChanged;
            bleCore.CharacteristicAdded += CharacteristicAdded;
            bleCore.CharacteristicFinish += CharacteristicFinish;
            bleCore.Recdate += Recdata;
        }

        private static List<GattCharacteristic> characteristics = new List<GattCharacteristic>();

        public void BleSearch(bool onoff)
        {
            if(onoff)
            {
                bleCore.StartBleDeviceWatcher();
            }
            else
            {
                bleCore.Dispose();
                //bleCore = null;
            }
        }

        private static void printString(string info)
        {
            smartValve2control.state_printf(info, Color.Black);
        }

        private static void CharacteristicFinish(int size)
        {
            if (size <= 0)
            {
                Console.WriteLine("设备未连上");
                return;
            }
        }

        private static void Recdata(GattCharacteristic sender, byte[] data)
        {
            string str = BitConverter.ToString(data);
            Console.WriteLine(sender.Uuid + "             " + str);
        }

        private static void CharacteristicAdded(GattCharacteristic gatt)
        {
            Console.WriteLine(
                "handle:[0x{0}]  char properties:[{1}]  UUID:[{2}]",
                gatt.AttributeHandle.ToString("X4"),
                gatt.CharacteristicProperties.ToString(),
                gatt.Uuid);

            characteristics.Add(gatt);
        }

        private static void DeviceWatcherChanged(BluetoothLEDevice currentDevice)
        {
            byte[] _Bytes1 = BitConverter.GetBytes(currentDevice.BluetoothAddress);
            Array.Reverse(_Bytes1);
            string address = BitConverter.ToString(_Bytes1, 2, 6).Replace('-', ':').ToLower();
            Console.WriteLine("发现设备：<" + currentDevice.Name + ">  address:<" + address + ">");
            bledevice.Add(currentDevice);
            smartValve2control.BleItemAdd(currentDevice.Name);
            //指定一个对象，使用下面方法去连接设备
            //ConnectDevice(currentDevice);
        }

        private static void ConnectDevice(BluetoothLEDevice Device)
        {
            characteristics.Clear();
            bleCore.StopBleDeviceWatcher();
            bleCore.StartMatching(Device);
            bleCore.FindService();
        }
    }
}
