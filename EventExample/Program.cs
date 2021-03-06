﻿using System;

namespace EventExample
{
    class Program
    {
        static void Main()
        {
            BusinessLogic bl = new BusinessLogic();
            bl.ProcessCompleted += MyEventHandler;
            bl.StartSomeProcess();

            Console.ReadKey();
        }

        private static void MyEventHandler()
        {
            Console.WriteLine("something happened!");
        }
    }

    public class BusinessLogic
    {
        public delegate void MyDelegate();

        public event MyDelegate ProcessCompleted;

        public void StartSomeProcess()
        {
            // do something here
            // which takes some time
            // do something there
            //Task.Run(this.OnProcessCompleted);
            this.OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
           ProcessCompleted?.Invoke();
        }
    }
}
