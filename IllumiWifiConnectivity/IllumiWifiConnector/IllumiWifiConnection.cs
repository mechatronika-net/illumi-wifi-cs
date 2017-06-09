using System.Drawing;

namespace IllumiWifiConnector
{
    /// <summary>
    /// Illumi WiFi API implementation class
    /// </summary>
    public class IllumiWifiConnection
    {
        private readonly UdpConnection _udp;

        /// <summary>
        /// Current state of connection
        /// </summary>
        public bool Connected { get; private set; }

        /// <summary>
        /// Constructor for IllumiWifiConnection
        /// </summary>
        public IllumiWifiConnection()
        {
            _udp = new UdpConnection();
            Connected = false;
        }

        /// <summary>
        /// Opens UPD connection to illumi WiFi
        /// </summary>
        /// <param name="hostName">Address of illumi WiFi</param>
        /// <returns>Connection attempt status</returns>
        public bool Connect(string hostName)
        {
            var rv = _udp.Connect(hostName, 5401);
            Connected = rv;
            return rv;
        }

        /// <summary>
        /// Closes connection to illumi WiFi
        /// </summary>
        /// <returns>Disconnection attempt status</returns>
        public bool Disconnect()
        {
            var rv = _udp.Disconnect();
            Connected = !rv;
            return rv;
        }

        /// <summary>
        /// Sets new current color
        /// </summary>
        /// <param name="rgb">Color to set (System.Drawing.Color)</param>
        /// <returns>Set attempt status</returns>
        public bool SendColor(Color rgb)
        {
            if (!Connected) return false;

            var buf = new byte[4];

            buf[0] = 0x01;      //set color
            buf[1] = rgb.R;
            buf[2] = rgb.G;
            buf[3] = rgb.B;

            _udp.Send(buf, 4);
            buf = null;

            _udp.Receive(ref buf);
            return buf != null;

        }

        /// <summary>
        /// Sets new current color with fade
        /// </summary>
        /// <param name="rgb">Color to set (System.Drawing.Color)</param>
        /// <param name="fadeTime"></param>
        /// <returns>Set attempt status</returns>
        public bool SendFadeToColor(Color rgb, int fadeTime)
        {
            if (!Connected) return false;

            var buf = new byte[6];


            buf[0] = 0x03;
            buf[1] = rgb.R;
            buf[2] = rgb.G;
            buf[3] = rgb.B;
            buf[4] = (byte)(fadeTime / 0x100);
            buf[5] = (byte)(fadeTime % 0x100);

            _udp.Send(buf, 6);
            buf = null;

            _udp.Receive(ref buf);

            return buf != null;

        }

        /// <summary>
        /// Sets new default color
        /// </summary>
        /// <param name="rgb">Color to set as default (System.Drawing.Color)</param>
        /// <returns>Set attempt status</returns>
        public bool SendDefaultColor(Color rgb)
        {
            if (!Connected) return false;

            var buf = new byte[4];

            buf[0] = 0x02;      //set default color
            buf[1] = rgb.R;
            buf[2] = rgb.G;
            buf[3] = rgb.B;

            _udp.Send(buf, 4);
            buf = null;

            _udp.Receive(ref buf);
            return buf != null;

        }

        /// <summary>
        /// Gets colors from illumi WiFi
        /// </summary>
        /// <param name="rgb">Reference to variable that should hold current color (System.Drawing.Color)</param>
        /// <param name="rgbDefault">Reference to variable that should hold default color (System.Drawing.Color)</param>
        /// <returns>Read attempt status</returns>
        public bool GetColors(ref Color rgb, ref Color rgbDefault)
        {
            if (!Connected) return false;

            var buf = new byte[1];

            buf[0] = 0x82;      //get colors

            _udp.Send(buf, 1);
            buf = null;

            _udp.Receive(ref buf);

            if (buf == null || buf.Length != 6) return false;

            var r = buf[0];
            var g = buf[1];
            var b = buf[2];

            rgb = Color.FromArgb(r, g, b);

            r = buf[3];
            g = buf[4];
            b = buf[5];

            rgbDefault = Color.FromArgb(r, g, b);

            return true;
        }

    }
}
