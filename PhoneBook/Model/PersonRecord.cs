using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace PhoneBook.Model
{
    class PersonRecord : IRecord
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        private CompanyRecord CompanyRecord { get; set; }
        public PersonRecord(string fullName, string gender, string phoneNumber, string email, CompanyRecord companyRecord)
        {
            Name = fullName;
            Gender = gender;
            CompanyRecord = companyRecord;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public string[] GetExpandedInfo() =>
            new[] { Name, PhoneNumber, Email, Gender, CompanyRecord.Name };
        public string[] GetGridInfo() =>
            new[] {Name, PhoneNumber, Email, CompanyRecord.Name};
        public bool IsAllowByFilter(Dictionary<FilterType, string> filters)
        {
            throw new NotImplementedException();
        }
    }
}
