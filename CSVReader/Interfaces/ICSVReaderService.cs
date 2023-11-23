using CSVReader.Model;

namespace CSVReader.Interfaces
{
    public interface ICSVReaderService
    {
        IEnumerable<Address> readCsv();
    }
}
