namespace day7.PizzaDecorator
{
    public class PepperoniDecorator : ToppingDecorator
    {
        public PepperoniDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override decimal CalculatePrice() => pizza.CalculatePrice() + 15m;

        public override string GetDescription() => pizza.GetDescription() + ", pepperoni";
    }
}
