using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software engineer";
        job1._company = "microsoft";
        job1._startYear = 2015;
        job1._endYear = 2017;
        //job1.DisplayJobDetails();


        Job job2 = new Job();
        job2._jobTitle = "manager";
        job2._company = "apple";
        job2._startYear = 2020;
        job2._endYear = 2024;
        //job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume.name = "Allison Rose";

        
        Resume.myResume.Add(job1);
        Resume.myResume.Add(job2);


        myResume.DisplayDetails();

        //Console.WriteLine($"{Resume.myResume[0]._jobTitle}");
        //Console.WriteLine($"{Resume.myResume[1]._jobTitle}");


    }
}