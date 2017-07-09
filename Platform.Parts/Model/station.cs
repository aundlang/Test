using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Parts.Model
{
    class Station
    {
        private static Station _station;

        public int stationId { get; set; }
        public string descrition { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public DateTime dtCreated { get; set; }

        private Station()
        {
            _station = new Station();
        }

        public static Station getInstance()
        {
            if (_station == null)
            {
                _station = new Station();
            }
            return _station;
        }
    }
}
