using FinalProject.Sensoris;

namespace FinalProject.Abstract;

public abstract class Agent
{
    protected string NameAgent { get; private set; }
    protected string Rank { get; private set; }
    protected List<Sensor> Sensoris;
    
    public Agent(string nameAgent, string rank)
    {
        NameAgent = nameAgent;
        Rank = rank;
        Sensoris = new List<Sensor>();
    }
    
    public abstract bool Matching(string typeSensoris);
    public abstract bool Activate(int numberActivetion);
}
