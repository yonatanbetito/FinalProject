using System.Globalization;
using FinalProject.Abstract;
using FinalProject.Enum;
using FinalProject.Interface;

namespace FinalProject.IranienAgent;

public class FootSoldier : Agent
{
    public FootSoldier() : base(Enums.AgentRank.FootSoldier)
    {
        WeakSensors = new Enums.SensorType[] { Enums.SensorType.Audio, Enums.SensorType.Thermal };
        
    }
    
    
}