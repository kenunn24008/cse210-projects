public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _currentAmount;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
    : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _currentAmount = 0;
    }
    
    public void SetCurrentAmount(int amount)
    {
        _currentAmount = amount;
        if (_currentAmount >= _target)
        {
            MarkComplete();
        }
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _currentAmount++;
            if (_currentAmount >= _target)
            {
                MarkComplete();
                return GetPoints() + _bonus;
            }
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Currently completed: {_currentAmount}/{_target}";
    }

    public override string ToFileFormat()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_currentAmount}";
    }
}