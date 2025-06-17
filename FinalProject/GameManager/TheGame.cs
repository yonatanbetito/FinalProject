using System.Globalization;
using FinalProject.Interface;
using FinalProject.IranienAgent;
using FinalProject.Sensoris;

namespace FinalProject.GameManager;

internal class TheGame
{
    public static int OperationCounter = 0;
    private string typeSensor;

    public static void Start()
    {
        Console.WriteLine("Welcome to the Agent Sensor Investigation Game");
        Console.Write("Enter your agent's name: ");
        string nameAgent = Console.ReadLine();

        FootSoldier agent1 = new FootSoldier(nameAgent);
        int weakness = agent1.WeakSensors.Length;

        while (OperationCounter < agent1.WeakSensors.Length)
        {
            Console.WriteLine("Eenter a type of sensor");
            string typeSensor = Console.ReadLine().ToLower();
            if (agent1.Matching(typeSensor))
            {
              agent1.Activate();
              OperationCounter++;
              Console.WriteLine($"sensors {typeSensor} attached {OperationCounter}/{weakness}");
              
            }
            else
            {
                Console.WriteLine("sensor not added"); 
            }

            
        }
        
        Console.WriteLine($"Agent {nameAgent} has been exposed");
    }
}