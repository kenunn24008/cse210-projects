public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
    : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            MarkComplete(); 
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()})";
    }

    public override string ToFileFormat()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
}