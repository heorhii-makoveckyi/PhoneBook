using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Model
{
    interface IRecord
    {
        public Dictionary<string, string> GetExpandedInfo();
        public string[] GetGridInfo();
        public bool IsAllowByFilter(FilterType filterType, string filter);
    }
}
