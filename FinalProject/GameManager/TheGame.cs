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
    {    Console.WriteLine("Welcome to the Agent Sensor Investigation Game");

        int weakness = agent.WeakSensors.Length;

        while (OperationCounter < weakness)
        {
            Console.WriteLine("Enter a type of sensor");
            string typeSensor = Console.ReadLine().ToLower();

            bool matched = agent.Matching(typeSensor);

            if (matched)
            {
                agent.Activate();
                OperationCounter++;
                Console.WriteLine($"sensors {typeSensor} attached {OperationCounter}/{weakness}");
            }
            else
            {
                if (typeSensor == "pulse")
                {
                    foreach (var sensor in agent.AttachSensors.ToList())
                    {
                        if (sensor.TypeOfSensor.ToString().ToLower() == "pulse" &&
                            sensor is PulseSensor pulseSensor)
                        {
                            pulseSensor.BreaksCount++;

                            if (pulseSensor.isBreaks())
                            {
                                agent.AttachSensors.Remove(pulseSensor);
                                OperationCounter--;
                                Console.WriteLine("PulseSensor broke and was removed.");
                            }
                        }
                    }
                }

                Console.WriteLine("sensor not Matching/Added");
            }
        }

        Console.WriteLine("agent exposed");
    }
    }