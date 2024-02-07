using TinyDRPC.Theme;
using DiscordRPC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyDRPC
{

    public partial class MainForm : Form
    {

        private DiscordRpcClient? drpc;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            switch (SystemTheme.Status())
            {
                case 0: _ = new DarkModeCS(this); break;
            }
        }

        private void changeButtonState(Boolean enableButton, String text)
        {
            startDaemon.Enabled = enableButton;
            startDaemon.Text = text;
        }

        private void updateUICurrentStatus(String text)
        {
            status.Text = text;
        }

        private void updateStatus()
        {
            drpc?.SetPresence(new RichPresence()
                {
                    Details = topText.Text ?? "Please provide top text (TinyDRPC)",
                    State = secondText.Text ?? "Please provide bottom text (TinyDRPC)",
                    Assets = new Assets()
                    {
                        LargeImageKey = largeImageKey.Text,
                        LargeImageText = largeImageText.Text,
                        SmallImageKey = smallImageKey.Text
                    }
                });
        }

        private void prepareDaemon()
        {
            if (discordAppId.Text == "" || discordAppId.Text == null)
            {
                MessageBox.Show("Please provide Discord App ID.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            changeButtonState(false, "Starting daemon...");
            updateUICurrentStatus("Starting daemon...");

            this.Invoke(new MethodInvoker(delegate ()
            {
                drpc = new DiscordRpcClient(discordAppId.Text);
                drpc.OnError += (s, e) =>
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        MessageBox.Show("Cannon start daemon: " + e + "\nMake sure you started Discord Client.", "Error while starting daemon",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        changeButtonState(true, "Start daemon");
                        updateUICurrentStatus("Tried to start but got error");
                    }));
                    return;
                };

                drpc.OnReady += (s, e) =>
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        changeButtonState(true, "Stop daemon");
                        updateUICurrentStatus("Running");
                    }));
                };

                drpc.Initialize();
                updateStatus();
            }));
        }

        private void startDaemon_Click(object sender, EventArgs e)
        {
            if(drpc == null)
            {
                prepareDaemon();
            } else
            {
                drpc.Dispose();
                drpc = null;
                changeButtonState(true, "Start daemon");
                updateUICurrentStatus("Stopped");
            }
        }
    }
}
