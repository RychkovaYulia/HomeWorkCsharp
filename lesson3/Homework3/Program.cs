using Homework3;

public class Program
{
    public static void Main()
    {
        var doctor1 = new Doctor ( "Иванов И.И.", 40, "Терапевт", 6 );
        var doctor2 = new Doctor("Сидоров М.В.", 38, "Окулист", 10);
        var doctor3 = new Doctor("Петров В.В.", 32, "Кардиолог", 4);
        var patient1 = new Patient("Крапская Ф.А", 24, "Коли Мяготина, 35", "здоров");
        var patient2 = new Patient("Кубик П.В", 30, "Гоголя, 52","болен");

    }
}
