using Factory_Design_for_OOP_Forest_Generation;

/* 
 * Nicolas Calafiore
 * 
 * Scenario: Input will generate a random forest map using Factory Design to create new Tree objects.
 */


Console.WriteLine("How long do you want the forest to be)");
String size = Console.ReadLine();

Forest forest = new Forest();                   // Creates new Forest object
forest.GenerateMap(Int32.Parse(size));          // Forest map is generated
forest.ViewMap();                               // Forest map is printed






