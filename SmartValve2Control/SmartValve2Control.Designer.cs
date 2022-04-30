using System.Windows.Forms;

namespace SmartValve2Control
{
    partial class SmartValveControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartValveControl));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialogLog = new System.Windows.Forms.OpenFileDialog();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.tabControlMode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxCom = new System.Windows.Forms.GroupBox();
            this.buttonOpenCom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxByteSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonBleSearch = new System.Windows.Forms.Button();
            this.comboBoxBleDevice = new System.Windows.Forms.ComboBox();
            this.labelBle = new System.Windows.Forms.Label();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxShowTime = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxState = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSeleceAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopy2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR25 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend25 = new System.Windows.Forms.Button();
            this.textBoxCmd25 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR24 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend24 = new System.Windows.Forms.Button();
            this.textBoxCmd24 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR23 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend23 = new System.Windows.Forms.Button();
            this.textBoxCmd23 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR22 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend22 = new System.Windows.Forms.Button();
            this.textBoxCmd22 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR21 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend21 = new System.Windows.Forms.Button();
            this.textBoxCmd21 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR19 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend19 = new System.Windows.Forms.Button();
            this.textBoxCmd19 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR18 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend18 = new System.Windows.Forms.Button();
            this.textBoxCmd18 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR17 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend17 = new System.Windows.Forms.Button();
            this.textBoxCmd17 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR16 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend16 = new System.Windows.Forms.Button();
            this.textBoxCmd16 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR15 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend15 = new System.Windows.Forms.Button();
            this.textBoxCmd15 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR14 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend14 = new System.Windows.Forms.Button();
            this.textBoxCmd14 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR13 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend13 = new System.Windows.Forms.Button();
            this.textBoxCmd13 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR12 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend12 = new System.Windows.Forms.Button();
            this.textBoxCmd12 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR11 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend11 = new System.Windows.Forms.Button();
            this.textBoxCmd11 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR10 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend10 = new System.Windows.Forms.Button();
            this.textBoxCmd10 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR9 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend9 = new System.Windows.Forms.Button();
            this.textBoxCmd9 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR8 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend8 = new System.Windows.Forms.Button();
            this.textBoxCmd8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR7 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend7 = new System.Windows.Forms.Button();
            this.textBoxCmd7 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR6 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend6 = new System.Windows.Forms.Button();
            this.textBoxCmd6 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR5 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend5 = new System.Windows.Forms.Button();
            this.textBoxCmd5 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR4 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend4 = new System.Windows.Forms.Button();
            this.textBoxCmd4 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR3 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend3 = new System.Windows.Forms.Button();
            this.textBoxCmd3 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR2 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend2 = new System.Windows.Forms.Button();
            this.textBoxCmd2 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR1 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend1 = new System.Windows.Forms.Button();
            this.textBoxCmd1 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBR20 = new System.Windows.Forms.CheckBox();
            this.buttonCmdSend20 = new System.Windows.Forms.Button();
            this.textBoxCmd20 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveLog = new System.Windows.Forms.CheckBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.statusBottom = new System.Windows.Forms.StatusStrip();
            this.slab_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.slab_send = new System.Windows.Forms.ToolStripStatusLabel();
            this.slab_recv = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tabControlMode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxCom.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogLog
            // 
            this.openFileDialogLog.FileName = "openFileDialogLog";
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1605, 1341);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Size = new System.Drawing.Size(1041, 757);
            this.splitContainer4.SplitterDistance = 143;
            this.splitContainer4.TabIndex = 21;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.tabControlMode);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer7.Size = new System.Drawing.Size(1041, 143);
            this.splitContainer7.SplitterDistance = 674;
            this.splitContainer7.TabIndex = 9;
            // 
            // tabControlMode
            // 
            this.tabControlMode.Controls.Add(this.tabPage1);
            this.tabControlMode.Controls.Add(this.tabPage2);
            this.tabControlMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMode.Location = new System.Drawing.Point(0, 0);
            this.tabControlMode.Name = "tabControlMode";
            this.tabControlMode.SelectedIndex = 0;
            this.tabControlMode.Size = new System.Drawing.Size(674, 143);
            this.tabControlMode.TabIndex = 1;
            this.tabControlMode.SelectedIndexChanged += new System.EventHandler(this.tabControlMode_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxCom);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 114);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "COM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxCom
            // 
            this.groupBoxCom.Controls.Add(this.buttonOpenCom);
            this.groupBoxCom.Controls.Add(this.label5);
            this.groupBoxCom.Controls.Add(this.comboBoxByteSize);
            this.groupBoxCom.Controls.Add(this.label4);
            this.groupBoxCom.Controls.Add(this.comboBoxParity);
            this.groupBoxCom.Controls.Add(this.label3);
            this.groupBoxCom.Controls.Add(this.comboBoxStopBit);
            this.groupBoxCom.Controls.Add(this.label2);
            this.groupBoxCom.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxCom.Controls.Add(this.label1);
            this.groupBoxCom.Controls.Add(this.comboBoxCom);
            this.groupBoxCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCom.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCom.Name = "groupBoxCom";
            this.groupBoxCom.Size = new System.Drawing.Size(660, 108);
            this.groupBoxCom.TabIndex = 3;
            this.groupBoxCom.TabStop = false;
            this.groupBoxCom.Text = "COM Port Setting";
            // 
            // buttonOpenCom
            // 
            this.buttonOpenCom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpenCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenCom.Image = global::SmartValve2Control.Properties.Resources.close;
            this.buttonOpenCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenCom.Location = new System.Drawing.Point(481, 56);
            this.buttonOpenCom.Name = "buttonOpenCom";
            this.buttonOpenCom.Size = new System.Drawing.Size(85, 28);
            this.buttonOpenCom.TabIndex = 12;
            this.buttonOpenCom.Text = "  Open";
            this.buttonOpenCom.UseVisualStyleBackColor = false;
            this.buttonOpenCom.Click += new System.EventHandler(this.buttonOpenCom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "ByteSize:";
            // 
            // comboBoxByteSize
            // 
            this.comboBoxByteSize.FormattingEnabled = true;
            this.comboBoxByteSize.Location = new System.Drawing.Point(87, 59);
            this.comboBoxByteSize.Name = "comboBoxByteSize";
            this.comboBoxByteSize.Size = new System.Drawing.Size(80, 23);
            this.comboBoxByteSize.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity:";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(481, 31);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(85, 23);
            this.comboBoxParity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "StopBits:";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Location = new System.Drawing.Point(276, 60);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(92, 23);
            this.comboBoxStopBit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(276, 30);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(92, 23);
            this.comboBoxBaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port:";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(87, 30);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(80, 23);
            this.comboBoxCom.TabIndex = 0;
            this.comboBoxCom.DropDown += new System.EventHandler(this.comboBoxCom_DropDown);
            this.comboBoxCom.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCom_SelectionChangeCommitted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 114);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BLE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonConnect);
            this.groupBox3.Controls.Add(this.buttonBleSearch);
            this.groupBox3.Controls.Add(this.comboBoxBleDevice);
            this.groupBox3.Controls.Add(this.labelBle);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 105);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ble Control Setting";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(444, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(91, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonBleSearch
            // 
            this.buttonBleSearch.Location = new System.Drawing.Point(353, 30);
            this.buttonBleSearch.Name = "buttonBleSearch";
            this.buttonBleSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonBleSearch.TabIndex = 2;
            this.buttonBleSearch.Text = "Search";
            this.buttonBleSearch.UseVisualStyleBackColor = true;
            this.buttonBleSearch.Visible = false;
            this.buttonBleSearch.Click += new System.EventHandler(this.buttonBleSearch_Click);
            // 
            // comboBoxBleDevice
            // 
            this.comboBoxBleDevice.FormattingEnabled = true;
            this.comboBoxBleDevice.Location = new System.Drawing.Point(106, 30);
            this.comboBoxBleDevice.Name = "comboBoxBleDevice";
            this.comboBoxBleDevice.Size = new System.Drawing.Size(230, 23);
            this.comboBoxBleDevice.TabIndex = 1;
            // 
            // labelBle
            // 
            this.labelBle.AutoSize = true;
            this.labelBle.Location = new System.Drawing.Point(6, 33);
            this.labelBle.Name = "labelBle";
            this.labelBle.Size = new System.Drawing.Size(95, 15);
            this.labelBle.TabIndex = 0;
            this.labelBle.Text = "Ble Device:";
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer8.Size = new System.Drawing.Size(363, 143);
            this.splitContainer8.SplitterDistance = 185;
            this.splitContainer8.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.checkBoxShowTime);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 143);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(7, 72);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear Message";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxShowTime
            // 
            this.checkBoxShowTime.AutoSize = true;
            this.checkBoxShowTime.Location = new System.Drawing.Point(7, 32);
            this.checkBoxShowTime.Name = "checkBoxShowTime";
            this.checkBoxShowTime.Size = new System.Drawing.Size(101, 19);
            this.checkBoxShowTime.TabIndex = 0;
            this.checkBoxShowTime.Text = "Show time";
            this.checkBoxShowTime.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelMode);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 143);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mode";
            // 
            // labelMode
            // 
            this.labelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMode.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMode.ForeColor = System.Drawing.Color.Green;
            this.labelMode.Location = new System.Drawing.Point(24, 49);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(118, 46);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "UART";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer3.Size = new System.Drawing.Size(1041, 610);
            this.splitContainer3.SplitterDistance = 524;
            this.splitContainer3.TabIndex = 20;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1041, 524);
            this.splitContainer2.SplitterDistance = 516;
            this.splitContainer2.TabIndex = 19;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxMessage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxState);
            this.splitContainer1.Size = new System.Drawing.Size(516, 524);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 17;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMessage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxMessage.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxMessage.Size = new System.Drawing.Size(516, 395);
            this.richTextBoxMessage.TabIndex = 15;
            this.richTextBoxMessage.Text = "";
            this.richTextBoxMessage.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSelectAll,
            this.toolStripMenuItemCopy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 52);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItemSelectAll
            // 
            this.toolStripMenuItemSelectAll.Name = "toolStripMenuItemSelectAll";
            this.toolStripMenuItemSelectAll.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItemSelectAll.Text = "SelectAll";
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItemCopy.Text = "Cpoy";
            // 
            // richTextBoxState
            // 
            this.richTextBoxState.ContextMenuStrip = this.contextMenuStrip2;
            this.richTextBoxState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxState.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxState.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxState.Name = "richTextBoxState";
            this.richTextBoxState.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxState.Size = new System.Drawing.Size(516, 125);
            this.richTextBoxState.TabIndex = 16;
            this.richTextBoxState.Text = "";
            this.richTextBoxState.WordWrap = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSeleceAll2,
            this.toolStripMenuItemCopy2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(143, 52);
            this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItemSeleceAll2
            // 
            this.toolStripMenuItemSeleceAll2.Name = "toolStripMenuItemSeleceAll2";
            this.toolStripMenuItemSeleceAll2.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItemSeleceAll2.Text = "SelectAll";
            // 
            // toolStripMenuItemCopy2
            // 
            this.toolStripMenuItemCopy2.Name = "toolStripMenuItemCopy2";
            this.toolStripMenuItemCopy2.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItemCopy2.Text = "Copy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command List";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel27, 0, 25);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel26, 0, 24);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel25, 0, 23);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel24, 0, 22);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel23, 0, 21);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel21, 0, 19);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel20, 0, 18);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel19, 0, 17);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel18, 0, 16);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel17, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel16, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel15, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel14, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel13, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel12, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel11, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel22, 0, 20);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 26;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 494);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 4;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel27.Controls.Add(this.checkBoxBR25, 2, 0);
            this.tableLayoutPanel27.Controls.Add(this.buttonCmdSend25, 3, 0);
            this.tableLayoutPanel27.Controls.Add(this.textBoxCmd25, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 703);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 1;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel27.TabIndex = 19;
            // 
            // checkBoxBR25
            // 
            this.checkBoxBR25.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR25.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR25.Name = "checkBoxBR25";
            this.checkBoxBR25.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR25.TabIndex = 0;
            this.checkBoxBR25.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend25
            // 
            this.buttonCmdSend25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend25.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend25.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend25.Name = "buttonCmdSend25";
            this.buttonCmdSend25.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend25.TabIndex = 2;
            this.buttonCmdSend25.Text = "25";
            this.buttonCmdSend25.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd25
            // 
            this.textBoxCmd25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd25.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd25.Name = "textBoxCmd25";
            this.textBoxCmd25.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd25.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(3, 1);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "25:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 4;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel26.Controls.Add(this.checkBoxBR24, 2, 0);
            this.tableLayoutPanel26.Controls.Add(this.buttonCmdSend24, 3, 0);
            this.tableLayoutPanel26.Controls.Add(this.textBoxCmd24, 1, 0);
            this.tableLayoutPanel26.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 675);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel26.TabIndex = 19;
            // 
            // checkBoxBR24
            // 
            this.checkBoxBR24.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR24.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR24.Name = "checkBoxBR24";
            this.checkBoxBR24.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR24.TabIndex = 0;
            this.checkBoxBR24.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend24
            // 
            this.buttonCmdSend24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend24.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend24.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend24.Name = "buttonCmdSend24";
            this.buttonCmdSend24.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend24.TabIndex = 2;
            this.buttonCmdSend24.Text = "24";
            this.buttonCmdSend24.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd24
            // 
            this.textBoxCmd24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd24.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd24.Name = "textBoxCmd24";
            this.textBoxCmd24.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd24.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(3, 1);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 21);
            this.label15.TabIndex = 3;
            this.label15.Text = "24:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 4;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel25.Controls.Add(this.checkBoxBR23, 2, 0);
            this.tableLayoutPanel25.Controls.Add(this.buttonCmdSend23, 3, 0);
            this.tableLayoutPanel25.Controls.Add(this.textBoxCmd23, 1, 0);
            this.tableLayoutPanel25.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(3, 647);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel25.TabIndex = 19;
            // 
            // checkBoxBR23
            // 
            this.checkBoxBR23.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR23.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR23.Name = "checkBoxBR23";
            this.checkBoxBR23.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR23.TabIndex = 0;
            this.checkBoxBR23.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend23
            // 
            this.buttonCmdSend23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend23.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend23.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend23.Name = "buttonCmdSend23";
            this.buttonCmdSend23.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend23.TabIndex = 2;
            this.buttonCmdSend23.Text = "23";
            this.buttonCmdSend23.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd23
            // 
            this.textBoxCmd23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd23.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd23.Name = "textBoxCmd23";
            this.textBoxCmd23.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd23.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 1);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "23:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 4;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel24.Controls.Add(this.checkBoxBR22, 2, 0);
            this.tableLayoutPanel24.Controls.Add(this.buttonCmdSend22, 3, 0);
            this.tableLayoutPanel24.Controls.Add(this.textBoxCmd22, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 619);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel24.TabIndex = 19;
            // 
            // checkBoxBR22
            // 
            this.checkBoxBR22.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR22.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR22.Name = "checkBoxBR22";
            this.checkBoxBR22.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR22.TabIndex = 0;
            this.checkBoxBR22.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend22
            // 
            this.buttonCmdSend22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend22.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend22.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend22.Name = "buttonCmdSend22";
            this.buttonCmdSend22.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend22.TabIndex = 2;
            this.buttonCmdSend22.Text = "22";
            this.buttonCmdSend22.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd22
            // 
            this.textBoxCmd22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd22.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd22.Name = "textBoxCmd22";
            this.textBoxCmd22.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd22.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 1);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "22:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 4;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel23.Controls.Add(this.checkBoxBR21, 2, 0);
            this.tableLayoutPanel23.Controls.Add(this.buttonCmdSend21, 3, 0);
            this.tableLayoutPanel23.Controls.Add(this.textBoxCmd21, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 591);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel23.TabIndex = 19;
            // 
            // checkBoxBR21
            // 
            this.checkBoxBR21.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR21.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR21.Name = "checkBoxBR21";
            this.checkBoxBR21.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR21.TabIndex = 0;
            this.checkBoxBR21.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend21
            // 
            this.buttonCmdSend21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend21.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend21.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend21.Name = "buttonCmdSend21";
            this.buttonCmdSend21.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend21.TabIndex = 2;
            this.buttonCmdSend21.Text = "21";
            this.buttonCmdSend21.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd21
            // 
            this.textBoxCmd21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd21.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd21.Name = "textBoxCmd21";
            this.textBoxCmd21.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd21.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 1);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "21:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 4;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel21.Controls.Add(this.checkBoxBR19, 2, 0);
            this.tableLayoutPanel21.Controls.Add(this.buttonCmdSend19, 3, 0);
            this.tableLayoutPanel21.Controls.Add(this.textBoxCmd19, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 535);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel21.TabIndex = 18;
            // 
            // checkBoxBR19
            // 
            this.checkBoxBR19.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR19.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR19.Name = "checkBoxBR19";
            this.checkBoxBR19.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR19.TabIndex = 0;
            this.checkBoxBR19.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend19
            // 
            this.buttonCmdSend19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend19.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend19.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend19.Name = "buttonCmdSend19";
            this.buttonCmdSend19.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend19.TabIndex = 2;
            this.buttonCmdSend19.Text = "19";
            this.buttonCmdSend19.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd19
            // 
            this.textBoxCmd19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd19.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd19.Name = "textBoxCmd19";
            this.textBoxCmd19.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd19.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "19:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 4;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel20.Controls.Add(this.checkBoxBR18, 2, 0);
            this.tableLayoutPanel20.Controls.Add(this.buttonCmdSend18, 3, 0);
            this.tableLayoutPanel20.Controls.Add(this.textBoxCmd18, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 507);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel20.TabIndex = 18;
            // 
            // checkBoxBR18
            // 
            this.checkBoxBR18.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR18.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR18.Name = "checkBoxBR18";
            this.checkBoxBR18.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR18.TabIndex = 0;
            this.checkBoxBR18.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend18
            // 
            this.buttonCmdSend18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend18.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend18.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend18.Name = "buttonCmdSend18";
            this.buttonCmdSend18.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend18.TabIndex = 2;
            this.buttonCmdSend18.Text = "18";
            this.buttonCmdSend18.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd18
            // 
            this.textBoxCmd18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd18.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd18.Name = "textBoxCmd18";
            this.textBoxCmd18.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd18.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "18:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 4;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel19.Controls.Add(this.checkBoxBR17, 2, 0);
            this.tableLayoutPanel19.Controls.Add(this.buttonCmdSend17, 3, 0);
            this.tableLayoutPanel19.Controls.Add(this.textBoxCmd17, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 479);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel19.TabIndex = 18;
            // 
            // checkBoxBR17
            // 
            this.checkBoxBR17.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR17.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR17.Name = "checkBoxBR17";
            this.checkBoxBR17.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR17.TabIndex = 0;
            this.checkBoxBR17.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend17
            // 
            this.buttonCmdSend17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend17.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend17.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend17.Name = "buttonCmdSend17";
            this.buttonCmdSend17.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend17.TabIndex = 2;
            this.buttonCmdSend17.Text = "17";
            this.buttonCmdSend17.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd17
            // 
            this.textBoxCmd17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd17.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd17.Name = "textBoxCmd17";
            this.textBoxCmd17.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd17.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "17:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 4;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.Controls.Add(this.checkBoxBR16, 2, 0);
            this.tableLayoutPanel18.Controls.Add(this.buttonCmdSend16, 3, 0);
            this.tableLayoutPanel18.Controls.Add(this.textBoxCmd16, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 451);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel18.TabIndex = 17;
            // 
            // checkBoxBR16
            // 
            this.checkBoxBR16.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR16.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR16.Name = "checkBoxBR16";
            this.checkBoxBR16.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR16.TabIndex = 0;
            this.checkBoxBR16.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend16
            // 
            this.buttonCmdSend16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend16.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend16.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend16.Name = "buttonCmdSend16";
            this.buttonCmdSend16.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend16.TabIndex = 2;
            this.buttonCmdSend16.Text = "16";
            this.buttonCmdSend16.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd16
            // 
            this.textBoxCmd16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd16.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd16.Name = "textBoxCmd16";
            this.textBoxCmd16.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd16.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "16:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 4;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel17.Controls.Add(this.checkBoxBR15, 2, 0);
            this.tableLayoutPanel17.Controls.Add(this.buttonCmdSend15, 3, 0);
            this.tableLayoutPanel17.Controls.Add(this.textBoxCmd15, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.label45, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 423);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel17.TabIndex = 16;
            // 
            // checkBoxBR15
            // 
            this.checkBoxBR15.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR15.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR15.Name = "checkBoxBR15";
            this.checkBoxBR15.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR15.TabIndex = 0;
            this.checkBoxBR15.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend15
            // 
            this.buttonCmdSend15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend15.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend15.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend15.Name = "buttonCmdSend15";
            this.buttonCmdSend15.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend15.TabIndex = 2;
            this.buttonCmdSend15.Text = "15";
            this.buttonCmdSend15.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd15
            // 
            this.textBoxCmd15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd15.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd15.Name = "textBoxCmd15";
            this.textBoxCmd15.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd15.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(3, 1);
            this.label45.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(34, 21);
            this.label45.TabIndex = 3;
            this.label45.Text = "15:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 4;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel16.Controls.Add(this.checkBoxBR14, 2, 0);
            this.tableLayoutPanel16.Controls.Add(this.buttonCmdSend14, 3, 0);
            this.tableLayoutPanel16.Controls.Add(this.textBoxCmd14, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.label44, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 395);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel16.TabIndex = 16;
            // 
            // checkBoxBR14
            // 
            this.checkBoxBR14.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR14.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR14.Name = "checkBoxBR14";
            this.checkBoxBR14.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR14.TabIndex = 0;
            this.checkBoxBR14.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend14
            // 
            this.buttonCmdSend14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend14.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend14.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend14.Name = "buttonCmdSend14";
            this.buttonCmdSend14.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend14.TabIndex = 2;
            this.buttonCmdSend14.Text = "14";
            this.buttonCmdSend14.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd14
            // 
            this.textBoxCmd14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd14.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd14.Name = "textBoxCmd14";
            this.textBoxCmd14.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd14.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(3, 1);
            this.label44.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(34, 21);
            this.label44.TabIndex = 3;
            this.label44.Text = "14:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 4;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel15.Controls.Add(this.checkBoxBR13, 2, 0);
            this.tableLayoutPanel15.Controls.Add(this.buttonCmdSend13, 3, 0);
            this.tableLayoutPanel15.Controls.Add(this.textBoxCmd13, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.label43, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 367);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel15.TabIndex = 16;
            // 
            // checkBoxBR13
            // 
            this.checkBoxBR13.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR13.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR13.Name = "checkBoxBR13";
            this.checkBoxBR13.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR13.TabIndex = 0;
            this.checkBoxBR13.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend13
            // 
            this.buttonCmdSend13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend13.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend13.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend13.Name = "buttonCmdSend13";
            this.buttonCmdSend13.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend13.TabIndex = 2;
            this.buttonCmdSend13.Text = "13";
            this.buttonCmdSend13.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd13
            // 
            this.textBoxCmd13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd13.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd13.Name = "textBoxCmd13";
            this.textBoxCmd13.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd13.TabIndex = 1;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(3, 1);
            this.label43.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(34, 21);
            this.label43.TabIndex = 3;
            this.label43.Text = "13:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel14.Controls.Add(this.checkBoxBR12, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.buttonCmdSend12, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBoxCmd12, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.label42, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 339);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel14.TabIndex = 16;
            // 
            // checkBoxBR12
            // 
            this.checkBoxBR12.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR12.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR12.Name = "checkBoxBR12";
            this.checkBoxBR12.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR12.TabIndex = 0;
            this.checkBoxBR12.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend12
            // 
            this.buttonCmdSend12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend12.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend12.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend12.Name = "buttonCmdSend12";
            this.buttonCmdSend12.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend12.TabIndex = 2;
            this.buttonCmdSend12.Text = "12";
            this.buttonCmdSend12.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd12
            // 
            this.textBoxCmd12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd12.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd12.Name = "textBoxCmd12";
            this.textBoxCmd12.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd12.TabIndex = 1;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(3, 1);
            this.label42.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 21);
            this.label42.TabIndex = 3;
            this.label42.Text = "12:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 4;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel13.Controls.Add(this.checkBoxBR11, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.buttonCmdSend11, 3, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBoxCmd11, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.label41, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel13.TabIndex = 16;
            // 
            // checkBoxBR11
            // 
            this.checkBoxBR11.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR11.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR11.Name = "checkBoxBR11";
            this.checkBoxBR11.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR11.TabIndex = 0;
            this.checkBoxBR11.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend11
            // 
            this.buttonCmdSend11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend11.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend11.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend11.Name = "buttonCmdSend11";
            this.buttonCmdSend11.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend11.TabIndex = 2;
            this.buttonCmdSend11.Text = "11";
            this.buttonCmdSend11.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd11
            // 
            this.textBoxCmd11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd11.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd11.Name = "textBoxCmd11";
            this.textBoxCmd11.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd11.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(3, 1);
            this.label41.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(34, 21);
            this.label41.TabIndex = 3;
            this.label41.Text = "11:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 4;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.Controls.Add(this.checkBoxBR10, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.buttonCmdSend10, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.textBoxCmd10, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.label40, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel12.TabIndex = 16;
            // 
            // checkBoxBR10
            // 
            this.checkBoxBR10.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR10.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR10.Name = "checkBoxBR10";
            this.checkBoxBR10.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR10.TabIndex = 0;
            this.checkBoxBR10.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend10
            // 
            this.buttonCmdSend10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend10.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend10.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend10.Name = "buttonCmdSend10";
            this.buttonCmdSend10.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend10.TabIndex = 2;
            this.buttonCmdSend10.Text = "10";
            this.buttonCmdSend10.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd10
            // 
            this.textBoxCmd10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd10.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd10.Name = "textBoxCmd10";
            this.textBoxCmd10.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd10.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(3, 1);
            this.label40.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 21);
            this.label40.TabIndex = 3;
            this.label40.Text = "10:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.Controls.Add(this.checkBoxBR9, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.buttonCmdSend9, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.textBoxCmd9, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 255);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel11.TabIndex = 16;
            // 
            // checkBoxBR9
            // 
            this.checkBoxBR9.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR9.Location = new System.Drawing.Point(330, 0);
            this.checkBoxBR9.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxBR9.Name = "checkBoxBR9";
            this.checkBoxBR9.Size = new System.Drawing.Size(47, 22);
            this.checkBoxBR9.TabIndex = 0;
            this.checkBoxBR9.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend9
            // 
            this.buttonCmdSend9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend9.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend9.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend9.Name = "buttonCmdSend9";
            this.buttonCmdSend9.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend9.TabIndex = 2;
            this.buttonCmdSend9.Text = "9";
            this.buttonCmdSend9.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd9
            // 
            this.textBoxCmd9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd9.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd9.Name = "textBoxCmd9";
            this.textBoxCmd9.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd9.TabIndex = 1;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(3, 1);
            this.label36.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 21);
            this.label36.TabIndex = 3;
            this.label36.Text = "9:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Controls.Add(this.label39, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.label38, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label37, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel10.TabIndex = 16;
            // 
            // label39
            // 
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(380, 1);
            this.label39.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(89, 21);
            this.label39.TabIndex = 16;
            this.label39.Text = "Send";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(333, 1);
            this.label38.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 21);
            this.label38.TabIndex = 16;
            this.label38.Text = "BR";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Location = new System.Drawing.Point(50, 1);
            this.label37.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(277, 21);
            this.label37.TabIndex = 16;
            this.label37.Text = "Command";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.Controls.Add(this.checkBoxBR8, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.buttonCmdSend8, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBoxCmd8, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 227);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // checkBoxBR8
            // 
            this.checkBoxBR8.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR8.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR8.Name = "checkBoxBR8";
            this.checkBoxBR8.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR8.TabIndex = 0;
            this.checkBoxBR8.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend8
            // 
            this.buttonCmdSend8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend8.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend8.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend8.Name = "buttonCmdSend8";
            this.buttonCmdSend8.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend8.TabIndex = 2;
            this.buttonCmdSend8.Text = "8";
            this.buttonCmdSend8.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd8
            // 
            this.textBoxCmd8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd8.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd8.Name = "textBoxCmd8";
            this.textBoxCmd8.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd8.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "8:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.checkBoxBR7, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonCmdSend7, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxCmd7, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 199);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // checkBoxBR7
            // 
            this.checkBoxBR7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR7.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR7.Name = "checkBoxBR7";
            this.checkBoxBR7.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR7.TabIndex = 0;
            this.checkBoxBR7.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend7
            // 
            this.buttonCmdSend7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend7.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend7.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend7.Name = "buttonCmdSend7";
            this.buttonCmdSend7.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend7.TabIndex = 2;
            this.buttonCmdSend7.Text = "7";
            this.buttonCmdSend7.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd7
            // 
            this.textBoxCmd7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd7.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd7.Name = "textBoxCmd7";
            this.textBoxCmd7.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd7.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(3, 1);
            this.label29.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 21);
            this.label29.TabIndex = 3;
            this.label29.Text = "7:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Controls.Add(this.checkBoxBR6, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.buttonCmdSend6, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxCmd6, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 171);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // checkBoxBR6
            // 
            this.checkBoxBR6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR6.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR6.Name = "checkBoxBR6";
            this.checkBoxBR6.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR6.TabIndex = 0;
            this.checkBoxBR6.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend6
            // 
            this.buttonCmdSend6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend6.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend6.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend6.Name = "buttonCmdSend6";
            this.buttonCmdSend6.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend6.TabIndex = 2;
            this.buttonCmdSend6.Text = "6";
            this.buttonCmdSend6.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd6
            // 
            this.textBoxCmd6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd6.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd6.Name = "textBoxCmd6";
            this.textBoxCmd6.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd6.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(3, 1);
            this.label30.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 21);
            this.label30.TabIndex = 3;
            this.label30.Text = "6:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.checkBoxBR5, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonCmdSend5, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxCmd5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // checkBoxBR5
            // 
            this.checkBoxBR5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR5.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR5.Name = "checkBoxBR5";
            this.checkBoxBR5.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR5.TabIndex = 0;
            this.checkBoxBR5.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend5
            // 
            this.buttonCmdSend5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend5.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend5.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend5.Name = "buttonCmdSend5";
            this.buttonCmdSend5.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend5.TabIndex = 2;
            this.buttonCmdSend5.Text = "5";
            this.buttonCmdSend5.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd5
            // 
            this.textBoxCmd5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd5.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd5.Name = "textBoxCmd5";
            this.textBoxCmd5.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd5.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(3, 1);
            this.label31.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 21);
            this.label31.TabIndex = 3;
            this.label31.Text = "5:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.checkBoxBR4, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonCmdSend4, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxCmd4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label32, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // checkBoxBR4
            // 
            this.checkBoxBR4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR4.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR4.Name = "checkBoxBR4";
            this.checkBoxBR4.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR4.TabIndex = 0;
            this.checkBoxBR4.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend4
            // 
            this.buttonCmdSend4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend4.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend4.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend4.Name = "buttonCmdSend4";
            this.buttonCmdSend4.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend4.TabIndex = 2;
            this.buttonCmdSend4.Text = "4";
            this.buttonCmdSend4.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd4
            // 
            this.textBoxCmd4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd4.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd4.Name = "textBoxCmd4";
            this.textBoxCmd4.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd4.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(3, 1);
            this.label32.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 21);
            this.label32.TabIndex = 3;
            this.label32.Text = "4:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.checkBoxBR3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonCmdSend3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxCmd3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // checkBoxBR3
            // 
            this.checkBoxBR3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR3.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR3.Name = "checkBoxBR3";
            this.checkBoxBR3.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR3.TabIndex = 0;
            this.checkBoxBR3.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend3
            // 
            this.buttonCmdSend3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend3.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend3.Name = "buttonCmdSend3";
            this.buttonCmdSend3.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend3.TabIndex = 2;
            this.buttonCmdSend3.Text = "3";
            this.buttonCmdSend3.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd3
            // 
            this.textBoxCmd3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd3.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd3.Name = "textBoxCmd3";
            this.textBoxCmd3.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd3.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(3, 1);
            this.label33.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 21);
            this.label33.TabIndex = 3;
            this.label33.Text = "3:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxBR2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCmdSend2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCmd2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label34, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // checkBoxBR2
            // 
            this.checkBoxBR2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR2.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR2.Name = "checkBoxBR2";
            this.checkBoxBR2.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR2.TabIndex = 0;
            this.checkBoxBR2.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend2
            // 
            this.buttonCmdSend2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend2.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend2.Name = "buttonCmdSend2";
            this.buttonCmdSend2.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend2.TabIndex = 2;
            this.buttonCmdSend2.Text = "2";
            this.buttonCmdSend2.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd2
            // 
            this.textBoxCmd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd2.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd2.Name = "textBoxCmd2";
            this.textBoxCmd2.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd2.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(3, 1);
            this.label34.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 21);
            this.label34.TabIndex = 3;
            this.label34.Text = "2:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.checkBoxBR1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCmdSend1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCmd1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // checkBoxBR1
            // 
            this.checkBoxBR1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR1.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR1.Name = "checkBoxBR1";
            this.checkBoxBR1.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR1.TabIndex = 0;
            this.checkBoxBR1.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend1
            // 
            this.buttonCmdSend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend1.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend1.Name = "buttonCmdSend1";
            this.buttonCmdSend1.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend1.TabIndex = 2;
            this.buttonCmdSend1.Text = "1";
            this.buttonCmdSend1.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd1
            // 
            this.textBoxCmd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd1.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd1.Name = "textBoxCmd1";
            this.textBoxCmd1.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd1.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(3, 1);
            this.label35.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 21);
            this.label35.TabIndex = 3;
            this.label35.Text = "1:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 4;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel22.Controls.Add(this.checkBoxBR20, 2, 0);
            this.tableLayoutPanel22.Controls.Add(this.buttonCmdSend20, 3, 0);
            this.tableLayoutPanel22.Controls.Add(this.textBoxCmd20, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 563);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(472, 22);
            this.tableLayoutPanel22.TabIndex = 18;
            // 
            // checkBoxBR20
            // 
            this.checkBoxBR20.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxBR20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBR20.Location = new System.Drawing.Point(333, 3);
            this.checkBoxBR20.Name = "checkBoxBR20";
            this.checkBoxBR20.Size = new System.Drawing.Size(41, 16);
            this.checkBoxBR20.TabIndex = 0;
            this.checkBoxBR20.UseVisualStyleBackColor = true;
            // 
            // buttonCmdSend20
            // 
            this.buttonCmdSend20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCmdSend20.Location = new System.Drawing.Point(377, 0);
            this.buttonCmdSend20.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCmdSend20.Name = "buttonCmdSend20";
            this.buttonCmdSend20.Size = new System.Drawing.Size(95, 22);
            this.buttonCmdSend20.TabIndex = 2;
            this.buttonCmdSend20.Text = "20";
            this.buttonCmdSend20.UseVisualStyleBackColor = true;
            // 
            // textBoxCmd20
            // 
            this.textBoxCmd20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCmd20.Location = new System.Drawing.Point(50, 3);
            this.textBoxCmd20.Name = "textBoxCmd20";
            this.textBoxCmd20.Size = new System.Drawing.Size(277, 25);
            this.textBoxCmd20.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "20:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.statusBottom);
            this.splitContainer6.Size = new System.Drawing.Size(1041, 82);
            this.splitContainer6.SplitterDistance = 54;
            this.splitContainer6.SplitterWidth = 3;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer5.Size = new System.Drawing.Size(1041, 54);
            this.splitContainer5.SplitterDistance = 516;
            this.splitContainer5.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxSaveLog);
            this.groupBox4.Controls.Add(this.buttonLog);
            this.groupBox4.Controls.Add(this.textBoxLogPath);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 54);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File";
            // 
            // checkBoxSaveLog
            // 
            this.checkBoxSaveLog.AutoSize = true;
            this.checkBoxSaveLog.Location = new System.Drawing.Point(425, 21);
            this.checkBoxSaveLog.Name = "checkBoxSaveLog";
            this.checkBoxSaveLog.Size = new System.Drawing.Size(85, 19);
            this.checkBoxSaveLog.TabIndex = 13;
            this.checkBoxSaveLog.Text = "SaveLog";
            this.checkBoxSaveLog.UseVisualStyleBackColor = true;
            this.checkBoxSaveLog.CheckedChanged += new System.EventHandler(this.checkBoxSaveLog_CheckedChanged);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(6, 17);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(85, 25);
            this.buttonLog.TabIndex = 11;
            this.buttonLog.Text = "OpenFile";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Location = new System.Drawing.Point(97, 17);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(311, 25);
            this.textBoxLogPath.TabIndex = 12;
            // 
            // statusBottom
            // 
            this.statusBottom.AutoSize = false;
            this.statusBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBottom.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slab_info,
            this.slab_send,
            this.slab_recv});
            this.statusBottom.Location = new System.Drawing.Point(0, 0);
            this.statusBottom.Name = "statusBottom";
            this.statusBottom.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusBottom.Size = new System.Drawing.Size(1041, 25);
            this.statusBottom.TabIndex = 3;
            this.statusBottom.Text = "statusBottom";
            // 
            // slab_info
            // 
            this.slab_info.AutoSize = false;
            this.slab_info.Name = "slab_info";
            this.slab_info.Size = new System.Drawing.Size(650, 20);
            this.slab_info.Text = "上海德阀机械有限公司";
            this.slab_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slab_send
            // 
            this.slab_send.AutoSize = false;
            this.slab_send.Name = "slab_send";
            this.slab_send.Size = new System.Drawing.Size(120, 20);
            this.slab_send.Text = "Send:0";
            this.slab_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slab_recv
            // 
            this.slab_recv.AutoSize = false;
            this.slab_recv.Name = "slab_recv";
            this.slab_recv.Size = new System.Drawing.Size(120, 20);
            this.slab_recv.Text = "Reveive:0";
            this.slab_recv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SmartValveControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 757);
            this.Controls.Add(this.splitContainer4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SmartValveControl";
            this.Text = "SmartValveControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmartValveControl_FormClosing);
            this.Load += new System.EventHandler(this.SmartValveControl_Load);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.tabControlMode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxCom.ResumeLayout(false);
            this.groupBoxCom.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusBottom.ResumeLayout(false);
            this.statusBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.OpenFileDialog openFileDialogLog;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabControl tabControlMode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxShowTime;
        private System.Windows.Forms.GroupBox groupBoxCom;
        private System.Windows.Forms.Button buttonOpenCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxByteSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonBleSearch;
        private System.Windows.Forms.ComboBox comboBoxBleDevice;
        private System.Windows.Forms.Label labelBle;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBoxState;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.CheckBox checkBoxSaveLog;
        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.Button buttonLog;
        private StatusStrip statusBottom;
        private ToolStripStatusLabel slab_info;
        private ToolStripStatusLabel slab_send;
        private ToolStripStatusLabel slab_recv;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel17;
        private CheckBox checkBoxBR15;
        private Button buttonCmdSend15;
        private TextBox textBoxCmd15;
        private Label label45;
        private TableLayoutPanel tableLayoutPanel16;
        private CheckBox checkBoxBR14;
        private Button buttonCmdSend14;
        private TextBox textBoxCmd14;
        private Label label44;
        private TableLayoutPanel tableLayoutPanel15;
        private CheckBox checkBoxBR13;
        private Button buttonCmdSend13;
        private TextBox textBoxCmd13;
        private Label label43;
        private TableLayoutPanel tableLayoutPanel14;
        private CheckBox checkBoxBR12;
        private Button buttonCmdSend12;
        private TextBox textBoxCmd12;
        private Label label42;
        private TableLayoutPanel tableLayoutPanel13;
        private CheckBox checkBoxBR11;
        private Button buttonCmdSend11;
        private TextBox textBoxCmd11;
        private Label label41;
        private TableLayoutPanel tableLayoutPanel12;
        private CheckBox checkBoxBR10;
        private Button buttonCmdSend10;
        private TextBox textBoxCmd10;
        private Label label40;
        private TableLayoutPanel tableLayoutPanel11;
        private CheckBox checkBoxBR9;
        private Button buttonCmdSend9;
        private TextBox textBoxCmd9;
        private Label label36;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label39;
        private Label label38;
        private Label label37;
        private TableLayoutPanel tableLayoutPanel9;
        private CheckBox checkBoxBR8;
        private Button buttonCmdSend8;
        private TextBox textBoxCmd8;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel8;
        private CheckBox checkBoxBR7;
        private Button buttonCmdSend7;
        private TextBox textBoxCmd7;
        private Label label29;
        private TableLayoutPanel tableLayoutPanel7;
        private CheckBox checkBoxBR6;
        private Button buttonCmdSend6;
        private TextBox textBoxCmd6;
        private Label label30;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox checkBoxBR5;
        private Button buttonCmdSend5;
        private TextBox textBoxCmd5;
        private Label label31;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox checkBoxBR4;
        private Button buttonCmdSend4;
        private TextBox textBoxCmd4;
        private Label label32;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkBoxBR3;
        private Button buttonCmdSend3;
        private TextBox textBoxCmd3;
        private Label label33;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBoxBR2;
        private Button buttonCmdSend2;
        private TextBox textBoxCmd2;
        private Label label34;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox checkBoxBR1;
        private Button buttonCmdSend1;
        private TextBox textBoxCmd1;
        private Label label35;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel22;
        private CheckBox checkBoxBR20;
        private Button buttonCmdSend20;
        private TextBox textBoxCmd20;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel21;
        private CheckBox checkBoxBR19;
        private Button buttonCmdSend19;
        private TextBox textBoxCmd19;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel20;
        private CheckBox checkBoxBR18;
        private Button buttonCmdSend18;
        private TextBox textBoxCmd18;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel19;
        private CheckBox checkBoxBR17;
        private Button buttonCmdSend17;
        private TextBox textBoxCmd17;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel18;
        private CheckBox checkBoxBR16;
        private Button buttonCmdSend16;
        private TextBox textBoxCmd16;
        private Label label7;
        private GroupBox groupBox5;
        private Label labelMode;
        private TableLayoutPanel tableLayoutPanel27;
        private CheckBox checkBoxBR25;
        private Button buttonCmdSend25;
        private TextBox textBoxCmd25;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel26;
        private CheckBox checkBoxBR24;
        private Button buttonCmdSend24;
        private TextBox textBoxCmd24;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel25;
        private CheckBox checkBoxBR23;
        private Button buttonCmdSend23;
        private TextBox textBoxCmd23;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel24;
        private CheckBox checkBoxBR22;
        private Button buttonCmdSend22;
        private TextBox textBoxCmd22;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel23;
        private CheckBox checkBoxBR21;
        private Button buttonCmdSend21;
        private TextBox textBoxCmd21;
        private Label label12;
        private SplitContainer splitContainer7;
        private SplitContainer splitContainer8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemSelectAll;
        private ToolStripMenuItem toolStripMenuItemCopy;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItemSeleceAll2;
        private ToolStripMenuItem toolStripMenuItemCopy2;
    }
}

