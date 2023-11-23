using CsvHelper.Configuration;

namespace CSVReader.Model.Mappers
{
    public class AddressMapper : ClassMap<Address>
    {
        public AddressMapper()
        {
            Map(f => f.Nome).Index(0);
            Map(f => f.Sobrenome).Index(1);
            Map(f => f.Rua).Index(2);
            Map(f => f.Cidade).Index(3);
            Map(f => f.Estado).Index(4);
            Map(f => f.Numero).Index(5);
        }
    }
}
