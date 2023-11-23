using CsvHelper.Configuration.Attributes;

namespace CSVReader.Model
{
    public class Address
    {
        [Index(0)]
        public string? Nome { get; set; }

        [Index(1)]
        public string? Sobrenome { get; set; }

        [Index(2)]
        public string? Rua { get; set; }

        [Index(3)]
        public string? Cidade { get; set; }

        [Index(4)]
        public string? Estado { get; set; }

        [Index(5)]
        public string? Numero { get; set; }
    }
}
