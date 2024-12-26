using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241226001CS
{
    internal class Puppy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Variety { get; set; }
        public int Weight { get; set; }
        public string Personality { get; set; }

        private string _Color; //關稅
        public string Color
        {
            get { return this._Color; }
            set { this._Color = value; }
        }

        //建構子函式1
        public Puppy() { }

        //建構子函式2 
        public Puppy(int id, string name, string variety, int weight, string personality, string color)
        {
            Id = id;
            Name = name;
            Variety = variety;
            Weight = weight;
            Personality = personality;
            Personality = color;

        }

        public void CallMyPuppyName()
        {
            Console.WriteLine("ID is:" + this.Id.ToString());
            Console.WriteLine("Name is :" + this.Name.ToString());
            Console.WriteLine("Variety is :" + this.Variety.ToString());
            Console.WriteLine("Weight is :" + this.Weight.ToString());
            Console.WriteLine("Personality is :" + this.Personality.ToString());
            Console.WriteLine("Personality is :" + this.Personality.ToString());
            //類推..把所有屬性印出來.

        }
    }
}

