using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartValve2Control
{
    public partial class SmartValveControl : Form
    {
        public SmartValveControl()
        {
            InitializeComponent();
            comboBoxBaudRate.SelectedIndex = 4;
            comboBoxStopBit.SelectedIndex = 1;
            comboBoxFlowControl.SelectedIndex = 0;
            comboBoxByteSize.SelectedIndex = 4;
            comboBoxParity.SelectedIndex = 0;

            serialPort.Encoding = Encoding.GetEncoding("GB2312");  // 设置串口的编码
            Control.CheckForIllegalCrossThreadCalls = false;  // 忽略多线程
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SmartValveControl_Load(object sender, EventArgs e)
        {
            SearchCompleteSerial(serialPort, comboBoxCom);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* 串口自动扫描端口号  */
        private void SearchCompleteSerial(SerialPort myport, ComboBox mybox)
        {
            /* 先清空端口下拉列表 */
            mybox.Items.Clear();

            String[] mystring = SerialPort.GetPortNames(); // 获取计算机的端口名的数组
            for (int i = 0; i < mystring.Length; i++)
                mybox.Items.Add(mystring[i]); // 往下拉列表中添加端口号

            mybox.Text = mystring[0]; // 默认选中的是第一个端口（小的端口）
        }

        /* 打开串口按键  点击监听事件 */
        private void buttonOpenCom_Click(object sender, EventArgs e)
        {

            /* 先判断当前串口是打开状态还是关闭状态 */
            if (buttonOpenCom.Text == "Open") // 串口还没有打开 需要打开串口 
            {
                try
                {

                    serialPort.PortName = comboBoxCom.Text; // 端口号
                    serialPort.BaudRate = int.Parse(comboBoxBaudRate.Text); // 串口通信的波特率
                    if (comboBoxStopBit.Text == "1.5")
                    {
                        serialPort.StopBits = StopBits.OnePointFive; // 串口停止位1.5
                    }
                    else
                    {
                        serialPort.StopBits = (StopBits)int.Parse(comboBoxStopBit.Text);  // 串口停止位
                    }
                    
                    if (comboBoxParity.Text == "None")      //串口奇偶校验位
                    {
                        serialPort.Parity = Parity.None;
                    }
                    else if (comboBoxParity.Text == "Odd")
                    {
                        serialPort.Parity = Parity.Odd;
                    }
                    else if (comboBoxParity.Text == "Even")
                    {
                        serialPort.Parity = Parity.Even;
                    }
                    else
                    {
                        serialPort.Parity = Parity.None;
                    }
                    
                    serialPort.DataBits = int.Parse(comboBoxByteSize.Text);  //串口数据位

                    serialPort.Open(); // 打开串口
                    buttonOpenCom.Text = "Close";
                    state_printf("Open sucessed!\r\n", Color.Black);
                    //lab_Device_Connect.Text = "设备已连接";

                }
                catch
                {
                    //MessageBox.Show("端口打开错误，请检查串口", "错误");
                    state_printf("Open error, please check!\r\n", Color.Red);
                }
            }
            else  // 串口已经打开 需要关闭 
            {
                try
                {
                    serialPort.Close(); // 关闭串口 
                    buttonOpenCom.Text = "Open";
                    state_printf("Close sucessed!\r\n", Color.Black);
                    //lab_Device_Connect.Text = "设备已断开";
                }
                catch
                {
                    //MessageBox.Show("关闭串口错误");
                    state_printf("Close error!\r\n", Color.Red);
                }
            }

        }/* 打开串口 按键监听*/

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

        private void checkBoxShowTime_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
