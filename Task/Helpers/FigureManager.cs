using System;
using Task.Figures;

namespace Task.Helpers
{
    public class FigureManager
    {
        private Figure _figure;
        public void Start()
        {
            Greeting();
            while(true)
            {
                SetFigure();
                WorkWithFigure();
                if(AskStopProgram())break;
            }
            
        }
        private void Greeting() => Console.WriteLine(GetGreetingWord());
        public string GetGreetingWord() => "Добро пожаловать!";
    
        private void SetFigure()
        {
            _figure = GenerateFigure();
            
        }
        
        private void WorkWithFigure()
        {
            _figure.SetValues();
            _figure.ShowArea();
        }
        public bool AskStopProgram()
        {
            Console.WriteLine("Хотите продолжить(д/н):");
            string answer = Console.ReadLine().ToLower();
            return answer == "н";
        }
        
        public Figure GenerateFigure()
        {
            Console.WriteLine("Введите с какой фигурой хотите работать(1 или 2):");
            Console.WriteLine("1)Треугольник");
            Console.WriteLine("2)Окружность");
            int result = Convert.ToInt32(Console.ReadLine());
            switch(result)
            {
                case 1: return new Triangle();
                case 2: return new Circle();
                default: 
                {
                    Console.WriteLine("Вы неправильно ввели номер фигуры!");
                    return GenerateFigure();
                    
                }
            }
        }
    }
}