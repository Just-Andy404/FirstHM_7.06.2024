/*
В одном из предыдущих практических заданий вы создавали класс "Журнал". 
Добавьте к уже созданному классу информацию о количестве работников. 
Выполните нагрузки + (для увеличения количества работников на указанное количество), 
- (для уменьшения количества работников на указанное количество), 
== (проверка на равенство количества работников), == (проверка на равенство количества работников),
< и > (проверка на меньшее или большее количество работников), != и Equals. Используйте механизм 
свойств полей класса.
 */

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine mag1 = new Magazine("About money", 56);
            Magazine mag2 = new Magazine("News", 56);

            Console.WriteLine(mag1);
            Console.WriteLine(mag2);
            Console.WriteLine();

            Console.WriteLine("==");
            Console.WriteLine(mag1 == mag2);
            Console.WriteLine();

            Console.WriteLine("+ and -");
            mag1 = mag1 + 10;
            mag2 = mag2 - 2;
            Console.WriteLine(mag1);
            Console.WriteLine(mag2);
            Console.WriteLine();

            Console.WriteLine("!=");
            Console.WriteLine(mag1 != mag2);
            Console.WriteLine();

            Console.WriteLine("> and <");
            Console.WriteLine(mag1 > mag2);
            Console.WriteLine(mag1 < mag2);
            Console.WriteLine();

            Console.WriteLine("Equals");
            Console.WriteLine(mag1.Equals(mag2));

        }
    }
}
