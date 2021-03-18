using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace ProcessWpfExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
            var psi = new ProcessStartInfo()
            {
                //FileName = @"C:\Local\hello.exe",
                FileName = @"C:\Program Files (x86)\Notepad++\notepad++.exe",
                Arguments = @"C:\Local\test.txt",
                UseShellExecute = true,
                CreateNoWindow = true,
                //RedirectStandardOutput = true,
            };
            var p = new Process() { StartInfo = psi };
            p.Start();
            //Thread.Sleep(3000);

            //string output = p.StandardOutput.ReadToEnd();
            //Console.WriteLine($"output: {output}");
        }
    }
}
