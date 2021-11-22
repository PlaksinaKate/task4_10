
using task4_10;

namespace task4_10
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            ChildProgrammer programmer1 = new ChildProgrammer("Иванов", 5, 5, 2);

            Console.WriteLine("Фамилия программиста: " + programmer1.surname);
            Console.WriteLine("Число программ, написанных программистом: " + programmer1.numberOfPrograms);
            Console.WriteLine("Число языков: " + programmer1.languages);
            Console.WriteLine("Число правильно работающих программ: " + programmer1.rightProgram);
            Console.WriteLine("Число программ умноженное на число языков и на число правильных программ и разделенное на число всех программ: " + programmer1.CountProgram());

        }
    }

}

