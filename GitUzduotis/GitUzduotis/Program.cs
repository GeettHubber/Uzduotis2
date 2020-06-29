using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitUzduotis
{
    public interface IHero
    {
        string UserName { get; set; }
        int Level { get; set; }

        void Strength();
        double AddPower(double power);
    }

    interface IVilain
    {
        
        string UserName { get; set; }
        int Level { get; set; }

        void Strength();
    }

    class A : IHero
    {
        string UserName { get; set; }
        int Level { get; set; }
        public string SkaitytiZodi()
        {
            UserName = Console.ReadLine();
                return UserName;
        }
        public int SkaitytiSkaiciu()
        {
            Level = Convert.ToInt32(Console.ReadLine());
            return Level;
        }
        double IHero.AddPower(double power)
        {
            return Level / 2;
        }
        void IHero.Strength()
        {

        }
    }

    class B : IVilain
    {
        string UserName { get;  set; }
        string IVilain.UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Level { get; set; }
        int IVilain.Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Duomenys ( string username, int level)
        {
            UserName = username;
            Level = level;
        }

        void IVilain.Strength()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kokio nori herojaus?");

        }
    }
}
