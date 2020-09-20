using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Freezer
    {
        public bool GetisOpen()
        {
            return isOpen;
        }

        public void SetIsOpen(bool is_op)
        {
            this.isOpen = is_op;
        }

        public string Get_Brand()
        {
            return brand;
        }

        public void Set_Brand(string brand)
        {
            this.brand = brand;
        }

        public void Show()
        {
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Is open: " + isOpen);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Id freezer" + id_Freezer);
            Console.WriteLine("Count: " + count);
        }

        public void Open_freezer()
        {
            isOpen = true;
            Console.WriteLine("Freezer is open!");
        }

        public void Close_freezer()
        {
            isOpen = false;
            Console.WriteLine("Freezer is close!");
        }

        public void Сhange_volum(ref double volume)
        {
            volume = this.volume;
        }

        public override string ToString()
        {
            return $"brand: {brand}\n" +
                   $"color: {color}\n" +
                   $"volume: {volume}\n" +
                   $"temperature: {temperature}\n" +
                   $"Height: {height}\n" +
                   $"id_Freezer: {id_Freezer}\n" +
                   $"Is open: {isOpen}\n" +
                   $"Count: {count}";
        }
    }
}
