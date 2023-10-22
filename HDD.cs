using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_FLASH
{
    internal class HDD : Storage
    {
        Random rand = new Random();

        private int _size;
        private int _USB;

        #region Constructors
        public HDD()
        {
            Name = "HDD";
            Brand = "unknown";
            Model = "unknown";
            _size = rand.Next(100000, 1000000);
            _USB = rand.Next(1000, 100000);
        }

        public HDD(int size, int usbSpeed)
        {
            Name = "HDD";
            Brand = "unknown";
            Model = "unknown";
            _size = size;
            _USB = usbSpeed;
        }
        #endregion

        #region Properties
        public int Size
        {
            get { return _size; }
            set
            {
                if (value < 1) throw new InvalidValueException("Size of storage should be more than 1 byte");
                _size = value;
            }
        }

        public int USB
        {
            get { return _USB; }
            set
            {
                if (value < 1) throw new InvalidValueException("Speed of USB should be more than 1 byte");
                _USB = value;
            }
        }
        #endregion

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("USB SPEED: " + _USB);
            Console.WriteLine("SIZE: " + _size);
        }

    }
}
