using System;

namespace DelegatesExample
{
    class Program
    {
        private delegate void DoStuff(string s);

        static void Main()
        {
            DoStuff ds = Console.WriteLine;
            //ds("Hallo Welt!");

            // das ist das gleich
            if (ds != null)
            {
                ds("Ja, ist nicht null");
            }
            
            // wie das hier:
            ds?.Invoke("Ja, ist nicht null");

            // oder
            //ds.Invoke("Hallo");

            //ds = MeineKlasseKlasse.MeineKlasseMethode;
            //ds("Hallo Welt!");


            //ds = (s) => Console.WriteLine("Nachricht aus der Lamda-Methode: " + s);

            //ds("Hallo Welt!");

            MyMethod(ds);
            
            Console.ReadLine();
        }

        private static void MyMethod(DoStuff ds)
        {
            ds("Hey");
        }
    }

    class MeineKlasseKlasse
    {
        public static void MeineKlasseMethode(string message)
        {
            Console.WriteLine($"Nachricht aus MeineKlasseKlasse.MeineKlasseMethode(): {message}");
        }
    }
}
