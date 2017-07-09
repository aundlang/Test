using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Parts.Model
{
    public class Vehicle
    {
        private static Vehicle _vehicle;

        public int vehicleId { get; set; }
        public string vehicleNumber { get; set; }
        public int stationId { get; set; }
        public DateTime dtCreated { get; set; }

        private Vehicle()
        {
            _vehicle = new Vehicle();
        }

        public static Vehicle GetInstace()
        {
            if (_vehicle == null)
            {
                _vehicle = new Vehicle();
            }
            return _vehicle;
        }
    }
}
