class RemoteControlCar
{
    public int battery;
    public int distance;
    public int _speed;
    public int _batteryDrain;

    public RemoteControlCar(int Speed, int BatteryDrain)
    {
        _speed = Speed;
        _batteryDrain = BatteryDrain;
        battery = 100;
        distance = 0;
    }

    public bool BatteryDrained() => battery < _batteryDrain;

    public int DistanceDriven() => distance;
    
    public void Drive()
    {
        if(battery >= _batteryDrain)
        {
            distance += _speed;
            battery -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);

}

class RaceTrack
{
    public int _distance;

    public RaceTrack(int Distance)
    {
        _distance = Distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int totalDrivesNeeded = (int)Math.Ceiling((double)_distance / car._speed);
    
    int totalBatteryNeeded = totalDrivesNeeded * car._batteryDrain;

    return car.battery >= totalBatteryNeeded;
    }
}
