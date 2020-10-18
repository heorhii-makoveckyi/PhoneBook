using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Model
{
    class PersonRecord : IRecord
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public CompanyRecord CompanyRecord { get; set; }

        public Dictionary<string, string> GetExpandedInfo()
        {
            throw new NotImplementedException();
        }

        public string[] GetGridInfo()
        {
            throw new NotImplementedException();
        }

        public bool IsAllowByFilter(FilterType filterType, string filter)
        {
            throw new NotImplementedException();
        }
    }
}
