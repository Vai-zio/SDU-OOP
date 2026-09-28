int[] grades =[4, 7, 02, 00, 10, 4, 12];

int GetGrade(int courseid)
{
    return grades[courseid] >= 2 
        ? grades[courseid] 
        : throw new ArgumentException("Not passing grade");
}

void TryPrintGrade(int courseid)
{
    try 
    {
        Console.WriteLine("The grade is: " + GetGrade(courseid));
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Course " + courseid + ": Not passing grade");
    }
}

TryPrintGrade(1);
TryPrintGrade(3);
TryPrintGrade(6);
