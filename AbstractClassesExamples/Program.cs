using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AbstractClassesExamples.Annotations;

namespace AbstractClassesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var h = new Hund();
            //Console.WriteLine(h.Beschreibe());
            ////h.Hallo();

            //Console.WriteLine($"Ich habe {h.Beine} Beine!");

            //var s = new Spinne();
            //Console.WriteLine($"Ich habe {s.Beine} Beine, aber die meisten Tiere haben {s.BasisBeine()}!");

            Console.WriteLine("\ndone.");
            Console.ReadKey();
        }
    }

    abstract class ArztBasis
    {
        public virtual int HaevgId { get; set; }
        public virtual int LAN7 { get; set; }
        public virtual string Vorname { get; set; }
        public virtual string Name { get; set; }
    }

    class Arzt : ArztBasis
    { }

    class ArztMitBild : Arzt
    {
        public byte[] Bild { get; set; }
    }

    abstract class Tier
    {
        public virtual int Beine { get; set; } = 4;

        public virtual string Beschreibe()
        {
            return "Darüber ist nichts bekannt!";
        }

        public void Hallo()
        {
            Console.WriteLine("Hey");
        }
    }

    class Spinne : Tier
    {
        public override int Beine { get; set; } = 8;

        public int BasisBeine() => base.Beine;
    }

    class Hund : Tier
    {
        
        
        public override string Beschreibe()
        {
            
            string s = base.Beschreibe();
            return "Da ist doch was aufgetaucht! " + s;
        }
    }

    abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Set<T>(ref T val, T newVal, [CallerMemberName] string propertyName = null)
        {
            if (propertyName == null)
                return;

            val = newVal;

            this.OnPropertyChanged(propertyName);
        }
    }
}
