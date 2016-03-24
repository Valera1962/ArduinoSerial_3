using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSerial_3
{
    [Flags]
    public enum StateColorLed
    {
        Green,
        Red,
        Coral   //когда не светит
    }
    [Flags]
    public enum StateLed
    {
        Light,     //светит
        NotLight,  //не светит
        Flashing   //мигает
    }

    public class Led
    {
        public PointF Location { get; set; }
        public Point SizeLed { get; set; }
        public StateLed StateLed { get; set; }
        public StateColorLed StateColorLed { get; set; }

        public Led(PointF location)
        {
            Location = location;
            StateLed = StateLed.NotLight;
            StateColorLed = StateColorLed.Coral;
            SizeLed = new Point(16, 16);
        }
    }
}
