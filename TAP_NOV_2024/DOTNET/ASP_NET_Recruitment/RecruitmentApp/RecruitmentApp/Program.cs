using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApp
{
    // HOLLYWOOD PRINCIPLE

    // Do not call us, we will call you. 
    // HR Department will have JobPortal

    public class Resume
    {
        public string Name {get; set;}

        public string Email {get; set;}
        
        public string Content {get; set;}

        public override string ToString()
        {
            return "Resume [email= " + Email + ", name= " + Name + ", content= " + Content + "]";
        }

    }


    // Singleton class

    public class JobPortal
    {
        private static JobPortal portal = new JobPortal();

        private List<Resume> resumeList = new List<Resume>();


        private JobPortal()
        {

        }

        public static JobPortal GetJob()
        {
            return portal;
        }

        public void uploadContent(string mail, string name, string content)
        {
            Resume resume = new Resume();
            resume.Name = name;
            resume.Email = mail;
            resume.Content = content;
            resumeList.Add(resume);
        }

        public void triggerCampusing()
        {
            foreach(Resume resume in resumeList)
            {
                Console.WriteLine("Sending mail to " + resume.Name + " at " + resume.Email);
            }

        }

    }





    class Program
    {
        static void Main(string[] args)
        {

            // Testing
            // Don't call us, we will call you
            // 
            JobPortal.get().uploadContent("Kautubhpatil@gmail.com", "Kaustubh Patil", "A C# - .NET Developer")
            JobPortal.get().uploadContent("Pallavipatil@gmail.com", "Pallavi Patil", "A Python Developer")
            JobPortal.get().uploadContent("SaiRajPatil@gmail.com", "SaiRaj Patil", "A Statistics Master")
            JobPortal.get().uploadContent("RaviTambade@gmail.com", "Ravi Tambade", "Transflower Mentor")
            JobPortal.get().uploadContent("Ajinkyatambade@gmail.com", "Ajinkya Tambade", "A .NET Developer")
            JobPortal.get().uploadContent("Pranav@gmail.com", "Pranav", "A Java Developer")
            JobPortal.get().uploadContent("Sharayu@gmail.com", "Sharayu", "A Python - Django Developer")
            JobPortal.get().triggerCampusing();
        }
    }
}
