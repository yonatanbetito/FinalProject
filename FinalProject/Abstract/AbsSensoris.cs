namespace FinalProject.Interface;

public abstract class AbsSensoris
{

    public string NameOfSensor { get; protected set; }
    public bool IsActive { get; protected set; }
    public int NumberOfActivetion { get;protected set; }
    
    protected AbsSensoris(string nameSensor)
    {
        NameOfSensor = nameSensor;
        NumberOfActivetion = 0;
        IsActive = false;
    }
}