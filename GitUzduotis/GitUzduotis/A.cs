using System;

namespace GitUzduotis
{
    internal class A : IHero, IVilain
    {
        private string UserName { get; set; }
        private int Level { get; set; }
        string IHero.UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IHero.Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IVilain.UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IVilain.Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void Strength()
        {
            throw new NotImplementedException();
        }
    }
}