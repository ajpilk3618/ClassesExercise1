using System;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Make = "Mercury",
                Model = "Montego",
                Year = 2007
            };
            car1.Info();
        }
    }
}
