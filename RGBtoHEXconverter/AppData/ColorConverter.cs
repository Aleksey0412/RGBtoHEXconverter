using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBtoHEXconverter.AppData
{
    public class ColorConverter
    {
        private int _red;
        private int _green;
        private int _blue;

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public ColorConverter()
        {
            _red = 0;
            _blue = 0;
            _green = 0;
        }

        public ColorConverter(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public string RGBtoHEX()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }
    }
}
