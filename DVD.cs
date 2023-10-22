using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_FLASH
{
    internal class DVD : Storage
    {
        Random rand = new Random();

        private int _speedWrite;
        private int _speedRead;

        #region Constructors
        public DVD()
        {
            Name = "DVD";
            Brand = "unknown";
            Model = "unknown";
            _speedWrite = rand.Next(100, 1000);
            _speedRead = rand.Next(100, 1000);
        }

        public DVD(double speedWrite, double speedRead)
        {
            Name = "DVD";
            Brand = "unknown";
            Model = "unknown";
            _speedWrite = speedWrite;
            _speedRead = speedRead;
        }
        #endregion

        #region Properties
        public int SpeedWrite
        {
            get { return _speedWrite; }
            set
            {
                if (value < 1) throw new InvalidValueException("Speed of writing should be more than 1 byte");
                _speedWrite = value;
            }
        }

        public int SpeedRead
        {
            get { return _speedRead; }
            set
            {
                if (value < 1) throw new InvalidValueException("Speed of reading should be more than 1 byte");
                _speedRead = value;
            }
        }
        #endregion

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("SPEED WRITE: " + _speedWrite);
            Console.WriteLine("SPEED READ: " + _speedRead);
        }

    }
}
