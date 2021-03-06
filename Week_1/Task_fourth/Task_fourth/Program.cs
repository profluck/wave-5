﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_fourth.Task_1;
using Task_fourth.Task_2;
using Task_fourth.Task_3;
using Task_fourth.Task_4;

// 1.	Реализовать класс для организации работы со списком студентов группы, включив следующие данные: 
//      ФИО, год рождения, домашний адрес, какую школу окончил. Вывести информацию о студентах, окончивших
//      заданную школу, отсортировав их по году рождения.
// 2.	Реализовать класс для организации работы со списком студентов группы, включив следующие данные: 
//      ФИО, номер группы, результаты сдачи трех экзаменов. Вывести информацию о студентах, успешно сдавших сессию, 
//      отсортировав по номеру группы.
// 3.	Реализовать класс для организации работы со списком багажных ведомостей камеры хранения, включив следующие данные: 
//      ФИО пассажира, количество вещей, общий вес вещей. Вывести информацию о тех пассажирах, средний вес багажа которых 
//      превышает заданный, отсортировав их по количеству вещей, сданных в камеру хранения.
// 4.	Реализовать класс для организации работы со списком автомобильных ведомостей, включив следующие данные: марка автомобиля, 
//      номер автомобиля, фамилия его владельца,  год приобретения, пробег. Вывести информацию об автомобилях, выпущенных ранее 
//      определенного года, отсортировав их по пробегу.

namespace Task_fourth
{
    class Program
    {
        static void Main(string[] args)
        {

            // !!! For the start to use certain task, you heve to uncomment some Start() method.

            /** Task 4.1 **/
            InitFirstStudents fStudents = new InitFirstStudents();
            // fStudents.Start();

            /** Task 4.2 **/
            InitSecondStudents sStudents = new InitSecondStudents();
            // sStudents.Start();

            /** Task 4.3 **/
            InitLuggageDepartment luggages = new InitLuggageDepartment();
            // luggages.Start();

            /** Task 4.3 **/
            InitCarsDepartament cars = new InitCarsDepartament();
            // cars.Start(); 

            Console.WriteLine("\n Press enter to exit.");
            Console.ReadLine();
        }
    }
}
