using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public partial class Freezer
    {
        private int temperature { get; set; }
        private double volume { get; set; }
        private string color { get; set; }
        private bool isOpen;
        private string brand;
        private float height { get; set; }

        private static int count;
        public static int Count
        {
            get { return count; }
        }

        public static int id_Freezer { get; }
        static Freezer()
        {
            count = 0;
            id_Freezer = 123456;
        }

        public Freezer()
        {
            temperature = 0;
            volume = 0;
            color = "no color";
            brand = "no brand";
            isOpen = false;
            height = 0;
            count++;
        }

        public Freezer(int temperature, double volume, string color, string brand, bool isOpen, float height)
        {
            if (temperature < 0)
                this.temperature = temperature;
            else
                this.temperature = 0;

            if (volume >= 0)
                this.volume = volume;
            else
                this.volume = 0;

            this.color = color;

            this.brand = brand;

            this.isOpen = isOpen;

            if (height > 0)
                this.height = height;
            else
                height = 0;
            count++;
        }

        public Freezer(int temperature, double volume, string color, string brand, float height) : this(temperature, volume, color, brand, false, height) { }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[5];
            for (int i = 0; i < 5; i++)
            {
                freezers[i] = new Freezer();
                freezers[i].Show();
                //Console.WriteLine(freezers[i].ToString());
                Console.WriteLine();
            }
        }
    }
}
