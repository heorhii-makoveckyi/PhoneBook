using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Model
{
    interface IRecord
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string[] GetExpandedInfo();
        string[] GetGridInfo();
        bool IsAllowByFilter(Dictionary<FilterType, string> filters);
    }
}
