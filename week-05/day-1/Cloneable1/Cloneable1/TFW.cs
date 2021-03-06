﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable1
{
     public class TFW : ICloneable
    {
        public string name;
        public int age;
        public string race;

        public TFW(string name, int age, string race)
        {
            this.name = name;
            this.age = age;
            this.race = race;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public TFW()
        {
            this.name = "Kevin";
            this.age = 20;
            this.race = "human";
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I am {0}, a {1} year old {2}.", this.name, this.age, this.race);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: to live a bit more.");
        }

    }
}
