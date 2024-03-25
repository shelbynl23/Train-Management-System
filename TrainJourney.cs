using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class TrainJourney : ITrainJourney
    {
        List<TrainStation> stations;
        List<ITrainDisplay> observers;
        TrainStation currentStation;

        public void NextStation()
        {
            // checks to see if this the last station by index order
            if (stations.IndexOf(currentStation) >= stations.Count - 1)
            {
                stations.Reverse();
            }

            else
            {
                currentStation = stations[stations.IndexOf(currentStation) + 1];
            }
            NotifyObservers();
        }

        public void AddObserver(ITrainDisplay observer)
        {
            observers.Add(observer);
            observer.Update(currentStation);

        }

        public void RemoveObserver(ITrainDisplay observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (ITrainDisplay display in observers)
            {
                display.Update(currentStation);
            }
        }

        public TrainJourney()
        {
            stations = new List<TrainStation>();
            observers = new List<ITrainDisplay>();
            stations.Add(new TrainStation("01:23", "spoor 1", "04:30", "Rotterdam"));
            stations.Add(new TrainStation("2:45", "spoor 2", "3:30", "Breda"));
            stations.Add(new TrainStation("3:45", "spoor 1", "5:30", "Leiden"));
            currentStation = stations[0];
        }
    }
}
