using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Alafia";
        job1._jobTitle = "Sales Agent";
        job1._startYear = 2020;
        job1._endYear = 2022;

        // job1.DisplayJob();

        Job job2 = new Job();
        job2._company = "Kings Krown";
        job2._jobTitle = "Customer Service";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // job2.DisplayJob();

        Resume resume = new Resume();
        resume.name = "Melvinensah Bunduka";
        resume.jobs.Add(job1);
        resume.jobs.Add(job2);
        resume.DisplayResume();
    }
}