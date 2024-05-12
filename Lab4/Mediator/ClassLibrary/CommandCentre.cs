using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public void RequestLand(Aircraft aircraft)
        {
            Runway freeRunway = _runways.FirstOrDefault(r => !r.IsBusy);
            if (freeRunway != null)
            {
                aircraft.Land();
                Console.WriteLine($"on Runway {freeRunway.Id}.");
                freeRunway.IsBusy = true;
                freeRunway.HighLightRed();
            }
            else
            {
                Console.WriteLine("No free runways available for landing.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            Runway occupiedRunway = _runways.FirstOrDefault(r => r.IsBusy);
            if (occupiedRunway != null)
            {
                aircraft.TakeOff();
                Console.WriteLine($"from Runway {occupiedRunway.Id}.");
                occupiedRunway.IsBusy = false;
                occupiedRunway.HighLightGreen();
            }
            else
            {
                Console.WriteLine("No aircraft on a runway ready for takeoff.");
            }
        }
    }
}
