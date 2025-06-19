using System.Linq;
using FinalProject.Abstract;
using FinalProject.Enum;
using FinalProject.Interface;

namespace FinalProject.Sensoris;

public class ThermalSensor : Sensors
{
        public ThermalSensor(Enums.SensorType type) : base(type) { }
        
        public override void Activate(Agent nameAgent)
        {
            if (!nameAgent.WeakSensors.Any())
                Console.WriteLine("Weak not fund");
            var weakSensorsList = nameAgent.WeakSensors.ToList();
            Random random = new Random();
            Enums.SensorType revealed = weakSensorsList[random.Next(weakSensorsList.Count)];
            Console.WriteLine($"Thermal Sensor reveals: {revealed}");
        }
    
}
