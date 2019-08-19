namespace WrongAbstraction.DryFailure.Before.Gen0
{
    //let's imagine we inherit a legacy service which "started" like this...
    public class SaltAndPepperService
    {
        public void AddSalt(IDish dish)
        {
            dish.Salt++;
            // first thing to notice: mutation, this method is not thread safe,
            // and not even any method reading from dish.Salt at this point!
            // the answer is not "fixing mutation" by adding Monitor.TryEnter or lock { } construct!!!
            System.Console.WriteLine("we added salt!");
        }

        public void AddPepper(IDish dish)
        {
            dish.Pepper++;
            System.Console.WriteLine("we added salt!");
            // this method was created using copy-paste from the previous one: shame! 
            // we can see it because the comment is still the old one! it happens, really.
            // ctrl-c tarararara ctrl-v! damn : )
        }

        //this method doesn't seem to fit with salt and pepper, nevertheless it adds something to a dish,
        //so the previous dev thought: i will put it here next to AddSalt and AddPepper! makes sense!
        public void AddTopping(IDish dish, Topping topping)
        {
            dish.Topping = topping;
            System.Console.WriteLine($"we added {topping}!");
        }
    }
}
