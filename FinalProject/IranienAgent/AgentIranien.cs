using FinalProject.Abstract;

namespace FinalProject.IranienAgent;

public class AgentIranien : AbsAgentIran
{
    public AgentIranien(string nameAgent, string rank) : base(nameAgent, rank)
    {
    }

    public override bool Maching(string typeSensoris)
    {
        return true;
    }

    public override bool Activate(int numberActivetion)
    {
        return false;
    }
}