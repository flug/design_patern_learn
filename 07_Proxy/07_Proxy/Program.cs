using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IAnimation animation = new AnimationProxy();
            animation.Dessine();
            animation.Click();
            animation.Dessine();
            Console.ReadKey();
        }
    }
}