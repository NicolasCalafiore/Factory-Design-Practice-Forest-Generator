﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_for_OOP_Forest_Generation.Assets
{
    internal class OakTree : ITree
    {
        string symbol;

        public OakTree()
        {
            this.symbol = "O";
        }
        public override string getTree()
        {
            return symbol;
        }






    }
}
