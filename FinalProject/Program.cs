using FinalProject.Abstract;
using FinalProject.GameManager;
using FinalProject.IranienAgent;

namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        Agent tst1 = new FootSoldier("ani");
        TheGame.Start();
    }
}