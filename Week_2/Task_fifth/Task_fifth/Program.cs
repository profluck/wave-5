using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_fifth.Pers;

//  Создать иерархию классов Person-Student-Teacher. В каждом классе должны быть свойства, а также виртуальная функция Print 
//  и переопределенная функция ToString(). Основная программа создает массив объектов Person или их наследников, после чего 
//  выдает его на экран.

//  У каждого Teacher должен быть список Students, которыми он руководит, у каждого Student - Teacher, который им руководит.

//  Для классов Person-Student-Teacher реализовать и оттестировать ToString(), Equals(), GetHashCode().

//  Для классов Person-Student-Teacher реализовать статические методы RandomPerson, RandomStudent, RandomTeacher, 
//  которые возвращают случайного из некоторого статического массива.

//  С помощью is, as, GetType определить, сколько в массиве персон, студентов и преподавателей и перевести всех студентов 
//  на следующий курс.

//  Для классов Person-Student-Teacher реализовать глубокое клонирование, определив виртуальный метод Clone(). 
//  Клон должен возвращать точную копию по значению и типу. Проиллюстрировать Clone на примере контейнера персон - должны 
//  создаваться клоны объекты ровно тех типов, которые содержатся в исходном контейнере.
//  Используя метод GetType() класса Student и метод BaseType() класса Type, вывести всех предков класса Student(написать 
//  общий метод)


namespace Task_fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialization programm
            new Initer().Start();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press button Enter to exit.");
            Console.ReadLine();
        }
    }
}
