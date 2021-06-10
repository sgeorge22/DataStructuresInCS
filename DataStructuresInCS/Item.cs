using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresInCSLib
{
    //this class will contain the data the user wants to store
    public class Item<T>//adding the <T> acts as a data type, in this case T = int
    {
        public T t { get; set; }
        public int Next { get; set; } = -1; //next and prev are pointing to the array to keep things in order
        public int Prev { get; set; } = -1;

        public Item(T t)
        {
            this.t = t;
        }



    }
}
