﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double  Dispalacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined { get; set; }

        /*internal static Car ParseFromCsv(string line)
        {
            var columns = line.Split(',');

            return new Car()
            {
                Year = int.Parse(columns[0]),
                Manufacturer = columns[1],
                Model = columns[2],
                Dispalacement = double.Parse(columns[3]),
                Cylinders = int.Parse(columns[4]),
                City = int.Parse(columns[5]),
                Highway = int.Parse(columns[6]),
                Combined = int.Parse(columns[7]),
            };
        }*/
    }
}
