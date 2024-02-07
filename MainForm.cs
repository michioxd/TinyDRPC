using DiscordNowRich.Theme;
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

        private void updateStatus()
        {
            drpc?.SetPresence(new RichPresence()
                {
                    Details = "Example Project",
                    State = "csharp example",
                    Assets = new Assets()
                    {
                        LargeImageKey = "image_large",
                        LargeImageText = "Lachee's Discord IPC Library",
                        SmallImageKey = "image_small"
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

            this.Invoke(new MethodInvoker(delegate ()
            {
                drpc = new DiscordRpcClient(discordAppId.Text);
                drpc.OnError += (s, e) =>
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        MessageBox.Show("Cannon start daemon: " + e, "Error while starting daemon",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        changeButtonState(true, "Start daemon");
                    }));
                    return;
                };

                drpc.OnReady += (s, e) =>
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        changeButtonState(true, "Stop daemon");
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
            }
        }
    }
}
