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


    // Business Entity
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
    // Business Process Management
    public class JobPortal
    {
        private static JobPortal portal = new JobPortal();

        public List<Resume> resumeList = new List<Resume>();


        private JobPortal()
        {
            Console.WriteLine("new Job Portal instance created....");
        }

        public static JobPortal Get()
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
            // get fn is a static function and 
            // member fn is called using a object
            // Access JobPortal
            // Upload resumes

            // Notify indirectly to all candidates
            JobPortal portal = JobPortal.Get();

            portal.uploadContent("Kaustubhpatil@gmail.com", "Kaustubh Patil", "A C# - .NET Developer");
            portal.uploadContent("Pallavipatil@gmail.com", "Pallavi Patil", "A Python Developer");
            portal.uploadContent("SaiRajPatil@gmail.com", "SaiRaj Patil", "A Statistics Master");
            portal.uploadContent("RaviTambade@gmail.com", "Ravi Tambade", "Transflower Mentor");
            portal.uploadContent("Ajinkyatambade@gmail.com", "Ajinkya Tambade", "A .NET Developer");
            portal.uploadContent("Pranav@gmail.com", "Pranav", "A Java Developer");
            portal.uploadContent("Sharayu@gmail.com", "Sharayu", "A Python - Django Developer");
            // Initiating Business process by one broadcast behaviour
            portal.triggerCampusing();
        }
    }
}
