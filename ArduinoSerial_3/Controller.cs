using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ArduinoSerial_3
{
    public class Controller
    {
        private Model _model;
        private ViewForm _viewForm;
        private Timer _timer;
        
        public Controller(Model model, ViewForm viewForm)
        {
            _model = model;
            _timer = new Timer(30);
            _timer.Elapsed += TimerOnElapsed;
            _viewForm = viewForm;
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            var qq = 0;
        }
    }
}
