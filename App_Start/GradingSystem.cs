using System;

public class GradingSystem
{
    public string StudentID { get; set; }
    public int Number { get; set; }

    public GradingSystem(string studentID, int number)
    {
        StudentID = studentID;
        Number = number;
    }

    public string SetGrade()
    {
        if (Number >= 80 && Number <= 100)
            return "A+";

        else if (Number >= 60)
            return "B+";

        else if (Number >= 40)
            return "C+";

        else
            return "F";
    }
}