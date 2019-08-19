namespace MissingAbstraction.PublicBoolProperty.Before
{
    public class Car : ITransport
    {
        public bool CanFly => false; 

        //why do we have to specify a car cannot fly? 
        //seems weird
        //maybe something in the OO abstraction is wrong ? 

        public void Move() { }
    }
}
