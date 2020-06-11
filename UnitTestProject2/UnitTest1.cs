using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab9;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Time_initializing()
        {
            Time time = new Time();
            time.Show();
            time = new Time(12, 13);
            time = new Time(24, 60);
            time = new Time(-1, -1);
        }
        [TestMethod]
        public void Time_changes()
        {
            Time time = new Time(12, 12);
            time++;
            time.Plus(20);
            time.Plus(30);
            time.Plus(100);
            time.Plus(1500);
            time.Hours = 12;
            time.Hours = 25;
            time.Hours = -1;
            time.Minutes = 59;
            time.Minutes = 61;
            time.Minutes = -2;
            int minutes = time.Minutes;
            int hours = time.Hours;
            time++;
            time--;
            time = new Time();
            time--;
            time = new Time(12, 0);
            time--;
            time = new Time(22, 59);
            time++;
            time = new Time(23, 59);
            time++;
            time = new Time(12, 0);
            time = Time.Plus(time, 30);
            time = Time.Plus(time, 65);
            time = Time.Plus(time, 10000000);
            time = Time.Plus(time, -1);
            time = new Time(23, 59);
            time = Time.Plus(time, 10);
        }
        [TestMethod]
        public void Time_overloading()
        {
            Time time = new Time(12, 30);
            Time new_time = new Time();
            new_time = time + 15;
            new_time = time - 15;
            new_time = 15 + time;
            new_time = 15 - time;
            new_time = time + 150;
            new_time = time - 150;
            new_time = 150 + time;
            new_time = 150 - time;
            new_time = time + 10000000;
            new_time = time - 10000000;
            new_time = 10000000 + time;
            new_time = 10000000 - time;
            bool check = time;
            time = new Time();
            check = time;
            int minutes = new_time.Count_of_minutes();
            int number = (int)time;
        }
        //[TestMethod]
        /*public void Time_array_initializing()
        {
            TimeArray arr = new TimeArray();
            arr.Show();
            Time time = TimeArray.Mean(arr);
            Random rand = new Random();
            arr = new TimeArray(5, rand);
            arr.Show();
            time = arr[0];
            time = arr[10];
            arr[0] = new Time(12, 15);
            arr[10] = new Time();
            time = TimeArray.Mean(arr);
            TimeArray a = null;
            time = TimeArray.Mean(a);
        }*/
    }
}
