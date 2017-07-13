using System;
using System.Linq;
using System.Windows.Forms;
using mechatronika_net.illumiwifi.led;

namespace mechatronika_net.illumiwifi.examples
{
    public partial class Form1 : Form
    {
        private readonly Connector _illumiWifiConnection;

        private Color _rgb, _rgbDefault;

        private string _mac, _version;

        public Form1()
        {
            InitializeComponent();
            _illumiWifiConnection = new Connector();
            _rgb = Color.FromSdColor(System.Drawing.Color.Black);
            _rgbDefault = Color.FromSdColor(System.Drawing.Color.Black);
            _mac = string.Empty;
            _version = string.Empty;

            pnlDefault.BackColor = _rgbDefault.ToSdColor();
            pnlCurrent.BackColor = _rgb.ToSdColor();
            label6.Text = _mac;
            label8.Text = _version;
        }

        private void btnGetColors_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.GetColors();

            if (rv == null)
            {
                ConsolePrint("Error while getting colors.");
                return;
            }

            _rgb = rv.SingleOrDefault(x => x.Key == "currentCollor").Value;
            _rgbDefault = rv.SingleOrDefault(x => x.Key == "defaultColor").Value;

            pnlCurrent.BackColor = _rgb?.ToSdColor() ?? System.Drawing.Color.Black;
            pnlDefault.BackColor = _rgbDefault?.ToSdColor() ?? System.Drawing.Color.Black;
        }

        private void btnSendWithFade_Click(object sender, EventArgs e)
        {
            var fadeTime = scrTime.Value + 1;
            var rv = _illumiWifiConnection.SendFadeToColor(_rgb, fadeTime);

            if (!rv)
            {
                ConsolePrint("Error while sending color with fade.");
            }
        }

        private void btnSendDefault_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.SendDefaultColor(_rgbDefault);
            if (!rv)
            {
                ConsolePrint("Error while sending default color.");
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (_illumiWifiConnection.Connected)
            {
                _illumiWifiConnection.Disconnect();
                btnConnection.Text = @"Connect";
            }
            else
            {
                var rv = _illumiWifiConnection.Connect(tbHost.Text);
                if (rv)
                {
                    btnConnection.Text = @"Disconnect";
                }
                else
                {
                    ConsolePrint("Error while trying to establish connection.");
                }
            }
        }

        private void pnlCurrent_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _rgb.ToSdColor();
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            _rgb = Color.FromSdColor(colorDialog1.Color);//colorDialog1.Color;
            pnlCurrent.BackColor = _rgb.ToSdColor();
        }

        private void pnlDefault_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _rgbDefault.ToSdColor();
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            _rgbDefault = Color.FromSdColor(colorDialog1.Color);
            pnlDefault.BackColor = _rgbDefault.ToSdColor();
        }

        private void btnSendCurrent_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.SendColor(_rgb);
            if (!rv)
            {
                ConsolePrint("Error while sending current color.");
            }
        }

        private void btnGetMac_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.GetInfo();
            if (rv == null)
            {
                ConsolePrint("Error while getting info.");
            }
            else
            {
                _mac = rv.SingleOrDefault(x => x.Key == "mac").Value;
                _version = rv.SingleOrDefault(x => x.Key == "version").Value;

                label6.Text = _mac;
                label8.Text = _version;
            }

        }

        private void ConsolePrint(string msg)
        {
            textBox1.AppendText(msg + Environment.NewLine);
        }
    }
}
