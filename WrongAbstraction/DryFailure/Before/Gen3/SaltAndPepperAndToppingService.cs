namespace WrongAbstraction.DryFailure.Before.Gen3
{
    public abstract class SaltAndPepperAndToppingService
    {
        // genius dev, seeing the switch statement, 
        // and the salt and pepper methods being the same,
        // promptly recognizes opportunity for DRY principle (muaah)
        public void Add(IDish dish, Topping? optionalTopping = null)
        {
            AddSpecific(dish, optionalTopping);
            System.Console.WriteLine($"we added {SpecificAddition}");
        }

        protected abstract void AddSpecific(IDish dish, Topping? optionalTopping = null);

        public abstract string SpecificAddition { get; }
    }
}
