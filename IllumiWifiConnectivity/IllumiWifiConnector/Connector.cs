using System;
using System.Collections.Generic;

namespace mechatronika_net.illumiwifi.led
{
    /// <summary>
    /// Illumi WiFi API implementation class
    /// </summary>
    public class Connector
    {
        private readonly UdpConnection _udp;

        /// <summary>
        /// Current state of connection
        /// </summary>
        public bool Connected { get; private set; }

        /// <summary>
        /// Constructor for IllumiWifiConnection
        /// </summary>
        public Connector()
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
        /// <param name="rgb">Color to set</param>
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
        /// <param name="rgb">Color to set</param>
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

            _udp.Send(buf, 7);
            buf = null;

            _udp.Receive(ref buf);

            return buf != null;

        }

        /// <summary>
        /// Sets new default color
        /// </summary>
        /// <param name="rgb">Color to set as default</param>
        /// <returns>Set attempt status</returns>
        public bool SendDefaultColor(Color rgb)
        {
            if (!Connected) return false;

            var buf = new byte[5];

            buf[0] = 0x02;      //set default color
            buf[1] = rgb.R;
            buf[2] = rgb.G;
            buf[3] = rgb.B;
            buf[4] = rgb.W;

            _udp.Send(buf, 5);
            buf = null;

            _udp.Receive(ref buf);
            return buf != null;

        }

        /// <summary>
        /// Gets colors from illumi WiFi
        /// </summary>
        /// <returns>Dictionary containing currentColor and defaultColor, null in case of error</returns>
        public IDictionary<string, Color> GetColors()
        {
            if (!Connected) return null;

            var buf = new byte[1];

            buf[0] = 0x82;      //get colors

            _udp.Send(buf, 1);
            buf = null;

            _udp.Receive(ref buf);

            if (buf == null || buf.Length != 8) return null;

            var d = new Dictionary<string, Color>();

            var r = buf[0];
            var g = buf[1];
            var b = buf[2];
            var w = buf[3];

            d.Add("currentColor", new Color(r, g, b, w));

            r = buf[4];
            g = buf[5];
            b = buf[6];
            w = buf[7];

            d.Add("defaultColor", new Color(r, g, b, w));

            return d;
        }

        /// <summary>
        /// Gets illumi WiFi info
        /// </summary>
        /// <returns>Dictionary containing version and MAC address, null in case of error</returns>
        public Dictionary<string, string> GetInfo()
        {
            if (!Connected) return null;

            var buf = new byte[1];

            buf[0] = 0x81;

            _udp.Send(buf, 1);
            buf = null;

            _udp.Receive(ref buf);

            if (buf == null) return null;

            var d = new Dictionary<string, string>();

            var c = new char[buf.Length];
            for (var i = 0; i < buf.Length; i++)
            {
                c[i] = Convert.ToChar(buf[i]);
            }

            var version = $"{c[0]}{c[1]}{c[2]}{c[3]}{c[4]}{c[5]}";
            version = version.ToUpper();
            d.Add("version", version);

            var mac = $"{c[6]}{c[7]}-{c[8]}{c[9]}-{c[10]}{c[11]}-{c[12]}{c[13]}-{c[14]}{c[15]}-{c[16]}{c[17]}";
            mac = mac.ToUpper();
            d.Add("mac", mac);
            return d;
        }

    }
}
