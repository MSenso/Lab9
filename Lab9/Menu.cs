using System;

static class Menu
{
    public static void Main_menu()
    {
        Console.WriteLine(@"1. Работа с объектами типа Time
2. Работа с массивами типа Time
3. Выход");
    }
    public static void Time_main_menu()
    {
        Console.WriteLine(@"1. Создать объект типа Time
2. Вывести информацию об объекте
3. Добавить минуты к объекту
4. Выполнить перегрузку
5. Назад");
    }
    public static void Time_initialization_object_menu()
    {
        Console.WriteLine(@"1. Создать объект без ввода значений атрибутов
2. Создать объект, введя значения атрибутов
3. Назад");
    }
    public static void Time_various_methods_of_adding_menu()
    {
        Console.WriteLine(@"1. Добавить минуты статичным методом
2. Добавить минуты нестатичным методом
3. Назад");
    }
    public static void Time_Overloading_menu()
    {
        Console.WriteLine(@"1. Добавить минуту к объекту
2. Вычесть минуту из объекта
3. Вывести количество часов
4. Проверить, равны ли нулю часы и минуты
5. Сложить объект и минуты
6. Вычислить разность объекта и минут
7. Назад");
    }
    public static void Array_main_menu()
    {
        Console.WriteLine(@"1. Создать массив типа Time
2. Вывести информацию о массиве
3. Вычислить среднее арифметическое
4. Назад");
    }
    public static void Array_initialization_object_menu()
    {
        Console.WriteLine(@"1. Создать массив без объектов
2. Создать массив, введя значения атрибутов с клавиатуры
3. Создать массив, заполнив его случайными элементами
4. Назад");
    }
}
