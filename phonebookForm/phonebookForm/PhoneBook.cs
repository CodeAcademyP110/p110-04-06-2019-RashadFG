using System.Collections.Generic;

namespace phonebookForm
{
    public class PhoneBook
    {
        public static List<PhoneBook> _book = new List<PhoneBook>();
        public static List<internationalCode> _Code ;

        public string Name { get; set; }
        public string Number { get; set; }
        static PhoneBook()
        {
            _Code = new List<internationalCode>()
            {
                new internationalCode{ Code="+99455" },
                new internationalCode{ Code="+99450" },
                new internationalCode{ Code="+99451" },
                new internationalCode{ Code="+99470" },
                new internationalCode{ Code="+99477" },
                new internationalCode{ Code="+99460" },
                new internationalCode{ Code="+99412" },
            };
        }
        public static List<PhoneBook> GetMembers()
        {
            return _book;
        }
        public static void AddMembers(PhoneBook phbk)
        {
            _book.Add(phbk);
        }
        public static List<internationalCode> GetinternationalCode()
        {
            return _Code;
        }
    }
    public class internationalCode
    {
        public string Code { get; set; }
    }

}
