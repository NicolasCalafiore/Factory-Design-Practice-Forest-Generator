using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_for_OOP_Forest_Generation
{
    abstract class ITree
    {
        String symbol;

        public abstract string getTree();
    }
}
