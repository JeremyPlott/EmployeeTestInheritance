using System;
using EmployeeTestLibrary;

namespace EmployeeTest {
    class Program {

        void Run() {
            var employee1 = new Employee("Batman", "Gardener", 80000);
            var employee2 = new Employee("Robocop", "Bard", 7);
            var employee3 = new Employee("Jeff Goldblum", "Moral Support", 23000);

            var manager1 = new Manager(49, "Big Bird", "Security", 140000);
            var manager2 = new Manager(2, "Madoff", "Financial Advisor", 700);

            Console.WriteLine(employee1.Print());
            Console.WriteLine(employee2.Print());
            Console.WriteLine(employee3.Print());
            Console.WriteLine();
            Console.WriteLine(manager1.Print());
            Console.WriteLine(manager2.Print());

        }
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
        }
    }
}
