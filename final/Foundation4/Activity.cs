public abstract class Activity
{
    private string _date;

    protected double _duration;

    public Activity(string date, double duration)
    {
        _duration = duration;
        _date = date;
    }

    public abstract string GetSummary(Activity i);

    public abstract double CalcDistance();

    public abstract double CalcSpeed();

    public abstract double CalcPace();
}