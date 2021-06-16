using System;
using System.Collections.Generic;
using System.Text;

namespace CreatorPlanets
{
    class Properties
    {
       
        public string name { get; set; }
        public string rotation_period { get; set; }
        public string orbital_period { get; set; }
        public string diameter { get; set; }
        public string climate { get; set; }
        public string gravity { get; set; }
        public string terrain { get; set; }
        public string surface_water { get; set; }
        public string population { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
        public int residents { get; set; }
        public int films { get; set; }
        public int id { get; set; }
    }
}
