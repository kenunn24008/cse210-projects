using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args) {

        Job job1 = new();
        job1._company = "Janitor";
        job1._jobTitle = "BYU-Idaho";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new();
        job2._company = "Amazon";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume resume = new();
        resume._name = "Sam White";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();

    }

}