using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car
    {
        private IEngine engine;
        private string plate;
        public int MaxEngineTemp = 200;

        //constructor
        public Car(IEngine e, string p)
        {
            engine = e;
            plate = p;
        }

        //Get plate of car
        public string GetPlate()
        {
            return plate;
        }

        //Method to perform acceleration to x rpm
        public void Accelerate(int rpmToAdd)
        {
            int currentRpm = engine.GetRpm();
            currentRpm += rpmToAdd;
            engine.SetRpm(currentRpm);
        }

        //Method to retrieve speed
        public int GetSpeed()
        {
            return engine.GetRpm()/10;
        }

        public string GetStatus()
        {
            return engine.GetTemp().GetTemperature() <= MaxEngineTemp ? "ok" : "overheating";
        }
    }
}
