using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSerial_3
{
    public partial class ViewForm : Form
    {
        private ViewSerialPort _viewSerialPort;
        public ViewForm(ViewSerialPort viewSerialPort)
        {
            InitializeComponent();
            _viewSerialPort = viewSerialPort;
            Controls.Add(viewSerialPort);
            _viewSerialPort.Invalidate();
        }
    }
}
