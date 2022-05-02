using System;


namespace HomeWork2_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // обьявляем переменные и присваиваем им значения
            string fullName = "Рогозин Илон Маскович";
            byte age = 63;
            string emailString = "goodsound@rogos.biz";
            double programsScores = 76;
            double matchsScores = 34;
            double physicsScores = 69;

            //считаем среднее арифметическое по трем предметам
            double averageScore = (programsScores + matchsScores + physicsScores)/3;

            //форматируем вывод среднего значения
            string averageScoreString = $"{averageScore:##.##}";

            //форматированый вывод в консоль
            string pattern = "Ф.И.О. : {0} \nВозраст : {1} \nEmail : {2} \nБаллы по программированию : {3} \nБаллы по математике : {4} \nБаллы по физике : {5} \nСредний балл : {6}";

            Console.WriteLine(pattern,
                   fullName,
                   age,
                   emailString,
                   programsScores,
                   matchsScores,
                   physicsScores,
                   averageScoreString);

            //ожидание нажатия любой клавиши
            Console.ReadKey();
        }
    }
}