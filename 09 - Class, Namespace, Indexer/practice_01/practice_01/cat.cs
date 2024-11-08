using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_01
{
    internal class Cat
    {
        string _name;
        string _breed;
        byte _age;
        bool _sex;
        private int _totalGramsEaten;

        public string Name { get; set; }
        public string Breed { get; set; }
        public byte Age { get; set; }
        public bool Sex {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;   
            }
        }
        public void Meow(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Meowing...");
            }
        }
        public void Eat(int grams)
        {
            Console.WriteLine($"{Name}starts eating");
            while (grams > 0) { 
                Console.WriteLine("Eating");
                int oneBite;
                if (grams > 10) {
                    oneBite = 10;
                    grams = grams - 10;
                }
                else
                {
                    oneBite = grams;
                    grams = 0;
                }
                _totalGramsEaten = oneBite;

            }

            
            
            Console.WriteLine($"{_name} finished eating");
        }
    }
}
