using Microsoft.VisualStudio.TestTools.UnitTesting;

using HumanLibrary;

namespace HumanLibraryTests
{
    [TestClass]
    public class HumanTests
    {
        [TestMethod]
        public void TestCalculateBMI()
        {
            // Arrange
            var person = new Human("John", 30, "Male", 1.75, 70, "American", "Christian", "Engineer", "12345");

            // Act
            double bmi = person.CalculateBMI();

            // Assert
            Assert.AreEqual(22.86, Math.Round(bmi, 2), "BMI calculation is incorrect");
        }

        [TestMethod]
        public void TestStudentInitialization()
        {
            // Arrange
            var student = new Student("Alice", 20, "Female", 1.68, 55, "British", "Atheist", "Student", "67890", "ST12345", "CS-101");

            // Assert
            Assert.AreEqual("ST12345", student.StudentID);
            Assert.AreEqual("CS-101", student.Group);
        }

        [TestMethod]
        public void TestWorkerInitialization()
        {
            // Arrange
            var worker = new Worker("Bob", 40, "Male", 1.80, 85, "Canadian", "Jewish", "Manager", "112233", "HR", "Director");

            // Assert
            Assert.AreEqual("HR", worker.Department);
            Assert.AreEqual("Director", worker.Position);
        }
    }
}
