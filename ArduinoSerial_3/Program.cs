using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSerial_3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new Model();
            var viewSerialPort = new ViewSerialPort(model);
            var viewForm = new ViewForm(viewSerialPort);
            
            var controller = new Controller(model, viewForm);
            Application.Run(viewForm);
        }
    }
}
