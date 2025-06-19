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
    

    public override void Activate(Agent agent)
    {
        BreaksCount++;
        if (isBreaks())
        {
            Console.WriteLine("PulseSensor has broken after 3 activations.");
            RemoveBrokenSensor(agent);
        }
        
    }
    public void RemoveBrokenSensor(Agent agent)
    {
        if (agent.AttachSensors.Contains(this))
        {
            agent.AttachSensors.Remove(this);
        }
    }
    
    public bool isBreaks()
    {
        return BreaksCount>=3;
    }
}