
namespace Homework3
{
    public class Doctor
    {
        public Doctor(string name, int age, string special, int exp)
        {
            Name = name;
            Age = age;
            Special = special;
            Exp = exp;
        }
        public string Name { get; set;}
        public int Age { get; set; }
        public string Special { get; set; }
        public int Exp { get; set; }

        public void Showinfo()
        {
            Console.WriteLine(Name, Special);
        }

        public void cure(Patient patient)
        {
            if (patient.Status == "болен")
            {
                patient.Status = "здоров";
            } 
           
        }
    }
}
