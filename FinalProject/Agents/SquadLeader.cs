using FinalProject.Abstract;
using FinalProject.Enum;

namespace FinalProject.IranienAgent;

public class SquadLeader : Agent
{
    public SquadLeader() : base(Enums.AgentRank.SquadLeader)
    {
        WeakSensors = new Enums.SensorType[] { Enums.SensorType.Audio, Enums.SensorType.Audio,Enums.SensorType.Thermal,Enums.SensorType.Pulse};
        
    }
    
}