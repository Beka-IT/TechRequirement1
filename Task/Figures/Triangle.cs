using System;
using System.Collections.Generic;

namespace Task.Figures
{
    public class Triangle : Figure
    {
        private List<int> _sides = new List<int>();
        public void SetValues()
        {
            for(int i = 0;i < 3; i++)
            {
                Console.WriteLine($"Введите длину {i+1}-й стороны треугольника:");
                int side = Convert.ToInt32(Console.ReadLine());
                _sides.Add(side);
            }
            _sides.Sort();
            CheckIsRight();
        }
        public void SetValues(int a,int b, int c)
        {
            _sides.Clear();
            _sides.Add(a);
            _sides.Add(b);
            _sides.Add(c);
            _sides.Sort();

        }
        public double GetArea()
        {
            double p = (_sides[0]+_sides[1]+_sides[2])/2.0;
            double area = Math.Sqrt(p*(p-_sides[0])*(p-_sides[1])*(p-_sides[2]));
            return Math.Round(area,1);
        }
        public void ShowArea()
        {
      
      
            Console.WriteLine($"Площадь треугольника - {GetArea()}");
        }
        public void showSides()
        {
            Console.WriteLine($"{_sides[0]} {_sides[1]} {_sides[2]}");
        }
        public void CheckIsRight()
        {
            int squareOfLegs = (_sides[0]*_sides[0]) + (_sides[1]*_sides[1]);
            int squareOfHypotenuse = _sides[2]*_sides[2];
            string conclusion;
            if(squareOfHypotenuse == squareOfLegs)
            {
                conclusion = "Треугльник является прямоугольной";
            }else
            {
                conclusion = "Треугльник не является прямоугольной";
            }
            Console.WriteLine(conclusion);
        }
    }
}
