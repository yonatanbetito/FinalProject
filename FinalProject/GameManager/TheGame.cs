using System.Globalization;
using FinalProject.Abstract;
using FinalProject.Interface;
using FinalProject.IranienAgent;
using FinalProject.Sensoris;

namespace FinalProject.GameManager;

internal class TheGame
{
    public static int OperationCounter = 0;
    private string typeSensor;

    public static void Start(Agent agent)
    {
        Console.WriteLine("Welcome to the Agent Sensor Investigation Game");

        int weakness = agent.WeakSensors.Length;

        while (OperationCounter < weakness)
        {
            Console.WriteLine("Eenter a type of sensor");
            string typeSensor = Console.ReadLine().ToLower();
            if (agent.Matching(typeSensor))
            {
                agent.Activate();
                OperationCounter++;
                Console.WriteLine($"sensors {typeSensor} attached {OperationCounter}/{weakness}");
                switch (typeSensor.ToLower())
                {
                    case "thermal":
                        ThermalSensor.Activate(agent);
                        break;
                    case "pulse":
                        PulseSensor.RemoveBrokenPulseSensor(agent);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("sensor not Matching/Added");
            }
        }

        Console.WriteLine("agent exposed");
    }
}