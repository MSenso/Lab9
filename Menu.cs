using System;

public static class Menu
{
    void Main_menu()
    {
        Console.WriteLine(@"1. Работа с объектами класса Time
2. Работа с массивами типа Time
3. Выход");
    }
    void Time_main_menu()
    {
        Console.WriteLine(@"1. Создать объект класса Time
2. Вывести информацию об объекте
3. Назад");
    }
    void Array_main_menu()
    {
        Console.WriteLine(@"1. Создать массив типа Time
2. Вывести информацию о массиве
3. Назад");
    }
}
