using System;

namespace Task.Figures
{
    public class Circle : Figure
    {
        private int _radius;
        
        public void SetValues()
        {
            Console.WriteLine("Введите радиус окружности: ");
            _radius = Convert.ToInt32(Console.ReadLine());
        }
        public void SetValues(int r)
        {
            _radius = r;
        }
        public double GetArea()
        {
            return Math.Round(_radius*Math.PI,1);
        }
        public void ShowArea()
        {
            Console.WriteLine($"Площадь окружности равна - {GetArea()}");
        }
    }
}