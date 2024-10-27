using System;
using System.ComponentModel;

public class CheckListGoal : Goal
{
    private int _targetCompletionCount;
    private int _currentCompletionCount;

    public CheckListGoal(string name, string description, int points, int target): base (name, description, points)
    {
      
       _targetCompletionCount = target;
       _currentCompletionCount = 0;

    }

    public override void RecordEvent()
    {
        if (_currentCompletionCount < _targetCompletionCount)
        {
            _currentCompletionCount++;
        }
    }

    public override bool IsComplete() => _currentCompletionCount >= _targetCompletionCount;

    public override int GetPoints()
    {
        int totalPoints = _currentCompletionCount *_points;
        if (IsComplete()) totalPoints += 500; 
        return totalPoints;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} (Checklist) [ {(_currentCompletionCount >= _targetCompletionCount ? "X" : " ")} ] Completed {_currentCompletionCount}/{_targetCompletionCount}";
    }
}