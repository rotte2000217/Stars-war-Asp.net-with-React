using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarAPI.Models
{
    public class Palnet_Pilots
    {
        public string Planet { get; set; }
        public int Pilots { get; set; }
        public List<Pilot_Details> Pilots_Data { get; set; }
    }
    public class Pilot_Details
    {
        public string Name { get; set; }
        public string Specie_Name { get; set; }
    }

}