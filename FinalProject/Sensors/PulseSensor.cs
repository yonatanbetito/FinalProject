using FinalProject.Abstract;
using FinalProject.Enum;
using FinalProject.Interface;

namespace FinalProject.Sensoris;

public class PulseSensor : Sensors
{
    public int BreaksCount { get; set; }
    public PulseSensor(Enums.SensorType type, int breaksCount) : base(type)
    {
        BreaksCount = 0;
    }
    

    public static void RemoveBrokenPulseSensor(Agent agent)
    {
        foreach (Sensors sensor in agent.AttachSensors.ToList())
        {
            if (sensor.TypeOfSensor.ToString().ToLower() == "pulse" &&
                ((PulseSensor)sensor).isBreaks())
            {
                agent.AttachSensors.Remove(sensor);
                break;
            }
        }
    }
    
    public bool isBreaks()
    {
        return BreaksCount>=3;
    }


}