using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{

    internal class TimeArray
    {
        Time[] array;
        public int Length { get; set; } = 0;
        public static int Count_of_objects { get; set; }
        #region Конструкторы
        public TimeArray()
        {
            array = new Time[Length];
            Count_of_objects++;
        }
        public TimeArray(int length) // Конструктор с параметрами
        {
            Length = length;
            array = new Time[Length];
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"Ввод объекта {i + 1}");
                int hours = Program.InputNumber("Введите количество часов:", 0, 23);
                int minutes = Program.InputNumber("Введите количество минут:", 0, 59);
                Time array_element = new Time(hours, minutes);
                array[i] = array_element;
            }
            Count_of_objects++;

        }
        public TimeArray(int length, Random random)
        {
            Length = length;
            array = new Time[Length];
            for (int i = 0; i < Length; i++)
            {
                array[i] = Random(random);
            }
            Count_of_objects++;
        }
        public static Time Random(Random random)
        {
            int hours = random.Next(0, 24);
            int minutes = random.Next(0, 60);
            Time array_element = new Time(hours, minutes);
            return array_element;
        }
        #endregion
        public Time this[int index]
        {
            get
            {
                if (index < 0 && index >= array.Length)
                    throw new IndexOutOfRangeException("Индекс вне диапазона массива!");

                return array[index];
            }

            set
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException("Индекс вне диапазона массива!");

                array[index] = value;
            }
        }
        public void Show() // Вывод времени
        {
            if (array != null)
            {
                if (array.Length != 0)
                {
                    foreach (Time item in array)
                    {
                        item.Show(true);
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Количество объектов Time[]: {Count_of_objects}");
                }
                else Console.WriteLine("Массив инициализирован без объектов!");
            }
            else Console.WriteLine("Объект не создан!");
        }
        public static Time Mean(TimeArray array_object)
        {
            Time mean_result;
            if (array_object != null)
            {
                if (array_object.Length != 0)
                {
                    int count_of_minutes = 0;
                    for (int i = 0; i < array_object.array.Length; i++)
                    {
                        count_of_minutes += array_object[i].Count_of_minutes();
                    }
                    int mean_count_of_minutes = count_of_minutes / Time.Count_of_objects;
                    int mean_hours = mean_count_of_minutes / 60;
                    int mean_minutes = mean_count_of_minutes % 60;
                    mean_result = new Time(mean_hours, mean_minutes);
                    Time.Count_of_objects--;
                    Console.Write("Среднее ");
                    mean_result.Show(true);
                }
                else
                {
                    Console.WriteLine("Массив инициализирован без объектов!");
                    mean_result = new Time();
                    Time.Count_of_objects--;
                }
            }
            else
            {
                Console.WriteLine("Массив еще не создан!");
                mean_result = new Time();
                Time.Count_of_objects--;
            }
            return mean_result;
        }
        public void Sort()
        {
            Array.Sort(array);
        }
    }
}
