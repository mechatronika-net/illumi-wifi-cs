using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mechatronika_net.illumiwifi.led
{
    /// <summary>
    /// 
    /// </summary>
    public class Color
    {
        /// <summary>
        /// 
        /// </summary>
        public byte R { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte G { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte B { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte W { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="w"></param>
        public Color(byte r, byte g, byte b, byte w = 0)
        {
            R = (byte)r;
            G = (byte)g;
            B = (byte)b;
            W = (byte)w;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Color FromSdColor(System.Drawing.Color c)
        {
            return new Color(c.R, c.G, c.B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Color ToSdColor()
        {
            return System.Drawing.Color.FromArgb(R, G, B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public Color FromSwmColor(System.Windows.Media.Color c)
        {
            return new Color(c.R, c.G, c.B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public System.Windows.Media.Color ToSwmColor()
        {
            return System.Windows.Media.Color.FromRgb(R, G, B);
        }


    }
}
