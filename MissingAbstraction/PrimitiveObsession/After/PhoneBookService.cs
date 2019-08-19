using System.Collections.Generic;

namespace MissingAbstraction.PrimitiveObsession.After
{

    public class PhoneBookService
    {
        private readonly Dictionary<int,string> database;
        private PhoneBookService()
        {
            database = new Dictionary<int,string>();
        }
        public PhoneBookService(Dictionary<int,string> database)
        {
            this.database = database;
        }

        public int AddEntry(PhoneBookEntry validatedPhoneBookEntry)
        {
            int id = database.Count;
            database.Add(id, validatedPhoneBookEntry.Entry);
            return id;
            // we know is valid!
            // because the object PhoneBookEntry only has a private constructor!
            // accessed via it's static creational factory method which also validates its arguments!
        }

        public IPhoneBookEntry GetPhoneBook(int id)
        {
            var unvalidatedEntry = database[id]; //e.g. "+39 122-34-56-78"
            return PhoneBookEntry.Get(unvalidatedEntry); //from db
            // if db has a null or invalid entry, we will get an InvalidPhoneBookEntry object!
            // that we cannot add back or perform any valid phone book entry operation on it!
            // that's type safety!!!
        }
    }
}
