public class Resume
{
    public string name = "";

    public static List<Job> myResume = new List<Job>();

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in myResume)
        {
            job.DisplayJobDetails();
        }
    }
    
}