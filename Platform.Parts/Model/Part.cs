using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Parts
{
    public class Part
    {
        private static Part _part;

        public int partId { get; set; }
        public int vehicleId { get; set; }
        public string PartNumber { get; set; }
        public int stationId { get; set; }
        public DateTime dtCreated { get; set; }


        private Part()
        {
            _part = new Part();
        }

        public static Part GetInstance()
        {
            if (_part == null)
            {
                _part = new Part();
            }
            return _part;
        }
    }
}
