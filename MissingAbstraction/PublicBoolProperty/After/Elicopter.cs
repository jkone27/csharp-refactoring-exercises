namespace MissingAbstraction.PublicBoolProperty.After
{
    public class Elicopter : ITransport
    {
        public bool CanFly => true;

        public void Move() { }
    }
}
