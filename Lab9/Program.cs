using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{

    class Program
    {
        public static int InputNumber(string ForUser, int left, int right)
        {
            bool is_correct_input;
            int number = 0;
            do
            {
                Console.WriteLine(ForUser);
                try
                {
                    string buf = Console.ReadLine();
                    number = Convert.ToInt32(buf);
                    if (number >= left && number <= right) is_correct_input = true;
                    else
                    {
                        Console.WriteLine("Неверный ввод числа!");
                        is_correct_input = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный ввод числа!");
                    is_correct_input = false;
                }
            }
            while (!is_correct_input);
            return number;
        }
        static Time Initializating_object()
        {
            Time time = null;
            Menu.Time_initialization_object_menu();
            int user_choice = InputNumber("", 1, 3);
            switch (user_choice)
            {
                case 1:

                    {
                        time = new Time();
                        Console.WriteLine("Объект создан");
                        break;
                    }

                case 2:
                    {
                        int hours = InputNumber("Введите количество часов:", 0, 23);
                        int minutes = InputNumber("Введите количество минут:", 0, 59);
                        time = new Time(hours, minutes);
                        Console.WriteLine("Объект создан");

                        break;
                    }
                case 3:
                    break;
            }
            return time;
        }
        static void Overloading(Time time)
        {
            Menu.Time_Overloading_menu();
            int user_choice = InputNumber("", 1, 7);
            switch (user_choice)
            {
                case 1:
                    {
                        time++;
                        time.Show();
                        break;
                    }
                case 2:
                    {
                        time--;
                        time.Show();
                        break;
                    }
                case 3:
                    {
                        int hours = (int)time;
                        Console.WriteLine($"Количество часов равно: {hours}");
                        break;
                    }
                case 4:
                    {
                        bool is_not_null = time;
                        if (is_not_null) Console.WriteLine("Часы и минуты не равны нулю");
                        else Console.WriteLine("Часы и минуты равны нулю");
                        break;
                    }
                case 5:
                    {
                        if (time != null)
                        {
                            int minutes = InputNumber("Введите количество минут:", 1, 1440);
                            Console.WriteLine(@"1. Прибавить минуты к объекту
2. Прибавить объект к минутам");
                            user_choice = InputNumber("", 1, 2);
                            switch (user_choice)
                            {
                                case 1:
                                    {

                                        time = time + minutes;
                                        time.Show();
                                        break;
                                    }
                                case 2:
                                    {
                                        time = minutes + time;
                                        time.Show();
                                        break;
                                    }
                            }
                        }
                        else Console.WriteLine("Объект еще не создан!");
                        break;
                    }

                case 6:
                    {
                        if (time != null)
                        {
                            int minutes = InputNumber("Введите количество минут:", 1, 1440);
                            Console.WriteLine(@"1. Вычесть минуты из объекта
2. Вычесть объект из минут");
                            user_choice = InputNumber("", 1, 2);
                            switch (user_choice)
                            {
                                case 1:
                                    {
                                        time = time - minutes;
                                        time.Show();
                                        break;
                                    }
                                case 2:
                                    {
                                        time = minutes - time;
                                        time.Show();
                                        break;
                                    }
                            }
                        }
                        else Console.WriteLine("Объект еще не создан!");
                        break;
                    }
                default:
                    break;
            }
        }
        static void Working_with_time_objects()
        {
            Time time = null;
            int user_choice;
            do
            {
                Menu.Time_main_menu();
                user_choice = InputNumber("", 1, 5);
                switch (user_choice)
                {
                    case 1:
                        {
                            time = Initializating_object();
                            break;
                        }
                    case 2:
                        {
                            if (time != null)
                            {
                                time.Show();
                            }
                            else Console.WriteLine("Объект еще не создан!");
                            break;
                        }
                    case 3:
                        {
                            Menu.Time_various_methods_of_adding_menu();
                            user_choice = InputNumber("", 1, 3);
                            switch (user_choice)
                            {
                                case 1:
                                    {
                                        int minutes = InputNumber("Введите количество добавляемых минут: ", 0, 1440);
                                        time = Time.Plus(time, minutes);
                                        break;
                                    }
                                case 2:
                                    {
                                        int minutes = InputNumber("Введите количество добавляемых минут: ", 0, 1440);
                                        time = time.Plus(minutes);
                                        break;
                                    }
                                case 3: break;
                            }
                            break;
                        }
                    case 4:
                        {
                            Overloading(time);
                            break;
                        }
                    default: break;
                }
            }while(user_choice != 5);
        }
        /*(static TimeArray Initializating_array(TimeArray array_object)
        {
            array_object = null;
            int size;
            Menu.Array_initialization_object_menu();
            int user_choice = InputNumber("", 1, 4);
            switch (user_choice)
            {
                case 1:
                    {
                        array_object = new TimeArray();
                        Console.WriteLine("Массив создан");
                        break;
                    }

                case 2:
                    {
                        size = InputNumber("Введите размер массива: ", 1, 10);
                        array_object = new TimeArray(size);
                        Console.WriteLine("Массив создан");
                        break;
                    }
                case 3:
                    {
                        size = InputNumber("Введите размер массива: ", 1, 10);
                        Random random = new Random();
                        array_object = new TimeArray(size, random);
                        Console.WriteLine("Массив создан");
                        break;
                    }
                default: break;
            }
            return array_object;
        }
        static void Working_with_time_array()
        {
            TimeArray array_object = null;
            int user_choice;
            do
            {
                Menu.Array_main_menu();
                user_choice = InputNumber("", 1, 4);
                switch (user_choice)
                {
                    case 1:
                        {
                            array_object = Initializating_array(array_object);
                            break;
                        }
                    case 2:
                        {
                            if (array_object != null)
                            {
                                array_object.Show();
                            }
                            else Console.WriteLine("Объект еще не создан!");
                            break;
                        }
                    case 3:
                        {
                            Time mean = new Time();
                            Time.Count_of_objects--;
                            mean = TimeArray.Mean(array_object);
                            break;
                        }
                    default: break;
                }
            } while (user_choice != 4);
        }*/
            static void Run()
        {
            int user_choice;
            do
            {
                Menu.Main_menu();
                user_choice = InputNumber("", 1, 3);
                switch (user_choice)
                {
                    case 1:
                        Working_with_time_objects();
                        break;
                    case 2:
                        //Working_with_time_array();
                        break;
                    case 3:
                        break;
                    default:
                        break;

                }
            } while (user_choice != 3);
        }

        static void Main(string[] args)
        {
            //Run();
            TimeArray timeArray = new TimeArray(5, new Random());
            timeArray.Sort();
        }
        

    }
}
