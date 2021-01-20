using System;

namespace EventsExampleWithArgs
{
    class Program
    {
        
        static void Main()
        {
            var bl = new BusinessLogic();
            bl.ProcessCompleted += MyEventHandler;
            bl.StartSomeProcess();

            System.Console.In.ReadLine();
        }

        private static void MyEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("something happened!");
        }
    }

    public class BusinessLogic
    {
        public event EventHandler ProcessCompleted;

        public void StartSomeProcess()
        {
            // do something here
            // which takes some time
            // do something there
            //Task.Run(this.OnProcessCompleted);
            this.OnProcessCompleted(EventArgs.Empty);
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
        
    }
}
