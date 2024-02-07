namespace TinyDRPC
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            topText = new TextBox();
            secondText = new TextBox();
            label5 = new Label();
            label3 = new Label();
            discordAppId = new TextBox();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            startDaemon = new Button();
            runOnStartup = new CheckBox();
            applyChange = new Button();
            label7 = new Label();
            largeImageKey = new TextBox();
            label8 = new Label();
            smallImageKey = new TextBox();
            label9 = new Label();
            largeImageText = new TextBox();
            label10 = new Label();
            status = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            enableButton2 = new CheckBox();
            button2URL = new TextBox();
            enableButton1 = new CheckBox();
            button2Label = new TextBox();
            button1URL = new TextBox();
            button1Label = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            tabPage2 = new TabPage();
            linkLabel3 = new LinkLabel();
            tabPage3 = new TabPage();
            runMinimized = new CheckBox();
            saveState = new CheckBox();
            tabPage4 = new TabPage();
            panel1 = new Panel();
            label15 = new Label();
            label2 = new Label();
            linkLabel4 = new LinkLabel();
            tinyDrpcNotifyIcon = new NotifyIcon(components);
            tinyDrpcTrayIconContext = new ContextMenuStrip(components);
            showMainWindowToolStripMenuItem = new ToolStripMenuItem();
            startDaemonContext = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitContext = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tinyDrpcTrayIconContext.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 15);
            label1.TabIndex = 1;
            label1.Text = "TinyDRPC - Tiny Discord Rich Presence Client";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Teal;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(0, 192, 192);
            linkLabel1.Location = new Point(12, 26);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(221, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/michioxd/TinyDRPC";
            linkLabel1.VisitedLinkColor = Color.Teal;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Top text";
            // 
            // topText
            // 
            topText.Location = new Point(6, 21);
            topText.Name = "topText";
            topText.Size = new Size(361, 23);
            topText.TabIndex = 4;
            topText.Text = "Using TinyDRPC";
            topText.TextChanged += topText_TextChanged;
            // 
            // secondText
            // 
            secondText.Location = new Point(6, 65);
            secondText.Name = "secondText";
            secondText.Size = new Size(361, 23);
            secondText.TabIndex = 5;
            secondText.Text = "https://github.com/michioxd/TinyDRPC";
            secondText.TextChanged += secondText_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 47);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 6;
            label5.Text = "Bottom text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 47);
            label3.Name = "label3";
            label3.Size = new Size(176, 15);
            label3.TabIndex = 1;
            label3.Text = "To apply, please restart daemon.";
            // 
            // discordAppId
            // 
            discordAppId.Location = new Point(6, 21);
            discordAppId.Name = "discordAppId";
            discordAppId.Size = new Size(361, 23);
            discordAppId.TabIndex = 4;
            discordAppId.Text = "1184076027182452786";
            discordAppId.TextChanged += discordAppId_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 4;
            label6.Text = "Discord App ID*";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Teal;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(0, 192, 192);
            linkLabel2.Location = new Point(219, 47);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(148, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "How to get Discord App ID";
            linkLabel2.VisitedLinkColor = Color.Teal;
            // 
            // startDaemon
            // 
            startDaemon.Location = new Point(12, 465);
            startDaemon.Name = "startDaemon";
            startDaemon.Size = new Size(381, 35);
            startDaemon.TabIndex = 8;
            startDaemon.Text = "Start daemon";
            startDaemon.UseVisualStyleBackColor = true;
            startDaemon.Click += startDaemon_Click;
            // 
            // runOnStartup
            // 
            runOnStartup.AutoSize = true;
            runOnStartup.Location = new Point(6, 74);
            runOnStartup.Name = "runOnStartup";
            runOnStartup.Size = new Size(104, 19);
            runOnStartup.TabIndex = 9;
            runOnStartup.Text = "Run on startup";
            runOnStartup.UseVisualStyleBackColor = true;
            runOnStartup.CheckedChanged += runOnStartup_CheckedChanged;
            // 
            // applyChange
            // 
            applyChange.Location = new Point(12, 424);
            applyChange.Name = "applyChange";
            applyChange.Size = new Size(381, 35);
            applyChange.TabIndex = 8;
            applyChange.Text = "Apply";
            applyChange.UseVisualStyleBackColor = true;
            applyChange.Click += applyChange_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 3);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 6;
            label7.Text = "Large image key";
            // 
            // largeImageKey
            // 
            largeImageKey.Location = new Point(6, 21);
            largeImageKey.Name = "largeImageKey";
            largeImageKey.Size = new Size(361, 23);
            largeImageKey.TabIndex = 5;
            largeImageKey.Text = "tinydrpc";
            largeImageKey.TextChanged += largeImageKey_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 91);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 6;
            label8.Text = "Small image key";
            // 
            // smallImageKey
            // 
            smallImageKey.Location = new Point(6, 109);
            smallImageKey.Name = "smallImageKey";
            smallImageKey.Size = new Size(361, 23);
            smallImageKey.TabIndex = 5;
            smallImageKey.TextChanged += smallImageKey_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 47);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 6;
            label9.Text = "Large image text";
            // 
            // largeImageText
            // 
            largeImageText.Location = new Point(6, 65);
            largeImageText.Name = "largeImageText";
            largeImageText.Size = new Size(361, 23);
            largeImageText.TabIndex = 5;
            largeImageText.Text = "TinyDRPC";
            largeImageText.TextChanged += largeImageText_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 46);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 10;
            label10.Text = "Status:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            status.Location = new Point(50, 46);
            status.Name = "status";
            status.Size = new Size(52, 15);
            status.TabIndex = 10;
            status.Text = "Stopped";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(381, 352);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(enableButton2);
            tabPage1.Controls.Add(button2URL);
            tabPage1.Controls.Add(enableButton1);
            tabPage1.Controls.Add(button2Label);
            tabPage1.Controls.Add(button1URL);
            tabPage1.Controls.Add(button1Label);
            tabPage1.Controls.Add(secondText);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(topText);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(373, 324);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Content";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // enableButton2
            // 
            enableButton2.AutoSize = true;
            enableButton2.Location = new Point(6, 207);
            enableButton2.Name = "enableButton2";
            enableButton2.Size = new Size(109, 19);
            enableButton2.TabIndex = 8;
            enableButton2.Text = "Enable button 2";
            enableButton2.UseVisualStyleBackColor = true;
            enableButton2.CheckedChanged += enableButton2_CheckedChanged;
            // 
            // button2URL
            // 
            button2URL.Location = new Point(6, 291);
            button2URL.Name = "button2URL";
            button2URL.Size = new Size(361, 23);
            button2URL.TabIndex = 7;
            button2URL.TextChanged += button2URL_TextChanged;
            // 
            // enableButton1
            // 
            enableButton1.AutoSize = true;
            enableButton1.Location = new Point(6, 94);
            enableButton1.Name = "enableButton1";
            enableButton1.Size = new Size(109, 19);
            enableButton1.TabIndex = 8;
            enableButton1.Text = "Enable button 1";
            enableButton1.UseVisualStyleBackColor = true;
            enableButton1.CheckedChanged += enableButton1_CheckedChanged;
            // 
            // button2Label
            // 
            button2Label.Location = new Point(6, 247);
            button2Label.Name = "button2Label";
            button2Label.Size = new Size(361, 23);
            button2Label.TabIndex = 7;
            button2Label.TextChanged += button2Label_TextChanged;
            // 
            // button1URL
            // 
            button1URL.Location = new Point(6, 178);
            button1URL.Name = "button1URL";
            button1URL.Size = new Size(361, 23);
            button1URL.TabIndex = 7;
            button1URL.TextChanged += button1URL_TextChanged;
            // 
            // button1Label
            // 
            button1Label.Location = new Point(6, 134);
            button1Label.Name = "button1Label";
            button1Label.Size = new Size(361, 23);
            button1Label.TabIndex = 7;
            button1Label.TextChanged += button1Label_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 273);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 6;
            label14.Text = "Button 2 URL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 160);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 6;
            label12.Text = "Button 1 URL";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 229);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 6;
            label13.Text = "Button 2 label";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 116);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 6;
            label11.Text = "Button 1 label";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(linkLabel3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(largeImageKey);
            tabPage2.Controls.Add(largeImageText);
            tabPage2.Controls.Add(smallImageKey);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(373, 324);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Image";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Teal;
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.FromArgb(0, 192, 192);
            linkLabel3.Location = new Point(181, 135);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(186, 15);
            linkLabel3.TabIndex = 7;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "How to upload and get image key";
            linkLabel3.VisitedLinkColor = Color.Teal;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(runMinimized);
            tabPage3.Controls.Add(discordAppId);
            tabPage3.Controls.Add(linkLabel2);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(saveState);
            tabPage3.Controls.Add(runOnStartup);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(373, 324);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Configuration";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // runMinimized
            // 
            runMinimized.AutoSize = true;
            runMinimized.Enabled = false;
            runMinimized.Location = new Point(113, 74);
            runMinimized.Name = "runMinimized";
            runMinimized.Size = new Size(106, 19);
            runMinimized.TabIndex = 10;
            runMinimized.Text = "Run minimized";
            runMinimized.UseVisualStyleBackColor = true;
            runMinimized.CheckedChanged += runMinimized_CheckedChanged;
            // 
            // saveState
            // 
            saveState.AutoSize = true;
            saveState.Location = new Point(6, 99);
            saveState.Name = "saveState";
            saveState.Size = new Size(203, 19);
            saveState.TabIndex = 9;
            saveState.Text = "Save running state for next statup";
            saveState.UseVisualStyleBackColor = true;
            saveState.CheckedChanged += saveState_CheckedChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel1);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(linkLabel4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(373, 324);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Info";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.tinydrpc_100x100;
            panel1.Location = new Point(135, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 100);
            panel1.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(87, 177);
            label15.Name = "label15";
            label15.Size = new Size(192, 15);
            label15.TabIndex = 1;
            label15.Text = "Version: 1.0 - powered by michioxd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 147);
            label2.Name = "label2";
            label2.Size = new Size(245, 15);
            label2.TabIndex = 1;
            label2.Text = "TinyDRPC - Tiny Discord Rich Presence Client";
            // 
            // linkLabel4
            // 
            linkLabel4.ActiveLinkColor = Color.Teal;
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.FromArgb(0, 192, 192);
            linkLabel4.Location = new Point(74, 207);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(221, 15);
            linkLabel4.TabIndex = 2;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "https://github.com/michioxd/TinyDRPC";
            linkLabel4.VisitedLinkColor = Color.Teal;
            linkLabel4.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tinyDrpcNotifyIcon
            // 
            tinyDrpcNotifyIcon.ContextMenuStrip = tinyDrpcTrayIconContext;
            tinyDrpcNotifyIcon.Icon = (Icon)resources.GetObject("tinyDrpcNotifyIcon.Icon");
            tinyDrpcNotifyIcon.Text = "TinyDRPC";
            tinyDrpcNotifyIcon.MouseDoubleClick += TrayIconOnClick;
            // 
            // tinyDrpcTrayIconContext
            // 
            tinyDrpcTrayIconContext.Items.AddRange(new ToolStripItem[] { showMainWindowToolStripMenuItem, startDaemonContext, toolStripSeparator1, exitContext });
            tinyDrpcTrayIconContext.Name = "tinyDrpcTrayIconContext";
            tinyDrpcTrayIconContext.Size = new Size(181, 76);
            // 
            // showMainWindowToolStripMenuItem
            // 
            showMainWindowToolStripMenuItem.Name = "showMainWindowToolStripMenuItem";
            showMainWindowToolStripMenuItem.Size = new Size(180, 22);
            showMainWindowToolStripMenuItem.Text = "Show Main Window";
            showMainWindowToolStripMenuItem.Click += showMainWindowToolStripMenuItem_Click;
            // 
            // startDaemonContext
            // 
            startDaemonContext.Name = "startDaemonContext";
            startDaemonContext.Size = new Size(180, 22);
            startDaemonContext.Text = "Start daemon";
            startDaemonContext.Click += startDaemonContext_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // exitContext
            // 
            exitContext.Name = "exitContext";
            exitContext.Size = new Size(180, 22);
            exitContext.Text = "Quit TinyDRPC";
            exitContext.Click += exitContext_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(404, 513);
            Controls.Add(tabControl1);
            Controls.Add(status);
            Controls.Add(label10);
            Controls.Add(applyChange);
            Controls.Add(startDaemon);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinyDRPC";
            Load += MainForm_Load;
            SizeChanged += MainFormOnResize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tinyDrpcTrayIconContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label4;
        private TextBox topText;
        private TextBox secondText;
        private Label label5;
        private Label label3;
        private TextBox discordAppId;
        private Label label6;
        private LinkLabel linkLabel2;
        private Button startDaemon;
        private CheckBox runOnStartup;
        private Button applyChange;
        private Label label7;
        private TextBox largeImageKey;
        private Label label8;
        private TextBox smallImageKey;
        private Label label9;
        private TextBox largeImageText;
        private Label label10;
        private Label status;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox enableButton1;
        private TextBox button1Label;
        private Label label11;
        private TabPage tabPage2;
        private CheckBox enableButton2;
        private TextBox button2URL;
        private TextBox button2Label;
        private TextBox button1URL;
        private Label label14;
        private Label label12;
        private Label label13;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private LinkLabel linkLabel3;
        private Panel panel1;
        private Label label15;
        private Label label2;
        private LinkLabel linkLabel4;
        private NotifyIcon tinyDrpcNotifyIcon;
        private ContextMenuStrip tinyDrpcTrayIconContext;
        private ToolStripMenuItem startDaemonContext;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitContext;
        private ToolStripMenuItem showMainWindowToolStripMenuItem;
        private CheckBox saveState;
        private CheckBox runMinimized;
    }
}
