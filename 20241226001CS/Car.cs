using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241226001CS
{
    internal class Car
    {
        //屬性
        public int Id { get; set; }  //車子的ID,車牌
        public string Owner { get; set; }  //車子主人的名字
        public string Description { get; set; } //關於這台車描述
        public double Price {  get; set; }  
        public string Brand { get; set; } //品牌
        public string Model { get; set; }  //型號

        private double _tax; //關稅
        public double Tax
        {
            get { return this._tax; }
            set { this._tax = value; }
        }

        //建構子函式1
        public Car()     {       }

        //建構子函式2 
        public Car(int id, string vOwner, string description, double price, string brand, string model, double tax)
        {
            Id = id;
            Owner = vOwner;
            Description = description;
            Price = price;
            Brand = brand;
            Model = model;
            Tax = tax;
           
        }

        public void PrintAllAttrib()
        {
            Console.WriteLine("ID is:" + this.Id.ToString());
            Console.WriteLine("Owener is :"+this.Owner.ToString());
            //類推..把所有屬性印出來.

        }
    }
}
