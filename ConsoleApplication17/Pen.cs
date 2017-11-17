using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    public class Pen
    {
        public string Type { get; set; }

        private string _manufacturer;
        private double _price;

        public string Color;

        public double Price => _price * 26.85; 

        public int Size { get; private set; }

        public string Manufacturer
        {
            get
            {              
                return _manufacturer;
            }
            set { _manufacturer = value; }
        }
        
        public Pen(string manufacturer)
        {
            _manufacturer = manufacturer;
            Size = 25;
        }
        
        public void ChangeSize(int size)
        {
            Size = size;
        }
    }
}
