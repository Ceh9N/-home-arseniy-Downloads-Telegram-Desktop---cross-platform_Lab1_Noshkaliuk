using HumanLibrary;

class Program
{
    static void Main()
    {
        Human person = new Human("John Doe", 30, "Male", 175, 70, "American", "None", "Engineer", "A1234567");
        Console.WriteLine(person);
        Console.WriteLine($"BMI: {person.CalculateBMI():F2}\n");

        Student student = new Student("Alice Smith", 20, "Female", 165, 55, "Canadian", "Christian", "Student", "B7654321", "S12345", "CS101");
        Console.WriteLine(student);
        Console.WriteLine($"BMI: {student.CalculateBMI():F2}\n");

        Worker worker = new Worker("Bob Johnson", 40, "Male", 180, 85, "British", "Atheist", "Manager", "C9876543", "IT Department", "Project Manager");
        Console.WriteLine(worker);
        Console.WriteLine($"BMI: {worker.CalculateBMI():F2}\n");
    }
}
