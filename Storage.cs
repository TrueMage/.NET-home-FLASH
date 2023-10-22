using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_FLASH
{
    internal abstract class Storage
    {
        private string _name;
        private string _brand;
        private string _model;
        private int _count;
        private double _price;

        #region Properties
        public virtual string Name { get; set; }
        public virtual string Brand { get; set; }
        public virtual string Model { get; set; }
        public virtual int Count { get; set; }
        public virtual double Price { get; set; }

        #endregion

        public virtual void PrintInfo()
        {
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("BRAND: " + Brand);
            Console.WriteLine("MODEL: " + Model);
            Console.WriteLine("COUNT: " + Count);
            Console.WriteLine("PRICE: " + Price);
        }

        public virtual void Load()
        {

        }

        public virtual void Save()
        {

        }

    }
}
