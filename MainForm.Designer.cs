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
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            topText = new TextBox();
            secondText = new TextBox();
            label5 = new Label();
            label3 = new Label();
            discordAppId = new TextBox();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            checkBox1 = new CheckBox();
            startDaemon = new Button();
            checkBox2 = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            largeImageKey = new TextBox();
            label8 = new Label();
            smallImageKey = new TextBox();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Version: 1.0 by michioxd";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Teal;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(0, 192, 192);
            linkLabel1.Location = new Point(12, 45);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(221, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/michioxd/TinyDRPC";
            linkLabel1.VisitedLinkColor = Color.Teal;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Top text";
            // 
            // topText
            // 
            topText.Location = new Point(12, 172);
            topText.Name = "topText";
            topText.Size = new Size(381, 23);
            topText.TabIndex = 4;
            topText.Text = "Using TinyDRPC";
            // 
            // secondText
            // 
            secondText.Location = new Point(12, 216);
            secondText.Name = "secondText";
            secondText.Size = new Size(381, 23);
            secondText.TabIndex = 5;
            secondText.Text = "https://github.com/michioxd/TinyDRPC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 6;
            label5.Text = "Second text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 130);
            label3.Name = "label3";
            label3.Size = new Size(176, 15);
            label3.TabIndex = 1;
            label3.Text = "To apply, please restart daemon.";
            // 
            // discordAppId
            // 
            discordAppId.Location = new Point(12, 104);
            discordAppId.Name = "discordAppId";
            discordAppId.Size = new Size(381, 23);
            discordAppId.TabIndex = 4;
            discordAppId.Text = "1184076027182452786";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 86);
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
            linkLabel2.Location = new Point(245, 130);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(148, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "How to get Discord App ID";
            linkLabel2.VisitedLinkColor = Color.Teal;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 340);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Enable time elapsed";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // startDaemon
            // 
            startDaemon.Location = new Point(12, 468);
            startDaemon.Name = "startDaemon";
            startDaemon.Size = new Size(381, 23);
            startDaemon.TabIndex = 8;
            startDaemon.Text = "Start daemon";
            startDaemon.UseVisualStyleBackColor = true;
            startDaemon.Click += startDaemon_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 365);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Run on startup";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 439);
            button1.Name = "button1";
            button1.Size = new Size(381, 23);
            button1.TabIndex = 8;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 242);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 6;
            label7.Text = "Large image key";
            // 
            // largeImageKey
            // 
            largeImageKey.Location = new Point(12, 260);
            largeImageKey.Name = "largeImageKey";
            largeImageKey.Size = new Size(381, 23);
            largeImageKey.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 286);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 6;
            label8.Text = "Small image key";
            // 
            // smallImageKey
            // 
            smallImageKey.Location = new Point(12, 304);
            smallImageKey.Name = "smallImageKey";
            smallImageKey.Size = new Size(381, 23);
            smallImageKey.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(405, 504);
            Controls.Add(checkBox2);
            Controls.Add(button1);
            Controls.Add(startDaemon);
            Controls.Add(checkBox1);
            Controls.Add(discordAppId);
            Controls.Add(label3);
            Controls.Add(smallImageKey);
            Controls.Add(largeImageKey);
            Controls.Add(secondText);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(topText);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "TinyDRPC";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label4;
        private TextBox topText;
        private TextBox secondText;
        private Label label5;
        private Label label3;
        private TextBox discordAppId;
        private Label label6;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
        private Button startDaemon;
        private CheckBox checkBox2;
        private Button button1;
        private Label label7;
        private TextBox largeImageKey;
        private Label label8;
        private TextBox smallImageKey;
    }
}
