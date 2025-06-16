using FinalProject.Abstract;

namespace FinalProject.IranienAgent;

public class SympleAgent : Agent
{
    public SympleAgent(string nameAgent, string rank) : base(nameAgent, rank)
    {
    }

    public override bool Matching(string typeSensoris)
    {
        return true;
    }

    public override bool Activate(int numberActivetion)
    {
        return false;
    }
}