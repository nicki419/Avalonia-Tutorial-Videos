using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Project.GUI.Models
{
    public class CSVHelperModel
    {
        public struct Data {
            [Name("first name")]
            public string FirstName { get; set; }

            [Name("last name")]
            public string LastName { get; set; }

            [Name("date of birth")]
            [Format("dd.MM.yyyy")]
            public DateTime DateOfBirth { get; set; }

            [Name("country")]
            public string Country { get; set; }
        }
    
        private string SourcePath;
        public CSVHelperModel(string sourcePath) {
            SourcePath = sourcePath;
        }

        public List<Data> GetData() {
            List<Data> data = new List<Data>();
            using(var reader = new StreamReader(SourcePath))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {
                var records = csv.GetRecords<Data>();
                foreach (var record in records) {
                    data.Add(record);
                }
                return data;
            }
        }
    }
}