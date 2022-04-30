using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CityTemperatureModel
    {
        public List<weather> list { get; set; }
       
        public class weather
        {
            public Main main { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }
        
        }

        
    }
}
