public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
    protected void MarkComplete()
    {
        _isComplete = true;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string ToFileFormat();
    
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
}