class RemoteControlCar
{
    public int TotalDistance;
    public int Battery;

    public RemoteControlCar()
    {
        TotalDistance = 0;
        Battery = 100;
    }
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay() => $"Driven {TotalDistance} meters";
    

    public string BatteryDisplay()
    {
        if(Battery == 0) return $"Battery empty";
        return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if(Battery > 0)
        {
            TotalDistance += 20;
            Battery--;
        }
    }
}
