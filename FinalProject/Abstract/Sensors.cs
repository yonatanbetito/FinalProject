namespace FinalProject.Interface;

public abstract class Sensors
{

    public string NameOfSensor { get; protected set; }
    public bool IsActive { get; protected set; }
    public int NumberOfActivetion { get;protected set; }
    
    protected Sensors(string nameSensor)
    {
        NameOfSensor = nameSensor;
        NumberOfActivetion = 0;
        IsActive = false;
    }
}