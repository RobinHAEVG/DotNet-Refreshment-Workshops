using System;

namespace InheritanceExamples
{
    public interface IMyInterface
    { }
    public interface IMyInterface2
    { }

    public class Small
    { }
    public class Big : Small//, IMyInterface, IMyInterface2
    { }
    public class Bigger : Big
    { }
    public class Huge : Small
    { }
    

    class Program
    {
        static void Main()
        {
            Covariance.Execute();
            Contravariance.Execute();
            
            Console.ReadKey();
        }
    }

    class Covariance
    {
        public static void Execute()
        {
            Small sm1 = new Small();
            Small sm2 = new Big();
            Small sm3 = new Bigger();
            Big big1 = new Big();
            Big big2 = new Bigger();
            //IMyInterface2 imyint1 = new Bigger();
            //Huge h1 = new Big();
            //Big big3 = new Huge();
            //Big big3 = new Small();
        }
    }

    delegate Small convarDel(Big mc);

    class Contravariance
    {
        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }

        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        public static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");
            return new Small();
        }

        public static void Execute()
        {
            convarDel del = Method1;
            del += Method2;
            del += Method3;
            

            del(new Big());
        }
    }
}

