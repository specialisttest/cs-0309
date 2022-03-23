using System;

namespace Delegates
{
    class Program
    {
        public static void Fire(object sender)
        {
            Console.WriteLine("Fire");
        }
        
        static void Main(string[] args)
        {
            Switcher sw = new Switcher();
            Lamp lamp = new Lamp();
            TvSet tv = new TvSet();

            // subscribe
            //sw.ElectricityOn += new Electricity(lamp.LightOn);
            sw.ElectricityOn += lamp.LightOn;
            sw.ElectricityOn += tv.TvOn;
            sw.ElectricityOn += Program.Fire;
            sw.ElectricityOn += delegate (object sender)
            {
                Console.WriteLine("Пожар!");
            };

            sw.ElectricityOn +=  s => Console.WriteLine("Пожарные приехали!");
            //Electricity del = s => Console.WriteLine("Пожарные приехали!");

            // unsubscribe
            //sw.ElectricityOn -= lamp.LightOn;

            //sw.ElectricityOn(sw);
            sw.SwitchOn();

        }
    }
}
