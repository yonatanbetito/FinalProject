using FinalProject.Abstract;
using FinalProject.Enum;
using FinalProject.Sensoris;

namespace FinalProject.Interface;

public abstract class Sensors
{

    public Enums.SensorType TypeOfSensor { get; protected set; }
    public bool IsActive { get; set; }
    public int NumberOfActivetion { get; protected set; }

    protected Sensors(Enums.SensorType type)
    {
        TypeOfSensor = type;
        NumberOfActivetion = 0;
        IsActive = false;
    }

    public static Sensors CreateByName(string SensorType)
    {
        switch (SensorType.ToLower())
        {
            case "audio":
                return new AudioSensor(Enums.SensorType.Audio);
            case "thermal":
                return new ThermalSensor(Enums.SensorType.Thermal);

            default:
                return null;
        }
    }

/*public abstract string numberActivation();
*/
}