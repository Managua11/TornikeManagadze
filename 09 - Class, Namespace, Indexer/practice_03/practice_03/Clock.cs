using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Clock
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentException("Hours must be between 0 and 23.");
                _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Minutes must be between 0 and 59.");
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Seconds must be between 0 and 59.");
                _seconds = value;
            }
        }

        public void AddSecond()
        {
            _seconds++;
            if (_seconds > 59)
            {
                _seconds = 0;
                AddMinute();
            }
        }

        public void AddMinute()
        {
            _minutes++;
            if (_minutes > 59)
            {
                _minutes = 0;
                AddHour();
            }
        }

        public void AddHour()
        {
            _hours++;
            if (_hours > 23) _hours = 0;
        }

        public void SubtractSecond()
        {
            _seconds--;
            if (_seconds < 0)
            {
                _seconds = 59;
                SubtractMinute();
            }
        }

        public void SubtractMinute()
        {
            _minutes--;
            if (_minutes < 0)
            {
                _minutes = 59;
                SubtractHour();
            }
        }

        public void SubtractHour()
        {
            _hours--;
            if (_hours < 0) _hours = 23;
        }

        public void GetCurrentTime()
        {
            Console.WriteLine($"{_hours:D2}:{_minutes:D2}:{_seconds:D2}");
        }
    }
}