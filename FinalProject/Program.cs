using FinalProject.Abstract;
using FinalProject.Enum;
using FinalProject.GameManager;
using FinalProject.IranienAgent;

namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        FootSoldier agent = new FootSoldier();
        SquadLeader agent2 = new SquadLeader();
        TheGame.Start(agent2);
    }
}