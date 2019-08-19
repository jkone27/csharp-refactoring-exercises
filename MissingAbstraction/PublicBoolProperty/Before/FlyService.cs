namespace MissingAbstraction.PublicBoolProperty.Before
{
    public class FlyService
    {
        public void Fly(ITransport transport)
        {
            if (transport.CanFly) // if --> unit test!
            {
                transport.Move();
            }
            else
            {
                throw new System.Exception("this transport cannot fly!"); 
                //mmmmm... we don't love exceptions, do we?
                // throw --> unit test!
            }
        }
    }
}
