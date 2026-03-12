namespace day7.PizzaDecorator
{
    public class BaconDecorator : ToppingDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override decimal CalculatePrice() => pizza.CalculatePrice() + 15m;

        public override string GetDescription() => pizza.GetDescription() + ", bacon";
    }
}
