namespace Disaheim;

public class Course : IValuable
{
    public string Name;
    public int DurationInMinutes;

    public static double CourseHourValue = 875.0;

    public Course(string name)
    {
        Name = name;
    }

    public Course(string name, int durationInMinutes)
    {
        Name = name;
        DurationInMinutes = durationInMinutes;
    }

    public double GetValue()
    {
        // If duration is 0, return 0
        if (DurationInMinutes == 0)
            return 0;

        // Calculate complete hours and any remaining minutes
        int completeHours = DurationInMinutes / 60;
        int remainingMinutes = DurationInMinutes % 60;

        // If there are any remaining minutes, add an extra hour
        if (remainingMinutes > 0)
            completeHours++;

        return CourseHourValue * completeHours;
    }

    public override string ToString()
    {
        return ($"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}");
    }
}