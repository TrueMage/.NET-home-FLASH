﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace home_FLASH
{
    internal class PriceList
    {
        private List<Storage> _list;

        #region Constructors
        public PriceList()
        {
            _list = new List<Storage>();
        }

        public PriceList(int count)
        {
            _list = new List<Storage>();

            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0) _list.Add(new DVD());
                else if (i % 3 == 0) _list.Add(new HDD());
                else _list.Add(new Flash());
            }
        }
        #endregion

        public Storage this[int index]{
            get
            {
                return _list[index];
            }
        }

        public void PrintList()
        {
            Console.Clear();
            for (int i = 0; i < _list.Count(); i++)
            {
                Console.WriteLine("#" + i);
                _list[i].PrintInfo();
            }
            if (_list.Count == 0) Console.WriteLine("The list is empty!");
            Console.WriteLine();
        }
        public void AddNewStorage()
        {
            Console.Clear();

            Console.WriteLine("1 - HDD");
            Console.WriteLine("2 - FLASH");
            Console.WriteLine("3 - DVD");

            int selected = Convert.ToInt32(Console.ReadLine());

            if (selected == 1) _list.Add(new HDD());
            else if (selected == 2) _list.Add(new Flash());
            else _list.Add(new DVD());

            Console.Clear();
            Console.WriteLine("Storage was successfully added to the list");
        }
        public void DeleteStorage()
        {
            Console.WriteLine("Enter the id of storage: ");
            int selected = Convert.ToInt32(Console.ReadLine());

            _list.RemoveAt(selected);
            Console.Clear();
            Console.WriteLine("Storage was successfully deleted from the list");
        }

        public void EditStorage()
        {
            string input;

            Console.WriteLine("Enter the id of storage: ");
            int selected = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("ENTER to skip field");
            Console.Write("Name = ");
            input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input)) _list[selected].Name = input;
            Console.Clear();

            Console.WriteLine("ENTER to skip field");
            Console.Write("Brand = ");
            input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input)) _list[selected].Brand = input;
            Console.Clear();

            Console.WriteLine("ENTER to skip field");
            Console.Write("Model = ");
            input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input)) _list[selected].Model = input;
            Console.Clear();

            Console.WriteLine("ENTER to skip field");
            Console.Write("Count = ");
            input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input)) _list[selected].Count = Convert.ToInt32(input);
            Console.Clear();

            Console.WriteLine("ENTER to skip field");
            Console.Write("Price = ");
            input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input)) _list[selected].Price = Convert.ToDouble(input);
            Console.Clear();

            if (_list[selected] as Flash != null)
            {
                Flash temp = _list[selected] as Flash;

                Console.WriteLine("ENTER to skip field");
                Console.Write("Size = ");
                input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) temp.Size = Convert.ToInt32(input);

                Console.WriteLine("ENTER to skip field");
                Console.Write("Speed of USB = ");
                input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) temp.USB = Convert.ToInt32(input);
            }
            else if (_list[selected] as HDD != null)
            {
                HDD temp = _list[selected] as HDD;

                Console.WriteLine("ENTER to skip field");
                Console.Write("Size = ");
                input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) temp.Size = Convert.ToInt32(input);

                Console.WriteLine("ENTER to skip field");
                Console.Write("Speed of USB = ");
                input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) temp.USB = Convert.ToInt32(input);
            }
            else if (_list[selected] as DVD != null)
            {
                DVD temp = _list[selected] as DVD;

                Console.WriteLine("ENTER to skip field");
                Console.Write("SPEED OF WRITE = ");
                input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input)) temp.SpeedWrite = Convert.ToInt32(input);

                Console.WriteLine("ENTER to skip field");
                Console.Write("SPEED OF READ = ");
                input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) temp.SpeedRead = Convert.ToInt32(input);

            }

            Console.Clear();
            Console.WriteLine("Storage was successfully edited");
        }
        public void FindStorage()
        {
            Console.WriteLine("FIND BY: ");

            Console.WriteLine("1 - Name");
            Console.WriteLine("2 - Brand");
            Console.WriteLine("3 - Model");

            int selected = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Enter the value: ");
            string value = Console.ReadLine();
            Console.Clear();

            if (selected == 1)
            {
                foreach (var s in _list)
                {
                    if (s.Name != value) continue;
                    s.PrintInfo();
                }
            }
            else if (selected == 2)
            {
                foreach (var s in _list)
                {
                    if (s.Brand != value) continue;
                    s.PrintInfo();
                }
            }
            else
            {
                foreach (var s in _list)
                {
                    if (s.Model != value) continue;
                    s.PrintInfo();
                }
            }
        }
    }
}
