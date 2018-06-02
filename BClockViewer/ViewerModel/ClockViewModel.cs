using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using BerlinClock;
using System.Windows.Threading;
using BClockViewer.Viewer;
namespace BClockViewer.Viewer
{
    class ClockViewModel : INotifyPropertyChanged
    {
        private readonly DispatcherTimer _timer;
        private readonly CberlinClock _clock;
        private long _counter = 0;

        public string TheTime
        {
            get
            {
                return _clock.Generate(DateTime.Now);
            }
        }

        public long Counter
        {
            get
            {
                return _counter;
            }
            set
            {
                _counter = value;
                OnPropertyChanged("Counter");
            }
        }

        public ClockViewModel()
        {
            _clock = new CberlinClock();

            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        void TimerTick(object sender, EventArgs e)
        {
            Counter++;
            OnPropertyChanged("TheTime");
        }

        public event PropertyChangedEventHandler PropertyChanged;



        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
