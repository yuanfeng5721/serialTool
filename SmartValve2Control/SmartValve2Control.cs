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
using SmartValve2Control.Properties;

namespace SmartValve2Control
{
    public partial class SmartValveControl : Form
    {
        //private BleControl blectl;
        private System.Timers.Timer time_timer = new System.Timers.Timer();
        private System.Timers.Timer loop_timer = new System.Timers.Timer();
        private System.Timers.Timer recv_timer = new System.Timers.Timer();
        private System.Timers.Timer ble_timer = new System.Timers.Timer();

        //private int in_loop_timer = 0;
        private int in_recv_timer = 0;
        private int tn_show_time = 0;

        private string recv_file_path;// send_file_path;
        private bool _recv_file = false;

        private long count_send = 0, count_recv = 0;
        private ConcurrentQueue<byte> read_buffer = new ConcurrentQueue<byte>();
        private ConcurrentQueue<byte[]> serial_recv_buffer = new ConcurrentQueue<byte[]>();

        Encoding encoder = Encoding.Default;
        const int cmdlistcount = 20;

        TextBox[] TextBox_Cmds = new TextBox[cmdlistcount];
        Button[] Button_Cmds = new Button[cmdlistcount];
        CheckBox[] CheckBox_Cmds = new CheckBox[cmdlistcount];

        private Settings config = new Settings();

        BleCore bluetooth;
        String _serviceGuid = "6e400001-b5a3-f393-e0a9-e50e24dcca9e";
        String _writeCharacteristicGuid = "6e400002-b5a3-f393-e0a9-e50e24dcca9e";
        String _notifyCharacteristicGuid = "6e400003-b5a3-f393-e0a9-e50e24dcca9e";

        private bool _isBleDeviceConnected = false;

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
            Control.CheckForIllegalCrossThreadCalls = false;  // 忽略多线程

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

            for (int i = 0; i < cmdlistcount; i++)
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

            bluetooth = new BleCore(_serviceGuid, _writeCharacteristicGuid, _notifyCharacteristicGuid);
            bluetooth.ValueChanged += Bluetooth_ValueChanged;
            bluetooth.Receive += BluetoothReceive;

            //
            comboBoxBleDevice.Text = "ZLG BLE";//"ZLG BLE"
            _isBleDeviceConnected = false;
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

        private void config_load()
        {
            config.Reload();

            comboBoxCom.Text = config.comboBoxCom;
            comboBoxBaudRate.Text = config.comboBoxBaudRate;
            comboBoxParity.Text = config.comboBoxParity;
            comboBoxByteSize.Text = config.comboBoxByteSize;
            comboBoxStopBit.Text = config.comboBoxStopBit;

            tabControlMode.SelectedIndex = config.modeIndex;

            Type t = typeof(Settings);

            for (int i = 0; i < cmdlistcount; i++)
            {
                int index = i + 1;
                TextBox_Cmds[i].Text = (String)t.GetProperty("cmd" + index).GetValue(config);
                CheckBox_Cmds[i].Checked = (bool)t.GetProperty("cmdbr" + index).GetValue(config);
            }
        }

        private void config_save()
        {
            config.comboBoxCom = comboBoxCom.Text;
            config.comboBoxBaudRate = comboBoxBaudRate.Text;
            config.comboBoxParity = comboBoxParity.Text;
            config.comboBoxByteSize = comboBoxByteSize.Text;
            config.comboBoxStopBit = comboBoxStopBit.Text;
            config.modeIndex = tabControlMode.SelectedIndex;

            Type t = typeof(Settings);

            for (int i = 0; i < cmdlistcount; i++)
            {
                int index = i + 1;
                t.GetProperty("cmd" + index).SetValue(config, TextBox_Cmds[i].Text, null);
                t.GetProperty("cmdbr" + index).SetValue(config, CheckBox_Cmds[i].Checked, null);
            }

            config.Save();
        }

        private void SmartValveControl_Load(object sender, EventArgs e)
        {
            config_load();

            //Console.SetOut(new TextBoxWriter(richTextBoxState));
            //SearchCompleteSerial(serialPort, comboBoxCom);
            //blectl = new BleControl(this);

            Icon logo = Properties.Resources.logo;
            this.Icon = logo;
        }

        private void SmartValveControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial_send_stop();
            config_save();
        }

        private void buttonCmdSend_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = int.Parse(btn.Text) - 1;

            if (index >= 0)
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
                if (labelMode.Text == "UART")
                {
                    if (serialPort.IsOpen)
                    {
                        serial_send_text(str);
                    }
                }
                else if (labelMode.Text == "BLE")
                {
                    if (_isBleDeviceConnected)
                    {
                        Bluetooth_send_dataAsync(str);
                    }
                }

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

        //private void send_loop_start()
        //{
        //    loop_timer.Enabled = true;
        //}

        //private void send_loop_stop()
        //{
        //    loop_timer.Enabled = false;
        //}

        private bool serial_send_stop()
        {
            //if (loop_timer.Enabled)
            //{
            //    send_loop_stop();

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
                    richTextBoxMessage.ScrollToCaret();
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

        private void slab_clear()
        {
            count_send = 0;
            slab_send.Text = "Send:0";
            count_recv = 0;
            slab_recv.Text = "Receive:0";
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
                    serial_send_stop();

                    MessageBoxEx.Show(this, ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }));
            }
        }

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
            if (richTextBoxState.TextLength > 4000)
            {
                richTextBoxState.Clear(); // 清空
            }

            //DebugTrack(richTextBoxState, str, color);  // 打印出这个字符串 黑色显示
            richTextBoxState.SelectionStart = richTextBoxState.Text.Length;
            richTextBoxState.SelectionColor = color;  // 选择打印的颜色
            richTextBoxState.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str + "\r\n");
            richTextBoxState.ScrollToCaret();  // 将控件内容滚动到当前插入符号位置 不加，光标在最初的位置，加上后，光标滚动到插入位置的最后面
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Clear();
            richTextBoxState.Clear();
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
            if (checkBoxSaveLog.Checked)
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

        private void buttonBleSearch_Click(object sender, EventArgs e)
        {
            if (buttonBleSearch.Text == "Search")
            {
                comboBoxBleDevice.Items.Clear();
                comboBoxBleDevice.Text = null;
                bluetooth.CurrentDeviceName = "ZLG BLE";
                //this.BeginInvoke(new MethodInvoker(delegate
                //{
                //    blectl.BleSearch(true);
                //}));
                bluetooth.StartBleDeviceWatcher();
                buttonBleSearch.Text = "Stop";
            }
            else if (buttonBleSearch.Text == "Stop")
            {
                //this.BeginInvoke(new MethodInvoker(delegate
                //{
                //    blectl.BleSearch(false);
                //}));
                buttonBleSearch.Text = "Search";
            }

        }

        private void tabControlMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMode.SelectedIndex == 0)
            {
                bluetoothOperate(false);
                labelMode.Text = "UART";
            }
            else
            {
                serial_port_close();
                labelMode.Text = "BLE";
            }
            slab_clear();
            richTextBoxMessage.Clear();
            richTextBoxState.Clear();
        }

        private void bluetoothOperate(Boolean onoff)
        {
            if (onoff)
            {
                bluetooth.CurrentDeviceName = comboBoxBleDevice.Text;//"ZLG BLE";
                bluetooth.StartBleDeviceWatcher();
                comboBoxBleDevice.Enabled = false;
                //buttonConnect.Enabled = true;
                //_isBleDeviceConnected = true;
            }
            else
            {
                byte[] cmd = System.Text.Encoding.ASCII.GetBytes("BLE DISCONNECT\r\n");
                bluetooth.Write(cmd);
                bluetooth.Write(cmd);
                bluetooth.StopBleDeviceWatcher();
                bluetooth.Dispose();
                comboBoxBleDevice.Enabled = true;
                buttonConnect.Enabled = true;
                _isBleDeviceConnected = false;
            }
        }

        private void bluetoothCheckStates(object sender, EventArgs e)
        {
            if(!_isBleDeviceConnected)
            {
                buttonConnect.Text = "Connect";
                bluetoothOperate(false);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Connect")
            {
                buttonConnect.Enabled = false;
                buttonConnect.Text = "Disconnect";
                ble_timer.Interval = 1000 * 60 * 1;
                ble_timer.AutoReset = false;
                ble_timer.Elapsed += bluetoothCheckStates;
                ble_timer.Start();
                //this.BeginInvoke(new MethodInvoker(delegate
                //{
                //    blectl.BleConnect(comboBoxBleDevice.Text);
                //    buttonConnect.Enabled = true;
                //}));
                //buttonBleSearch.Enabled = false;
                //bluetooth.CurrentDeviceName = comboBoxBleDevice.Text;//"ZLG BLE";
                //bluetooth.StartBleDeviceWatcher();
                //comboBoxBleDevice.Enabled = false;
                //buttonConnect.Enabled = true;
                //_isBleDeviceConnected = true;
                bluetoothOperate(true);
            }
            else
            {
                buttonConnect.Enabled = false;
                buttonConnect.Text = "Connect";
                //this.BeginInvoke(new MethodInvoker(delegate
                //{
                //    //blectl.BleSearch(false);
                //    //blectl.BleDisconnect();
                //    buttonConnect.Enabled = true;
                //}));
                //buttonBleSearch.Text = "Search";
                //comboBoxBleDevice.Items.Clear();
                //comboBoxBleDevice.Text = null;
                //buttonBleSearch.Enabled = true;
                //bluetooth.StopBleDeviceWatcher();
                //bluetooth.Dispose();
                //comboBoxBleDevice.Enabled = true;
                //buttonConnect.Enabled = true;
                //_isBleDeviceConnected = false;
                bluetoothOperate(false);
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

        public void Bluetooth_ValueChanged(MsgType type, string str, byte[] data = null)
        {
            if (str != null)
            {
                if (type == MsgType.NotifyTxt)
                {
                    state_printf(str, Color.Black);
                }
                else if (type == MsgType.NotifyGattCommunication)
                {
                    if (str == "Success")
                    {
                        ble_timer.Stop();
                        state_printf(str, Color.Green);
                        buttonConnect.Enabled = true;
                        _isBleDeviceConnected = true;
                        byte[] cmd = System.Text.Encoding.ASCII.GetBytes("BLE CONNECT\r\n");
                        bluetooth.Write(cmd);
                        bluetooth.Write(cmd);
                    }
                }
                else if (type == MsgType.NotifyStates)
                {
                    if (str == "Success")
                    {
                        state_printf(str, Color.Green);
                    }
                }
                else
                {
                    state_printf(str, Color.Red);
                }
            }
        }

        private async Task bluetoothSendDataAsync(byte[] buffer)
        {
            if (buffer.Length > 0)
            {
                if (_isBleDeviceConnected)
                {
                    //lock (bluetooth)
                    {
                        await bluetooth.Write(buffer);
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

        public async Task Bluetooth_send_dataAsync(String str)
        {
            //byte[] data = System.Text.Encoding.ASCII.GetBytes(str);
            //await bluetooth.Write(data);

            byte[] buffer_tmp;
            List<byte> buffer = new List<byte>();

            try
            {
                {
                    buffer_tmp = encoder.GetBytes(str);
                }
                buffer.AddRange(buffer_tmp);

                //await bluetooth.Write(buffer.ToArray());
                bluetoothSendDataAsync(buffer.ToArray());
            }
            catch (Exception ex)
            {
                this.BeginInvoke((EventHandler)(delegate
                {
                    //group_send_stop();
                    serial_send_stop();

                    MessageBoxEx.Show(this, ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }));
            }
        }

        void BluetoothReceive(int receivebytes, byte[] data)
        {
            int bytes = receivebytes;
            int i;

            try
            {
                if (bytes > 0)
                {
                    byte[] buffer = new byte[bytes]; // 声明一个临时数组存储当前来的串口数据
                    //serialPort.Read(buffer, 0, bytes); // 读取缓冲数据
                    data.CopyTo(buffer, 0);
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

    //public class BleControl
    //{
    //    private static SmartValveControl smartValve2control;
    //    private static BleCore bleCore = null;
    //    delegate void VoidAction();
    //    private static ArrayList bledevice;
    //    private static BluetoothLEDevice dev;
    //    int item = 0;

    //    public BleControl(SmartValveControl svc)
    //    {
    //        smartValve2control = svc;
    //        bleCore = new BleCore();
    //        bledevice = new ArrayList();
    //        bleCore.DeviceWatcherChanged += DeviceWatcherChanged;
    //        bleCore.CharacteristicAdded += CharacteristicAdded;
    //        bleCore.CharacteristicFinish += CharacteristicFinish;
    //        bleCore.Recdate += Recdata;
    //    }

    //    private static List<GattCharacteristic> characteristics = new List<GattCharacteristic>();

    //    public void BleSearch(bool onoff)
    //    {
    //        if(onoff)
    //        {
    //            bleCore.StartBleDeviceWatcher();
    //        }
    //        else
    //        {
    //            bleCore.StopBleDeviceWatcher();
    //            //bleCore = null;
    //        }
    //    }

    //    public void BleConnect(String DeviceName)
    //    {
    //        //foreach(BluetoothLEDevice currentDevice in bledevice)
    //        {
    //            //if(currentDevice.Name == DeviceName)
    //            if(dev.Name == DeviceName)
    //            {
    //                //ConnectDevice(currentDevice);
    //                ConnectDevice(dev);
    //                //break;
    //            }
    //        }

    //    }

    //    public void BleDisconnect()
    //    {
    //        characteristics.Clear();
    //        bleCore.StopBleDeviceWatcher();
    //        bleCore.Dispose();
    //    }

    //    private static void printString(string info)
    //    {
    //        smartValve2control.state_printf(info, Color.Black);
    //    }

    //    private static void CharacteristicFinish(int size)
    //    {
    //        if (size <= 0)
    //        {
    //            Console.WriteLine("设备未连上");
    //            return;
    //        }
    //        else
    //        {

    //        }
    //    }

    //    private static void Recdata(GattCharacteristic sender, byte[] data)
    //    {
    //        string str = BitConverter.ToString(data);
    //        Console.WriteLine(sender.Uuid + "             " + str);
    //    }

    //    private static void CharacteristicAdded(GattCharacteristic gatt)
    //    {
    //        Console.WriteLine(
    //            "handle:[0x{0}]  char properties:[{1}]  UUID:[{2}]",
    //            gatt.AttributeHandle.ToString("X4"),
    //            gatt.CharacteristicProperties.ToString(),
    //            gatt.Uuid);

    //        characteristics.Add(gatt);
    //    }

    //    private static void DeviceWatcherChanged(BluetoothLEDevice currentDevice)
    //    {
    //        byte[] _Bytes1 = BitConverter.GetBytes(currentDevice.BluetoothAddress);
    //        Array.Reverse(_Bytes1);
    //        string address = BitConverter.ToString(_Bytes1, 2, 6).Replace('-', ':').ToLower();
    //        Console.WriteLine("发现设备：<" + currentDevice.Name + ">  address:<" + address + ">");
    //        if(currentDevice.Name == "ZLG BLE")
    //        {
    //            dev = currentDevice;
    //            smartValve2control.BleItemAdd(currentDevice.Name);
    //        }
    //        //bledevice.Add(currentDevice);
    //        //smartValve2control.BleItemAdd(currentDevice.Name);
    //        //指定一个对象，使用下面方法去连接设备
    //        //ConnectDevice(currentDevice);
    //    }

    //    private static void ConnectDevice(BluetoothLEDevice Device)
    //    {
    //        characteristics.Clear();
    //        bleCore.StopBleDeviceWatcher();
    //        bleCore.StartMatching(Device);
    //        bleCore.FindService();
    //    }
    //}
}
