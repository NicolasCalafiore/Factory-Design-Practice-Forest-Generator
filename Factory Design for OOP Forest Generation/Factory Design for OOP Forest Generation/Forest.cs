using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_for_OOP_Forest_Generation
{
    internal class Forest
    {
        string forestMap = "";                                           // Will contain the map in the forest in form "OAPBCOAP"
        TreeFactory factory= new TreeFactory();                          // Creates wrapper object for 'new' keywords for Tree object creations.

        public Forest() { 
            

        }

        public void GenerateMap(int size)   
        {
            for (int j = 0; j < size; j++)                              // Inserts a '\n' at the end of each row
            {   
                for (int i = 0; i <= size; i++)
                {
                    forestMap = forestMap + factory.getTree() + " ";    //Prints one-by-one each tree within one row
                }
                forestMap = forestMap + "\n";                           //Ends the row
            }

        }

        public void ViewMap()
        {
            Console.WriteLine(forestMap);                               // String of Forest is printed
            factory.getTreeDetails();
        }
    }
}
