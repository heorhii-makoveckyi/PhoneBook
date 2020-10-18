using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Model
{
    class CompanyRecord : IRecord
    {
        public string Name { get; set; }
        public string KindOfActivity { get; set; }
        public PersonRecord Owner { get; set; }
        
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
