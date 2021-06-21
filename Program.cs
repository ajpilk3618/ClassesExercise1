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

            Car car2 = new Car()
            {
                Make = "Nissan",
                Model = "Altima",
                Year = 2010
            };
            car1.Info();
            car2.Info();
        }
    }
}
