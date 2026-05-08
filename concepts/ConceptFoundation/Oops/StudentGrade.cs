public class StudentGrade
{
    public string Name { get; set; }

    public Dictionary<string, int> Grades { get; private set; }

    public decimal Average { get; set; }

    public StudentGrade(string name)
    {
        Name = name;
        Grades = new Dictionary<string, int>();
    }

    public string AddGrade(int grade, string subject)
    {

        if (grade is > 0 and <= 100)
        {
            Grades[subject] = grade;
            return "Grades added.";
        }
        return $"Grade must be between 0 and 100 for subject {subject}";
    }

    public double CalculateAverage()
    {
        return Grades.Values.ToArray().Average();
    }
}