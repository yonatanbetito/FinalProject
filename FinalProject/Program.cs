using FinalProject.Abstract;
using FinalProject.GameManager;
using FinalProject.IranienAgent;

namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        FootSoldier agent = new FootSoldier();
        Agent tst1 = new FootSoldier();
        TheGame.Start(agent);
    }
}