using IllumiWifiConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IllumiWifiControl
{
    public partial class Form1 : Form
    {
        private readonly IllumiWifiConnection _illumiWifiConnection;

        private Color _rgb, _rgbDefault;

        private string _mac;

        public Form1()
        {
            InitializeComponent();
            _illumiWifiConnection = new IllumiWifiConnection();
            _rgb = Color.Black;
            _rgbDefault = Color.Black;
            _mac = string.Empty;

            pnlDefault.BackColor = _rgbDefault;
            pnlCurrent.BackColor = _rgb;
            label6.Text = _mac;
        }

        private void btnGetColors_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.GetColors(ref _rgb, ref _rgbDefault);

            if (!rv)
            {
                ConsolePrint("Błąd podczas pobierania kolorów.");
                return;
            }
            pnlCurrent.BackColor = _rgb;
            pnlDefault.BackColor = _rgbDefault;
        }

        private void btnSendWithFade_Click(object sender, EventArgs e)
        {
            var fadeTime = scrTime.Value + 1;
            var rv = _illumiWifiConnection.SendFadeToColor(_rgb, fadeTime);

            if (!rv)
            {
                ConsolePrint("Błąd wysyłania bieżącego koloru z przejściem barw.");
            }
        }

        private void btnSendDefault_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.SendDefaultColor(_rgbDefault);
            if (!rv)
            {
                ConsolePrint("Błąd podczas wysyłania domyślnego koloru.");
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (_illumiWifiConnection.Connected)
            {
                _illumiWifiConnection.Disconnect();
                btnConnection.Text = @"Połącz";
            }
            else
            {
                var rv = _illumiWifiConnection.Connect(tbHost.Text.ToString());
                if (rv)
                {
                    btnConnection.Text = @"Rozłącz";
                }
                else
                {
                    ConsolePrint("Problem z połączeniem.");
                }
            }
        }

        private void pnlCurrent_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _rgb;
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            _rgb = colorDialog1.Color;
            pnlCurrent.BackColor = _rgb;
        }

        private void pnlDefault_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _rgbDefault;
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            _rgbDefault = colorDialog1.Color;
            pnlDefault.BackColor = _rgbDefault;
        }

        private void btnSendCurrent_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.SendColor(_rgb);
            if (!rv)
            {
                ConsolePrint("Błąd podczas wysyłania bieżącego koloru.");
            }
        }

        private void btnGetMac_Click(object sender, EventArgs e)
        {
            var rv = _illumiWifiConnection.GetMacAddress(ref _mac);
            if (!rv)
            {
                ConsolePrint("Błąd podczas pobierania adresu MAC.");
            }
            label6.Text = _mac;
        }

        private void ConsolePrint(string msg)
        {
            textBox1.AppendText(msg + Environment.NewLine);

        }
    }
}
