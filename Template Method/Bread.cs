using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    abstract class Bread
    {
        public abstract void Mixlngredients();
        public abstract void Bake();
        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + "bread!");
        }
        public void Make()
        {
            Mixlngredients();
            Bake();
            Slice();
        }
    }
    class TwelveGrain : Bread
    {
        public override void Mixlngredients()
        {
            Console.WriteLine("Gathering Ingredients for 12-Grain Bread.");
        }
        public override void Bake()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
        }
    }
    class Sourdough : Bread
    {
        public override void Mixlngredients()
        {
            Console.WriteLine("Gathering Ingredients for Sourdough Bread.");
        }
        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdough Bread. (20 minutes)");
        }
    }
    class WholeWheat : Bread
    {
        public override void Mixlngredients()
        {
            Console.WriteLine("Gathering Ingredients for Whole Wheat Bread.");
        }
        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
        }
    }
}
