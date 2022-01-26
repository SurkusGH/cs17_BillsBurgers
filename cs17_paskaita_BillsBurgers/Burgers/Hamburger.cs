using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_paskaita_BillsBurgers
{
    public class Hamburger
    {
        // And in order to match Bill's menu, you will need to create three(3) classes, Hamburger, DeluxeBurger, and HealthyBurger.
        // For the base Hamburger class, there will need to be four variables to represent the four basic ingredients
        // of the Hamburger, Name, Meat, Price, and BreadRollType.
        // The price variable should be of type double, while the other three are of type String.
        // A constructor will be needed to accept these four values as parameters when creating a new hamburger.
        public string Name { get; set; }
        public string Meat { get; set; }
        public string BreadRollType { get; set; }
        public double Price { get; set; }
        // There will also need to be separate variables for four(4) possible additions to the hamburger.
        // Those should be declared with these names:
        // addition1Name, addition1Price, 
        public string Addition1Name { get; set; }
        public double Addition1Price { get; set; }
        // addition2Name, addition2Price,
        public string Addition2Name { get; set; }
        public double Addition2Price { get; set; }
        //addition3Name, addition3Price, 
        public string Addition3Name { get; set; }
        public double Addition3Price { get; set; }
        // addition4Name, and addition4Price.
        public string Addition4Name { get; set; }
        public double Addition4Price { get; set; }
        // The name variables should be of type String and the price variables should be of type double.
        public Hamburger(string name, string meat, string breadRollType, double price = 10d,
            string addition1Name = "Extra: Cheese", double addition1Price = 2.5d,
            string addition2Name = "Extra: Patty", double addition2Price = 3.5d,
            string addition3Name = "Extra Bacon", double addition3Price = 1.5d,
            string addition4Name = "Extra Egg", double addition4Price = 4.5d)
        {
            Name = name;
            Meat = meat;
            BreadRollType = breadRollType;
            Price = price;

            Addition1Name = addition1Name;
            Addition1Price = addition1Price;

            Addition2Name = addition2Name;
            Addition2Price = addition2Price;

            Addition3Name = addition3Name;
            Addition3Price = addition3Price;

            Addition4Name = addition4Name;
            Addition4Price = addition4Price;
            Console.WriteLine($"Hamburger: {Name} w/ {Meat} @ {Price} Eur");
        }
        protected Hamburger()
        {
            // Empty ctor for DeluxeBuger!
        }
        protected Hamburger(string meat, double price)
        {
            // Semi-empty ctor for HealthyBurger!
            Meat = meat;
            Price = price;
        }
        // Five methods are also needed inside the Hamburger class. 
        // Four for adding up to four additions to the hamburger and one
        // (1) for printing out an itemized listing of the final hamburger with addons, if any, and the total price.

        // Remember that a name and price must be accepted as parameters in the first four methods so that the price of the hamburger is adjusted accordingly. 
        // These methods should be named AddHamburgerAddition1, AddHamburgerAddition2, AddHamburgerAddition3, AddHamburgerAddition4, and ItemizeHamburger. 
        public virtual void AddHamburgerAddition1(string name, double price)
        {
            Console.WriteLine($"+ {name} @ {price} Eur");
            Price += price;
        }
        public virtual void AddHamburgerAddition2(string name, double price)
        {
            Console.WriteLine($"+ {name} @ {price} Eur");
            Price += price;
        }
        public virtual void AddHamburgerAddition3(string name, double price)
        {
            Console.WriteLine($"+ {name} @ {price} Eur");
            Price += price;
        }
        public virtual void AddHamburgerAddition4(string name, double price)
        {
            Console.WriteLine($"+ {name} @ {price} Eur");
            Price += price;
        }
        // The first four methods do not return values, but the last method does return the total price of the hamburger of type double,
        // which includes the base price of the hamburger plus any additional items.
        public virtual void ItemizeHamburger()
        {

            Console.WriteLine($"TOTAL is {Price} Eur");
        }
    }
}
