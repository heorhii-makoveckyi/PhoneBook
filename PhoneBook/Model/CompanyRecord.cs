using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Model
{
    class CompanyRecord : IRecord
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string KindOfActivity { get; set; }
        public PersonRecord Owner { get; set; }

        public string[] GetExpandedInfo()
        {
            throw new NotImplementedException();
        }
        public string[] GetGridInfo()
        {
            throw new NotImplementedException();
        }
        public bool IsAllowByFilter(Dictionary<FilterType, string> filters)
        {
            throw new NotImplementedException();
        }
    }
}
