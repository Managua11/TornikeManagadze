using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitoring
{
    internal class TemperatureAlert
    {
        public void OnTemperatureAlert(string message)
        {
            Console.WriteLine(message);
        }
    }
}
