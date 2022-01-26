using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_paskaita_BillsBurgers
{
    public class DeluxeBurger : Hamburger
    {
        // For the second class, DeluxeBurger, there are no additional member variables, and the constructor accepts no parameters.

        public DeluxeBurger()
        {
            // Instead, the constructor creates a deluxe burger with all the fixings and chips and a drink for a base price of $19.10.
            Console.WriteLine("This is DELUXEBURGER");
            Console.WriteLine($"All possible additions are included by default");
        }
            // The constructor can be configured in any way, as long as chips and drink are added for the total price just mentioned.
            // In this class, the four(4) methods defined in the Hamburger class for including additional toppings
            // must each be overridden so that a message is printed stating that no additional items can be added to a deluxe burger.
            public override void AddHamburgerAddition1(string name, double price)
            {
                Console.WriteLine($"Cant add.");
            }
            public override void AddHamburgerAddition2(string name, double price)
            {
                Console.WriteLine($"Cant add.");
            }
            public override void AddHamburgerAddition3(string name, double price)
            {
                Console.WriteLine($"Cant add.");
            }
            public override void AddHamburgerAddition4(string name, double price)
            {
                Console.WriteLine($"Cant add.");
            }
        public void AddChips(string chips, double price)
        {
            Console.WriteLine($"+ {chips} @ {price} Eur");
            Price += price;
        }
        public void AddCoke(string coke, double price)
        {
            Console.WriteLine($"+ {coke} @ {price} Eur");
            Price += price;
        }
        public override void ItemizeHamburger()
        {
            Console.WriteLine($"Coke + Pepsi = {Price} Eur");
            Console.WriteLine($"Deluxe Burger is {Math.Round(19.10d - Price)} Eur");
            Console.WriteLine($"TOTAL: {19.10d}"); // <-- Nesugalvoju lygties. Nesuprantu net ar jos čia reikia.
        }

    }
}

