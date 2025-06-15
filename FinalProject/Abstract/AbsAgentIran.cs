using FinalProject.Sensoris;

namespace FinalProject.Abstract;

public abstract class AbsAgentIran
{
    protected string NameAgent { get; private set; }
    protected string Rank { get; private set; }
    protected List<Sensor> Sensoris;
    
    public AbsAgentIran(string nameAgent, string rank)
    {
        NameAgent = nameAgent;
        Rank = rank;
        Sensoris = new List<Sensor>();
    }
    
    public abstract bool Maching(string typeSensoris);
    public abstract bool Activate(int numberActivetion);
}
