
using System.Xml.Linq;

namespace Homework3
{
    public class Patient
    {
        public Patient(string name, int age, string address, string status)
        {
            Name = name;
            Age = age;
            Address = address;
            Status = status;
          
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }

        public void Showinfo()
        {
            Console.WriteLine (Name, Age, Status);
        }

        public void ill(Patient patient)
        {
           if(patient.Status == "болен")
            {
                Console.WriteLine("Вам нужно к доктору");

            }
               
        }
    }

}
