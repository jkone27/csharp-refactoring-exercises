namespace MissingAbstraction.PublicBoolProperty.After
{
    public class FlyService
    {
        // the invariant is constrained by the signature -> polymorphic behaviour
        // the if disappears!
        public void Fly(IFlyable transport) 
        {
            transport.Move();
            System.Console.WriteLine("you are flying, bitch!");
        }
    }
}
