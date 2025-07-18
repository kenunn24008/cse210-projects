public class Running : Activity
{
    private double _distance;
    public Running(string date, double duration, double distance)
    : base(date, duration)
    {
        _distance = distance;
    }

    public override string GetSummary(Activity i)
    {
        double distance = i.CalcDistance();
        double speed = i.CalcSpeed();
        double pace = i.CalcPace();
        return $"Running:\nDistance: {distance}mi, speed: {speed}mph, pace: {pace} minutes per mile\n";
    }

    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        double speed = _distance / _duration;
        return speed;
    }

    public override double CalcPace()
    {
        double pace = _duration / _distance;
        return pace * 60.0;
    }
}