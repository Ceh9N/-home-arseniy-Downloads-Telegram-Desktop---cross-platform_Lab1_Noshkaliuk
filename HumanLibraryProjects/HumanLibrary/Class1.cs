namespace HumanLibrary
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; } // у метрах
        public double Weight { get; set; } // у кг
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Profession { get; set; }
        public string PassportData { get; set; }

        public Human(string name, int age, string gender, double height, double weight,
                     string nationality, string religion, string profession, string passportData)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            Nationality = nationality;
            Religion = religion;
            Profession = profession;
            PassportData = passportData;
        }

        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
    }

    public class Student : Human
    {
        public string StudentID { get; set; }
        public string Group { get; set; }

        public Student(string name, int age, string gender, double height, double weight, string nationality,
                       string religion, string profession, string passportData, string studentID, string group)
            : base(name, age, gender, height, weight, nationality, religion, profession, passportData)
        {
            StudentID = studentID;
            Group = group;
        }
    }

    public class Worker : Human
    {
        public string Department { get; set; }
        public string Position { get; set; }

        public Worker(string name, int age, string gender, double height, double weight, string nationality,
                      string religion, string profession, string passportData, string department, string position)
            : base(name, age, gender, height, weight, nationality, religion, profession, passportData)
        {
            Department = department;
            Position = position;
        }
    }
}
