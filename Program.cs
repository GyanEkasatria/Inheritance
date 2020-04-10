using System;

namespace Tugas4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Grizlly", 25);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Ice Bear", 30, "733874", "Sains");
            teacher.GetNameAndAge();

            Student student = new Student("Panda", 20, "848349", "webarebear@gmail");
            student.GetNameAndAge();
             
            Console.ReadKey();
           
        }
    }
}
 