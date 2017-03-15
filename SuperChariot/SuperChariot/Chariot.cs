using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperChariot
{
    public class Chariot
    {
        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }

        public String Lettre
        {
            get;
            private set;
        }

        public Chariot(int x, int y)
        {
            X = x;
            Y = y;
            Lettre = "C";
        }
    }
}
