using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSerial_3
{
    public partial class ViewSerialPort : UserControl
    {
        private Model _model;
        public ViewSerialPort(Model model)
        {
            InitializeComponent();
            _model = model;
        }

        private void ViewSerialPort_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Red);

            var listLeds = _model.Leds;
            foreach (var led in _model.Leds)
            {
                var qq = led;
                e.Graphics.FillEllipse(brush, 12, 2, 16, 16);
            }

        }
    }
}
