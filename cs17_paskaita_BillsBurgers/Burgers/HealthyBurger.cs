using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_paskaita_BillsBurgers
{
    internal class HealthyBurger : Hamburger
    {
        // And for the third class, HealthyBurger, there will be four(4) additional member variables called
        // HealthyExtra1Name, HealthyExtra1Price, 
        public string HealthyExtra1Name { get; set; }
        public double HealthyExtra1Price { get; set; }
        //HealthyExtra2Name, and HealthyExtra2Price.
        public string HealthyExtra2Name { get; set; }
        public double HealthyExtra2Price { get; set; }

        public HealthyBurger(string meat, double price,
            string healthyExtra1Name = "", double healthyExtra1Price = 0d,
            string healthyExtra2Name = "", double healthyExtra2Price = 0d) : base (meat, price)
        {
            HealthyExtra1Name = healthyExtra1Name;
            HealthyExtra1Price = healthyExtra1Price;
            HealthyExtra2Name = healthyExtra2Name;
            HealthyExtra2Price = healthyExtra2Price;
            Console.WriteLine($"HealthyBurger: w/ {Meat} @ {Price} Eur");
        }
        // The names are type String and the prices are type double. 
        // The constructor for this class accepts two(2) parameters for meat and price.
        // Those are set in the constructor along with an appropriate name for the type of burger.

        // Two methods, AddHealthyAddition1 and AddHealthyAddition2 should be created that each accept a name and price
        // for the addition, allowing for up to two(2) addons to the basic healthy burger.
        public void AddHealthyAddition1(string name, double price)
        {
            Console.WriteLine($"+ ECO(!) {name} @ {price} Eur");
            Price += price;
        }
        public void AddHealthyAddition2(string name, double price)
        {
            Console.WriteLine($"+ ECO(!) {name} @ {price} Eur");
            Price += price;
        }

        // And finally the ItemizeHamburger method created in the Hamburger class should be overridden
        // to generate a message appropriate to the type of burger along with any addons.
        // The method also returns the total price of the healthy burger of type double.
        public override void ItemizeHamburger()
        {
            Console.WriteLine($"TOTAL: {Price} Eur");
        }
    }
}
