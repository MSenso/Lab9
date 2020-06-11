using Lab9;
using System;

public class Time: IComparable<Time>
{
    int hours; // Часы
    int minutes; // Минуты
    #region Свойства
    public int Hours
    {
        get => hours;
        set
        {
            if (value >= 0 && value <= 23) hours = value;
            else
            {
                Console.WriteLine("Некорректное введенное значение! Значение часов приравнено к нулю");
                hours = 0;
            }
        }
    }
    public int Minutes
    {
        get => minutes;
        set
        {
            if (value >= 0 && value <= 59) minutes = value;
            else
            {
                Console.WriteLine("Некорректное введенное значение! Значение минут приравнено к нулю");
                minutes = 0;
            }
        }
    }
    public static int Count_of_objects { get; set; } = 0;
    #endregion
    #region Конструкторы
    public Time() // Конструктор без параметров
    {
        hours = 0;
        minutes = 0;
        Count_of_objects++;
    }
    public Time(int hours, int minutes) // Конструктор с параметрами
    {
        if (hours >= 0 && hours <= 23) this.hours = hours;
        else this.hours = 0;
        if (minutes >= 0 && minutes <= 59) this.minutes = minutes;
        else this.minutes = 0;
        Count_of_objects++;
    }
    #endregion
    public void Show(bool is_for_array = false) // Вывод времени
    {
        try
        {
            if (!is_for_array)
            {
                if (hours < 10)
                {
                    if (minutes < 10) Console.WriteLine($"Время: 0{hours}:0{minutes} количество объектов: {Count_of_objects}");
                    else Console.WriteLine($"Время: 0{hours}:{minutes}, количество объектов: {Count_of_objects}");
                }
                else
                {
                    if (minutes < 10) Console.WriteLine($"Время: {hours}:0{minutes}, количество объектов: {Count_of_objects}");
                    else Console.WriteLine($"Время: {hours}:{minutes}, количество объектов: {Count_of_objects}");
                }
            }
            else
            {
                if (hours < 10)
                {
                    if (minutes < 10) Console.WriteLine($"Время: 0{hours}:0{minutes}");
                    else Console.WriteLine($"Время: 0{hours}:{minutes}");
                }
                else
                {
                    if (minutes < 10) Console.WriteLine($"Время: {hours}:0{minutes}");
                    else Console.WriteLine($"Время: {hours}:{minutes}");
                }
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Объект не создан!");
        }
    }
    public int Count_of_minutes()
    {
        return 60 * hours + minutes;
    }
    #region Добавление минут
    public static Time Plus(Time time, int minutes) // Добавление минут к объекту через статичный метод
    {
        Time result = new Time(); // Результат сложения с минутами
        if (1439 < minutes)
        {
            Console.WriteLine("Некорректный ввод количества вычитаемых минут!");
            result = time;
        }
        else
        {
            int object_minutes = time.hours * 60 + time.minutes;
            object_minutes += minutes;
            result.hours = object_minutes / 60;
            result.minutes = object_minutes % 60;
            Count_of_objects--;
            result.Show();
        }
        return result;
    }
    public Time Plus(int minutes) // Добавление минут к объекту через нестатичный метод
    {
        Time result = new Time(); // Результат сложения с минутами
        if (1439 < minutes)
        {
            Console.WriteLine("Некорректный ввод количества вычитаемых минут!");
            result = this;
        }
        else
        {
            int object_minutes = hours * 60 + this.minutes;
            object_minutes += minutes;
            result.hours = object_minutes / 60;
            result.minutes = object_minutes % 60;
            Count_of_objects--;
            result.Show();
        }
        return result;
    }
    #endregion
    #region Перегрузка
    public static Time operator ++(Time time)
    {
        try
        {
            if (time.minutes == 59)
            {
                if (time.hours < 23)
                {
                    time.hours++;
                    time.minutes = 0;
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                time.minutes++;
            }
            return time;
        }
        catch (Exception)
        {
            Console.WriteLine("Невозможно прибавить минуту к текущему значению!");
            return time;
        }
    }
    public static Time operator --(Time time)
    {
        try
        {
            if (time.minutes == 0)
            {
                if (time.hours > 0)
                {
                    time.hours--;
                    time.minutes = 59;
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                time.minutes--;
            }
            return time;
        }
        catch (Exception)
        {
            Console.WriteLine("Невозможно вычесть минуту из текущего значения!");
            return time;
        }
    }
    public static explicit operator int(Time time)  // Перегрузка явного приведения int 
    {
         return time.hours;  // Возвращается количество часов
    }
    public static implicit operator bool(Time time)
    {
        if (time.minutes != 0 && time.hours != 0) return true;
        else return false;
    }
    public static Time operator +(Time time, int minutes)
    {
        Time result = new Time(); // Результат сложения с минутами
        if (1439 < minutes)
        {
            Console.WriteLine("Некорректный ввод количества вычитаемых минут!");
            result = time;
        }
        else
        {
            int object_minutes = time.hours * 60 + time.minutes;
            object_minutes += minutes;
            result.hours = object_minutes / 60;
            result.minutes = object_minutes % 60;
            Count_of_objects--;
        }
        return result;
    }
    public static Time operator +(int minutes, Time time)
    {
        Time result = new Time(); // Результат сложения с минутами
        if (1439 < minutes)
        {
            Console.WriteLine("Некорректный ввод количества вычитаемых минут!");
            result = time;
        }
        else
        {
            int object_minutes = time.hours * 60 + time.minutes;
            object_minutes += minutes;
            result.hours = object_minutes / 60;
            result.minutes = object_minutes % 60;
            Count_of_objects--;
        }
        return result;
    }
    public static Time operator -(Time time, int minutes)
    {
        Time result = new Time(); // Результат сложения с минутами
        if (time.hours * 60 + time.minutes < minutes)
        {
            Console.WriteLine("Некорректный ввод количества вычитаемых минут!");
            result = time;
        }
        else
        {
            int object_minutes = time.hours * 60 + time.minutes;
            object_minutes -= minutes;
            result.hours = object_minutes / 60;
            result.minutes = object_minutes % 60;
            Count_of_objects--;
        }
        return result;
    }
    public static Time operator -(int minutes, Time time)
    {
        Time result = new Time(); // Результат сложения с минутами
        if (minutes < time.hours * 60 + time.minutes)
        {
            Console.WriteLine("Некорректный ввод количества вычитаемых минут!");
            result = time;
        }
        else
        {
            int object_minutes = time.hours * 60 + time.minutes;
            object_minutes = minutes - object_minutes;
            result.hours = object_minutes / 60;
            result.minutes = object_minutes % 60;
            Count_of_objects--;
        }
            return result;
    }
    public int CompareTo(Time time)
    {
        if (this.hours * 60 + this.minutes < time.hours * 60 + time.minutes) return -1;
        else if (this.hours * 60 + this.minutes > time.hours * 60 + time.minutes) return 1;
        else return 0;
    }
    #endregion
}
