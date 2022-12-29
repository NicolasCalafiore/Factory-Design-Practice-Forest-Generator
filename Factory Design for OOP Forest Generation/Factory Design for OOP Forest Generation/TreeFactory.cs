using Factory_Design_for_OOP_Forest_Generation.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_for_OOP_Forest_Generation
{
    internal class TreeFactory 
    {
        static List<BirchTree> BirchList = new List<BirchTree>();              // Contains List of all Birch Trees created
        static List<OakTree> OakList = new List<OakTree>();                    // Contains List of all Oak Trees created
        static List<PineTree> PineList = new List<PineTree>();                 // Contains List of all Pine Trees created
        static string forestMap;                                                // newly generated forest map
        static ITree treeStrategy;                                              // Interface connecting to all types of trees
        static Random rnd = new Random();                                       

        public TreeFactory() {
            forestMap = "";
        }


        public string getTree()
        {
            int random = rnd.Next(0, 3);                                        // Decides what type of tree should be printed
            switch (random)
            {
                case 0: treeStrategy = new BirchTree(); BirchList.Add( (BirchTree) treeStrategy);  break;   //Creates birch tree
                case 1: treeStrategy = new OakTree(); OakList.Add((OakTree) treeStrategy); break;           //Creates Oak tree
                case 2: treeStrategy = new PineTree(); PineList.Add((PineTree) treeStrategy); break;        //Creates Pine tree
            }
           string symbol = treeStrategy.getTree();                               // Interface is used to call the .getTree symbol of whichever Tree object was created.
           return symbol;                                                        // Returns the symbol that represents the tree

        }

        public void getTreeDetails()
        {
            //TO-DO ADD TREES
            
        }


    }
}
