namespace day7.PizzaDecorator
{
    public class ExtraCheeseDecorator : ToppingDecorator
    {
        public ExtraCheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override decimal CalculatePrice() => pizza.CalculatePrice() + 15m;

        public override string GetDescription() => pizza.GetDescription() + ", extra cheese";
    }
}
