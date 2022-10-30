
// 5) Create two interface and illustracte how to use multiple inheritance in C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdvancedEmployees employees = new AdvancedEmployees();
            employees.Head();
            employees.TraineeEngineer();

            Console.ReadKey();
        }
    }

    interface IAhmedabadOffice
    {
        void Head(); // same method in 2 different interface.

        void TraineeEngineer();
        
    }

    interface IBangloreOffice
    {
        void Head();
    }

    class AdvancedEmployees : IAhmedabadOffice, IBangloreOffice
    {
        public void Head()
        {
            Console.WriteLine("\nKotresh Mutt is Head of Engineering @Banglore Office.");
            Console.WriteLine("\nAkshay Singhvi is Head of Engineering @Ahmedabad Office.\n");
        }

        public void TraineeEngineer()
        {
            Console.WriteLine("\nAryan Gupta is Trainee Engineering @Ahmedabad Office.");
        }
    }
}
