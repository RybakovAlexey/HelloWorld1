using System;


namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        { 
            //начало первой части задания
        Console.WriteLine("Проверка четности числа");
        Console.WriteLine("Введите целое число :");
            //полученую строку парсим в число и присваиваем переменной
        int inputData = int.Parse(Console.ReadLine());
            //проверка четности
        if(inputData%2 == 0)
            {
                Console.WriteLine("Введенное число является четным.");
            }
            else
            {
                Console.WriteLine("Введенное число является нечетным.");
            }
            
        Console.WriteLine("******************************************************");
        Console.WriteLine("Нажмите любую клавишу для перехода ко второму заданию.");
            //ожидание нажатия любой клавиши
        Console.ReadKey();
            //начало второй части задания
        Console.WriteLine("Blackjack!");
        Console.WriteLine("Введите число, соответствующее кол-ву карт на руках:");
            //полученую строку парсим в число и присваиваем переменной
            byte CardsOnHand = byte.Parse(Console.ReadLine());
            int points = 0;
            for(int i = 0; i < CardsOnHand; i++)
            {
                Console.WriteLine($"Введите значение {i+1} карты :");
                string cardString = Console.ReadLine();
                switch (cardString)
                {
                    case "J"://во всех четырех случаях делаем одно и тоже - прибавляем 10
                    case "Q":
                    case "K":
                    case "T":
                        points += 10;
                        break;
                    case "2":// если число - добавляем его
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        points += int.Parse(cardString);
                        break;
                    default://если введенные данные не подходят для решения задачи
                        Console.WriteLine("Нет такой карты! Используйте числа от 2 до 10 и буквы J Q K T для ввода!");
                        i--;// уменьшаем переменную цикла чтобы заново ввести именно эту карту
                        break;

                }

            }
            Console.WriteLine($"Сумма карт на руках : {points}");
            Console.WriteLine("******************************************************");
            Console.WriteLine("Нажмите любую клавишу для перехода к третьему заданию.");
            Console.ReadKey();
                //начало третьей части задания
            Console.WriteLine("Проверка числа - простое или нет");
            Console.WriteLine("Введите целое число :");
            int secondInputData = int.Parse(Console.ReadLine());
            int j = 2;//начинаем с 2 , тк на 1 делятся все числа..
            bool primeNumberFlag = true; //флаг простого числа
            while(secondInputData > j) //
            {
                if(secondInputData % j == 0)
                {
                    primeNumberFlag = false; //если поделилось на число больше 1 и меньше самого числа, переводим флаг в фолс
                    break;
                }
                j++;
            }
            if (primeNumberFlag) Console.WriteLine($"Число {secondInputData} является простым.");
            else Console.WriteLine($"Число {secondInputData} не является простым.");
            Console.ReadKey();
        }
    }
}