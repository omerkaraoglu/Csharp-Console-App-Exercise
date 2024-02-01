using System;

namespace HelloWorld
{
    public class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            this.model = modelName;
            this.color = modelColor;
            this.year = modelYear;
        }

        public void fullThrottle()
        {
            Console.WriteLine("Hit the gas!");
        }
    }
}