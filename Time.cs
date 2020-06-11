using System;
public class Time
{
    int hours; // Часы
    int minutes; // Минуты
    static int count_of_objects = 0; // Количество созданных объектов
    #region Свойства
    public int Hours { get; set { if (value >= 0 && value <= 23) hours = value; } }
    public int Minutes { get; set { if (value >= 0 && value <= 59) hours = value; } }
    #endregion
    #region Конструкторы
    public Time() // Конструктор без параметров
    {
        hours = 0;
        minutes = 0;
        count_of_objects++;
    }
    public Time(int hours, int minutes) // Конструктор с параметрами
    {
        if (hours >= 0 && hours <= 23) this.hours = hours;
        else this.hours = 0;
        if (minutes >= 0 && minutes <= 59) this.minutes = minutes;
        else this.minutes = 0;
        count_of_objects++;
    }
    #endregion
    public void Show() // Вывод времени
    {
        if (hours < 10)
        {
            if (minutes < 10) Console.WriteLine("Время: 0{hours}.0{minutes}");
            else Console.WriteLine("Время: 0{hours}.{minutes}");
        }
        else
        {
            if (minutes < 10) Console.WriteLine("Время: {hours}.0{minutes}");
            else Console.WriteLine("Время: {hours}.{minutes}");
        }
    }
    #region Добавление минут
    public static Time Plus(Time time, int minutes) // Добавление минут к объекту через статичный метод
    {
        Time result = new Time(); // Результат сложения с минутами
        if (minutes < 0) throw new Exception();
        try
        {
            int hours_to_add = 0; // Количество добавляемых часов после сложения с минутами
            int minutes_to_add = minutes % 60;  // Количество добавляемых минут (остаток от деления на 60,
                                                // т.к. в случае, когда общее количество минут больше 59, целая часть от деления на 60 перенесется в добавляемые часы,
                                                // а остаток – в добавляемые минуты)
            if (time.minutes + minutes_to_add > 59)
            {
                hours_to_add = (time.minutes + minutes_to_add) / 60;
            }
            if (time.hours + hours_to_add > 23) // Общее количество часов не может превышать 23
            {
                throw new Exception("Общее количество часов не может быть больше 23!");
                result = time;
            }
            else
            {
                result.hours = time.hours + hours_to_add; // Сложение исходного количества часов с добавляемым
                result.minutes = time.minutes + minutes_to_add; // Сложение исходного количества минут с добавляемым
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Некорректный ввод количества добавляемых минут!");
            result = time;
        }
        finally
        {
            return result;
        }
    }
    public Time Plus(int minutes) // Добавление минут к объекту через нестатичный метод
    {
        Time result = new Time(); // Результат сложения с минутами
        if (minutes < 0) throw new Exception();
        try
        {
            int hours_to_add = 0; // Количество добавляемых часов после сложения с минутами
            int minutes_to_add = minutes % 60;  // Количество добавляемых минут (остаток от деления на 60,
                                                // т.к. в случае, когда общее количество минут больше 59, целая часть от деления на 60 перенесется в добавляемые часы,
                                                // а остаток – в добавляемые минуты)
            if (this.minutes + minutes_to_add > 59)
            {
                hours_to_add = (this.minutes + minutes_to_add) / 60;
            }
            if (time.hours + hours_to_add > 23) // Общее количество часов не может превышать 23
            {
                throw new Exception("Общее количество часов не может быть больше 23!");
                result.hours = hours;
                result.minutes = this.minutes;
            }
            else
            {
                result.hours = hours + hours_to_add; // Сложение исходного количества часов с добавляемым
                result.minutes = this.minutes + minutes_to_add; // Сложение исходного количества минут с добавляемым
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Некорректный ввод количества добавляемых минут!");
            result.hours = hours;
            result.minutes = this.minutes;
        }
        finally
        {
            return result;
        }
    }
    #endregion
}
