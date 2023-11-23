using CsvHelper.Configuration;
using CsvHelper;
using CSVReader.Interfaces;
using CSVReader.Model;
using System.Globalization;
using CSVReader.Model.Mappers;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace CSVReader.Services
{
    public class CSVReaderService : ICSVReaderService
    {
        public IEnumerable<Address> readCsv()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, MissingFieldFound = null, BadDataFound = null };
            var reader = new StreamReader("C:/Users/daniel.medina/Projetos/Projetos Teste/CSVReader/CSVReader/addresses.csv");
            var csv = new CsvReader(reader, config);

            csv.Context.RegisterClassMap<AddressMapper>();
            List<Address> addresses = new();

            var records = csv.GetRecords<Address>();

            foreach (var record in records)
            {
                addresses.Add(record);
            }

            return addresses;
        }
    }
}
