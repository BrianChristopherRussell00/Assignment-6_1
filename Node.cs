using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_1
{
    public class Node
    {
        public Node(House house)
        {
            Data = house;
            Next = null;
        }
        internal House Data { get; set; }
        internal Node Next { get; set; }

        public class SingleLinkedList
        {
            internal Node Head { get; set; }
            public int Length { get; set; }

            public House FindElement(int houseNumber)
            {
                House house = null;
                for (int i = 0; i < Length; i++)
                {
                    if (house.HouseNumber == houseNumber)
                    {
                        return house;
                    }
                }
                return house;
            }
        }
        

    }
}
