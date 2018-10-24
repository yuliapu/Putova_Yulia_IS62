using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lab1
{
    /*Реализовать задачу создания файлов с разным расширением:.txt,.rtf,.doc,.jpeg. 
 * Количество создаваемых файлов и их имена определяет пользователь.
     
     Используемый паттерн - Строитель. Строитель поможет обеспечить создание различных вариаций обьекта - файла -
     * из его частей: имени, расширения и расположения. Так, используя одинаковые методы, Пользователь может создавать
     * разное количество файлов с разными именами, расширением и расположением.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab1 by Putova Yulia.\nGroup IS62\nVariant 4: File creating. Builder pattern");
            Director director = new Director();
            director.hello();
           
            Console.Read();
        }
      
      
    }
}
