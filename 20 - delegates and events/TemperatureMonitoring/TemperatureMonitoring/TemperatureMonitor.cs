using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitoring
{
    internal class TemperatureMonitor
    {
        public delegate void TemperatureChangeHandler(string message);

        public event TemperatureChangeHandler TemperatureAlert;

        public void CheckTemperature(double temperature)
        {
            if (temperature > 40)
            {
                TemperatureAlert?.Invoke($"Alert! Temperature is too high: {temperature}°C");
            }
            else if (temperature < 0)
            {
                TemperatureAlert?.Invoke($"Alert! Temperature is too low: {temperature}°C");
            }
        }
    }
}