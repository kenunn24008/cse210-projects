public class Swimming : Activity
{
    private double _numLaps;

    public Swimming(string date, double duration, double numLaps)
    : base(date, duration)
    {
        _numLaps = numLaps;
    }

    public override string GetSummary(Activity i)
    {
        double distance = i.CalcDistance();
        double speed = i.CalcSpeed();
        double pace = i.CalcPace();
        return $"Swimming:\nDistance: {distance}mi, speed: {speed}mph, pace: {pace} minutes per mile\n";
    }

    public override double CalcDistance()
    {
        double distance = _numLaps * (50.0 / 1000.0 * 0.62);
        return distance;
    }

    public override double CalcSpeed()
    {
        double distance = _numLaps * (50.0 / 1000.0 * 0.62);
        return distance / _duration;
    }

    public override double CalcPace()
    {
        double distance = _numLaps * (50.0 / 1000.0 * 0.62);
        return (_duration / distance) * 60.0;
    }
}