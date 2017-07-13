using System;

namespace inheritance
{
    public class Hat
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }

        public virtual void Doff() 
        {
            Console.WriteLine("I tilted forward, m'lady");
        }

        public virtual void Wear()
        {
            Console.WriteLine("I'm now sitting on your head");
        }
        public virtual void Wear(string location) 
        {
            Console.WriteLine("I'm now sitting on your head");
        }
    }

    public interface IAdjustable
    {
        double MinSize { get; set; }
        double MaxSize { get; set; }
        string SizingMechanism { get; set; }
    }

    public class BrimlessHat: Hat
    {
        public override void Wear()
        {
            Console.WriteLine("I smoothly slipped onto your head");
        }
        
    }

    public class BrimmedHat: Hat
    {
        public override void Wear(string location)
        {
            Console.WriteLine("BrimmedHat");
        }
    }

    public class CowboyHat: BrimmedHat
    {
        
    }

  public class BaseballHat : BrimmedHat, IAdjustable
  {
    public double MinSize { get; set; }
    public double MaxSize { get; set; }
    public string SizingMechanism { get; set; }
  }

  class Program
    {
        static void Main(string[] args)
        {
            BaseballHat pirates = new BaseballHat();
            pirates.Wear();
        }
    }
}
