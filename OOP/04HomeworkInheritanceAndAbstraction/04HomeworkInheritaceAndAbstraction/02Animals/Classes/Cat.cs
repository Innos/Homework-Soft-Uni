﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classes
{
    class Cat : Animal
    {
        public Cat(string name,int age,string gender) : base(name,age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} says Miauuuu!",this.Name);
        }
    }
}
