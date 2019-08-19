namespace MissingAbstraction.PrimitiveObsession.After
{
    public class InvalidPhoneBookEntry : IPhoneBookEntry
    {
        //is not a valid phone book entry! NullObject pattern!
        //avoids exception or (worse) returning nulls
    }
}
