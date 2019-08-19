using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MissingAbstraction.PrimitiveObsession.Before
{
    public class PhoneBookService
    {
        private readonly Dictionary<int,string> database;

        private PhoneBookService()
        {
            database = new Dictionary<int,string>();
        }

        // again we should notice something here: booleans! 
        // a warning that implies we might not be using our typesystem at its 100% (in this case)
        public bool ValidateEntry(string unvalidatedPhoneBookEntry)
        {
            return unvalidatedPhoneBookEntry != null 
                && Regex.IsMatch(unvalidatedPhoneBookEntry, @"\+\d\d\s\d\d\d-\d\d-\d\d-\d\d");
        }

        public int AddEntry(string unvalidatedPhoneBookEntry)
        {
            if (!ValidateEntry(unvalidatedPhoneBookEntry)) //if --> unit test
            {
                throw new ArgumentException(nameof(unvalidatedPhoneBookEntry));
            }
            
            return AddPhoneBook(unvalidatedPhoneBookEntry);
        }

        private int AddPhoneBook(string validPhoneBookEntry)
        {
            int id = database.Count;
            database.Add(id, validPhoneBookEntry);
            return id;
        }

        public string GetPhoneBook(string id)
        {
            return "+39 122-34-56-78"; //from db --> no validation! what if db returns null or corrupted data?
        }
    }
}
