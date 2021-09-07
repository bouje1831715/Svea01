using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Svea01.Models
{
    public class DataModel
    {
        private readonly Random _random = new Random();

        public int RandomNumber()
        {
            return _random.Next(0, 1000);
        }

        public int[] yeet(int value)
        {
            
            int[] rndData = new int[value];

            for (int i = 0; i < value; i++)
            {
                rndData[i] = _random.Next(0, 1000);
            }

            return rndData;
        }
    }
}
