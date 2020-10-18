using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook.Model
{
    class Directory
    {
        private readonly List<IRecord> _records;
        public Directory(IEnumerable<IRecord> records)
        {
            _records = new List<IRecord>(records);
        }
        public void RemoveRecord(int id) => _records.RemoveAt(id);
        public void AddRecord(IRecord record) => _records.Add(record);
        public string[] ExpandedRecord(Index id) =>
            _records[id].GetExpandedInfo();
        public List<string[]> GetGridInfo() =>
            _records.Select(record => record.GetGridInfo()).ToList();
        public List<string[]> GetGridInfo(Dictionary<FilterType, string> filters) => 
            (from record in _records where record.IsAllowByFilter(filters) select record.GetGridInfo()).ToList();
        
    }
}
