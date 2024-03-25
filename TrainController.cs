using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class TrainController : ITrainController
    {

        ITrainJourney journey;

        public void NextStation()
        {
            journey.NextStation();
        }

        public TrainController(ITrainJourney journey)
        {
            this.journey = journey;
        }


    }



}

