using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSerial_3
{
    public class Model
    {
        public List<Led> Leds { get; set; }

        public Model()
        {
            Leds = new List<Led>();
            CreateLeds();
        }

        private void CreateLeds()
        {
            Led led1 = new Led(new PointF(12, 2));
            Led led2 = new Led(new PointF(62, 2));
            Leds.Add(led1);
            Leds.Add(led2);
        }
    }
}
