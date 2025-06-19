using FinalProject.Abstract;
using FinalProject.Enum;
using FinalProject.Interface;

namespace FinalProject.Sensoris;

public class AudioSensor : Sensors
{
    public AudioSensor(Enums.SensorType nameSensor) : base(nameSensor)
    {
    }


    public override void Activate(Agent agent)
    {
    }
    
}