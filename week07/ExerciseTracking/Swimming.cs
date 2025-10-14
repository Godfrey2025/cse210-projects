public class Swimming : Activity
{
    private double _laps; // number of laps

    public Swimming(string date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 0.5; // assuming each lap is 0.5 km

    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;

    public override double GetPace() => (double)GetMinutes() / GetDistance();
}