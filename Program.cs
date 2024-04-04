// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Введите номер задачи (от 1 до 5)");
int k = Int32.Parse(Console.ReadLine());
switch (k)
{
    case 1: Forth1(); break;
    case 2: Forth2(); break;
    case 3: Forth3(); break;
    case 4: Forth4(); break;
    case 5: Forth5(); break;

}

static void Forth1()
{
    //    1.Заменить в строке все вхождения 'test' на 'testing'.Удалить из текста все
    //символы, являющиеся цифрами.
    //Console.WriteLine("введите строку");
    string message = "test bbbbbtest  testtest test";// Console.ReadLine();
    var replaceMessage = message.Replace("test", "testing");
    Console.WriteLine(message);
    Console.WriteLine(replaceMessage);

}
static void Forth2()
{
    //2.Используя метод вывода значения в консоль, выполните конкатенацию слов и
    //выведите на экран следующую фразу:
    //    Welcome to the TMS lesons.
    //Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome".
    //Не забывайте о пробелах после каждого слова
    string[] words = { "\"Welcome\""," ", "\"to\"", " ", "\"the\"", " ", "\"TMS\"", " ", "\"lesons\"" };
    var fraze = string.Concat(words);
    Console.WriteLine(fraze);
}

static void Forth3()
{
    //3.Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
    //Необходимо найти в данной строке "abc", записав всё что до этих символов в первую
    //переменную, а также всё, что после них во вторую.
    //Результат вывести в консоль.
    string message = "teamwithsomeofexcersicesabcwanttomakeitbetter";
    var first = message.Substring(0,message.IndexOf("abc"));
    var second = message.Substring(message.IndexOf("abc")+3);
    
    Console.WriteLine(message);
    Console.WriteLine(first);
    Console.WriteLine(second);
}
static void Forth4()
{
    //4.Дана строка: Плохой день.
    //Необходимо с помощью метода substring удалить слово "плохой".После чего необходимо
    //используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
    //Заменить последний "!" на "?"
    string message = "Плохой день.";
    var newmessage = message.Substring(message.IndexOf("й")+1);
    Console.WriteLine(message);
    Console.WriteLine("newmessage");
    newmessage = newmessage.Insert(0, "Хороший");
    newmessage = newmessage.Insert(newmessage.LastIndexOf("ь")+1, "!!!!!!!!!");
    Console.WriteLine(newmessage);

}
static void Forth5()
{
    //5.Написать программу со следующим функционалом:
    //На вход передать строку (будем считать, что это номер документа).
    //Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.
    //Вывести на экран в одну строку два первых блока по 4 цифры.
    //Вывести на экран номер документа, но блоки из трех букв заменить на *** (каждая буква заменятся на *).
    //Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
    //Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью класса StringBuilder).
    //Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается одинаковой последовательностью).
    //Проверить начинается ли номер документа с последовательности 555.
    //Проверить заканчивается ли номер документа на последовательность 1a2b.
    //Все эти методы реализовать в отдельном классе в статических методах, которые на вход (входным параметром) будут принимать вводимую на вход программы строку.
    
    string docnum = "1234-aaa-4321-bbb-1a2b";
    Console.WriteLine(docnum);


}
