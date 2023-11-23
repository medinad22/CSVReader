using CSVReader.Interfaces;
using CSVReader.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSVReader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSVReaderController : ControllerBase
    {

        private readonly ICSVReaderService _csvReaderService;

        public CSVReaderController(ICSVReaderService csvReaderService)
        {
            _csvReaderService = csvReaderService;
        }

        [HttpGet(Name = "GetCSVData")]
        public IEnumerable<Address> Get()
        {
            return _csvReaderService.readCsv();
        }
    }
}
