using TinyDRPC.Theme;
using DiscordRPC;
using TinyDRPC.Utils;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using Microsoft.Win32;

namespace TinyDRPC
{
    public partial class MainForm : Form
    {

        private DiscordRpcClient? drpc;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool ValidateUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            topText.Text = config.topText;
            secondText.Text = config.bottomText;
            discordAppId.Text = config.discordAppId;
            button1Label.Text = config.button1Label;
            button2Label.Text = config.button2Label;
            button1URL.Text = config.button1Url;
            button2URL.Text = config.button2Url;
            largeImageKey.Text = config.largeImageKey;
            largeImageText.Text = config.largeImageText;
            smallImageKey.Text = config.smallImageKey;
            enableButton1.CheckState = config.enableButton1 ? CheckState.Checked : CheckState.Unchecked;
            enableButton2.CheckState = config.enableButton2 ? CheckState.Checked : CheckState.Unchecked;
            runOnStartup.CheckState = config.runOnStartup ? CheckState.Checked : CheckState.Unchecked;
            saveState.CheckState = config.saveRunningState ? CheckState.Checked : CheckState.Unchecked;
            runMinimized.CheckState = config.runMinimized ? CheckState.Checked : CheckState.Unchecked;

            runMinimized.Enabled = runOnStartup.Checked;

            if(runMinimized.Enabled && runOnStartup.Enabled)
            {
                
                System.Threading.Timer timer = new System.Threading.Timer(new TimerCallback((obj) =>
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        tinyDrpcNotifyIcon.Visible = true;
                        Hide();
                    }));
                }), null, 1, Timeout.Infinite);
                
            }

            if (config.saveRunningState == true && config.lastStateIsRunning == true)
            {
                prepareDaemon();
            }

            switch (SystemTheme.Status())
            {
                case 0: _ = new DarkModeCS(this); break;
            }
        }

        private void topText_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.topText = topText.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void secondText_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.bottomText = secondText.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void discordAppId_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.discordAppId = discordAppId.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void button1Label_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.button1Label = button1Label.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void button2Label_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.button2Label = button2Label.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void button1URL_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.button1Url = button1URL.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void button2URL_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.button2Url = button2URL.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void enableButton1_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.enableButton1 = enableButton1.Checked;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }
        private void enableButton2_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.enableButton2 = enableButton2.Checked;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void largeImageKey_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.largeImageKey = largeImageKey.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void smallImageKey_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.smallImageKey = smallImageKey.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void largeImageText_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.largeImageText = largeImageText.Text;
            configManager.SaveConfiguration(config);
            applyChange.Enabled = true;
        }

        private void runOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.runOnStartup = runOnStartup.Checked;
            configManager.SaveConfiguration(config);

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (runOnStartup.Checked)
                rk.SetValue("TinyDRPC", Application.ExecutablePath);
            else
                rk.DeleteValue("TinyDRPC", false);

            runMinimized.Enabled = runOnStartup.Checked;
        }

        private void saveState_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.saveRunningState = saveState.Checked;
            configManager.SaveConfiguration(config);
        }

        private void runMinimized_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.runMinimized = runMinimized.Checked;
            configManager.SaveConfiguration(config);
        }

        private void changeLastRunningState(Boolean state)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            TinyDRPC.Utils.Configuration config = configManager.LoadConfiguration();

            config.lastStateIsRunning = state;
            configManager.SaveConfiguration(config);
        }


        private void changeButtonState(Boolean enableButton, String text)
        {
            startDaemon.Enabled = enableButton;
            startDaemon.Text = text;
            startDaemonContext.Text = text;
            startDaemonContext.Enabled = enableButton;
            discordAppId.Enabled = enableButton;
        }

        private void updateUICurrentStatus(String text)
        {
            status.Text = text;
        }

        private void updateStatus()
        {

            var buttons = new List<DiscordRPC.Button>();

            if (enableButton1.Checked)
            {
                if (!ValidateUrl(button1URL.Text))
                {
                    MessageBox.Show("Please enter a valid url at button 1 url", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    buttons.Add(new DiscordRPC.Button()
                    {
                        Label = button1Label.Text ?? "No label",
                        Url = button1URL.Text
                    });
                }
            }

            if (enableButton2.Checked)
            {
                if (!ValidateUrl(button2URL.Text))
                {
                    MessageBox.Show("Please enter a valid url at button 2 url", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    buttons.Add(new DiscordRPC.Button()
                    {
                        Label = button2Label.Text ?? "No label",
                        Url = button2URL.Text
                    });
                }
            }

            drpc?.SetPresence(new RichPresence()
            {
                Details = topText.Text ?? "Please provide top text (TinyDRPC)",
                State = secondText.Text ?? "Please provide bottom text (TinyDRPC)",
                Buttons = buttons.ToArray(),
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey.Text,
                    LargeImageText = largeImageText.Text,
                    SmallImageKey = smallImageKey.Text
                }
            });
            applyChange.Enabled = false;
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
                        changeLastRunningState(true);
                    }));
                };

                drpc.Initialize();
                updateStatus();
            }));
        }

        private void handleStartDaemon()
        {
            if (drpc == null)
            {
                prepareDaemon();
            }
            else
            {
                drpc.Dispose();
                drpc = null;
                changeButtonState(true, "Start daemon");
                updateUICurrentStatus("Stopped");
                changeLastRunningState(false);
            }
        }

        private void startDaemon_Click(object sender, EventArgs e)
        {
            handleStartDaemon();
        }

        private void applyChange_Click(object sender, EventArgs e)
        {
            updateStatus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = new OpenBrowser("https://github.com/michioxd/TinyDRPC");
        }

        private void MainFormOnResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                tinyDrpcNotifyIcon.Visible = true;
            }
        }

        private void TrayIconOnClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            tinyDrpcNotifyIcon.Visible = false;
        }

        private void showMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            tinyDrpcNotifyIcon.Visible = false;
        }

        private void startDaemonContext_Click(object sender, EventArgs e)
        {
            handleStartDaemon();
        }

        private void exitContext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
