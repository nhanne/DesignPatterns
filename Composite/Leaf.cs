namespace Composite
{
    public class VanillaCola : SoftDrink 
    {
        public VanillaCola(int calaries) : base(calaries) { }
    }
    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base(calories) { }
    }
    public class StrawberryRootBeer : SoftDrink
    {
        public StrawberryRootBeer(int calories) : base(calories) { }
    }
    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories) : base(calories) { }
    }
    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories) : base(calories) { }
    }
    // Composite
    public class Cola : SoftDrink
    {
        public Cola(int calories) : base(calories) { }
    }
    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }
    public class SodaWater : SoftDrink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}
