using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitUzduotis
{
    internal class B : IVilain
    {
        private string UserName { get; set; }
        string IVilain.UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private int Level { get; set; }
        int IVilain.Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Duomenys(string username, int level)
        {
            UserName = username;
            Level = level;
        }

        void IVilain.Strength()
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Kokio nori herojaus?");

        }
    }
}