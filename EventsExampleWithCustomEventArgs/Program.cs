using System;

namespace EventsExampleWithCustomEventArgs
{
    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();

            System.Console.In.ReadLine();
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString() + " " + e.CompletionTime.ToLongTimeString());
        }
    }

    public class ProcessEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }

    public class ProcessBusinessLogic
    {
        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        public void StartProcess()
        {
            var args = new ProcessEventArgs();

            try
            {
                Console.WriteLine("Process Started!");

                // some code here..

                args.IsSuccessful = true;
                args.CompletionTime = DateTime.Now;
                OnProcessCompleted(args);
            }
            catch (Exception ex)
            {
                args.IsSuccessful = false;
                args.CompletionTime = DateTime.Now;
                OnProcessCompleted(args);
            }
        }

        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
