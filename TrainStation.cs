using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainStation
    {
       public string ArrivalTime;
       public string ArrivalPlatform;
       public string DepartureTime;
       public string Name;
           
        public TrainStation(string ArrivalTime, string ArrivalTrack, string DepartureTime, string Name)
        {
             this.ArrivalTime = ArrivalTime;
             this.ArrivalPlatform = ArrivalPlatform;
             this.DepartureTime = DepartureTime;
             this.Name = Name;
        }
        
    }
}
