using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20241226001CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puppy DennisPuppy = new Puppy();
            //設定DennisCar的屬性值.
            DennisPuppy.Id = 1;
            DennisPuppy.Name = "Dennis";
            DennisPuppy.Variety ="abc";
            DennisPuppy.Weight =150;
            DennisPuppy.Personality ="happy";
            DennisPuppy.Color ="green";
            //類堆..所有屬性都要設.

            //最後,叫用DennisCar的方法PrintAllAttrib( )印出所有屬性參數.
            DennisPuppy.CallMyPuppyName();
            Console.WriteLine();
            //===============================================
            //第二個 使用有參數的建構子設一台車MarysCar.
            //經由建構子函式2 來設定所有屬性
            Puppy MarysPuppy = new Puppy(2, "Mary","def",30,"unhappy","black");

            //最後,叫用 MarysCar的方法PrintAllAttrib( )印出所有屬性參數.
            MarysPuppy.CallMyPuppyName();


        }
    }
}
