using FinalProject.Enum;
using FinalProject.Interface;
using FinalProject.Sensoris;

namespace FinalProject.Abstract;

public abstract class Agent
{
    protected string NameAgent { get; private set; }
    protected Enums.AgentRank Rank { get; private set; }
    protected internal List<Sensors> AttachSensors { get; set; }
    protected internal Enums.SensorType[] WeakSensors;
    
    public Agent(string nameAgent, Enums.AgentRank rank)
    {
        NameAgent = nameAgent;
        Rank = rank;
        AttachSensors = new List<Sensors>();
        WeakSensors = new Enums.SensorType[NumOfSlots()];
    }

    public int NumOfSlots() => 2 * (int)(Rank + 1);

    public virtual bool Matching(string typeSensor)
    {
        if (!System.Enum.TryParse<Enums.SensorType>(typeSensor, true, out var type))
            return false;
        
        int allowedCount = WeakSensors.Count(w => w == type);
        if (allowedCount == 0)
            return false;
        
        int alreadyAttached = AttachSensors.Count(s => s.TypeOfSensor == type);
        if (alreadyAttached >= allowedCount)
            return false;
        
        Sensors sensor = Sensors.CreateByName(typeSensor);
        if (sensor == null)
            return false;

        AttachSensors.Add(sensor);
        return true; 
    }

    public virtual void Activate()
    {
        foreach (var sensor in AttachSensors)
        {
            if (WeakSensors.Contains(sensor.TypeOfSensor) && !sensor.IsActive)
            {
                sensor.IsActive = true;
            }
        }
    }
}
