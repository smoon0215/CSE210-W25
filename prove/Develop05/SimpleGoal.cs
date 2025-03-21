using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal 
{
    public bool Completed {get; set;}

    public SimpleGoal(string description, int points){
        Description = description;
        Points = points;
        Completed = false;
    }

    public override bool IsComplete() => Completed;

    public override void RecordProgress()
    {
        Completed = true; 
    }
}