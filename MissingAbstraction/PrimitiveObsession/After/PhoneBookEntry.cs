using System.Text.RegularExpressions;

namespace MissingAbstraction.PrimitiveObsession.After
{
    public class PhoneBookEntry : IPhoneBookEntry
    {
        private PhoneBookEntry(string phoneBookEntry)
        {
            Entry = phoneBookEntry;
        }

        public string Entry { get; }

        public static IPhoneBookEntry Get(string phoneBookEntry)
        {
            return IsValidEntry(phoneBookEntry) ? 
                new PhoneBookEntry(phoneBookEntry) : new InvalidPhoneBookEntry() as IPhoneBookEntry;
        }

        private static bool IsValidEntry(string unvalidatedPhoneBookEntry)
        {
            return unvalidatedPhoneBookEntry != null 
                && Regex.IsMatch(unvalidatedPhoneBookEntry, @"\+\d\d\s\d\d\d-\d\d-\d\d-\d\d");
        }
    }
}
