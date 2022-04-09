using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly DataContext _context;
        public WorkerController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Worker>>> Get()
        {

            return Ok(await _context.Workers.ToListAsync());
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Worker>> Get(int id)
        {
            var ekspozitura = await _context.Workers.FindAsync(id);
            if (ekspozitura == null)
                return BadRequest("Ekspozitura not found.");
            return Ok(ekspozitura);
        }

        [HttpPost]

        public async Task<ActionResult<List<Worker>>> AddClient(Client ekspozitura)
        {
            _context.Clients.Add(ekspozitura);
            await _context.SaveChangesAsync();

            return Ok(await _context.Workers.ToListAsync());
        }
        [HttpPut]

        public async Task<ActionResult<List<Worker>>> UpdateWorker(Client request)
        {
            var ekspozitura = await _context.Workers.FindAsync(request.Id);
            if (ekspozitura == null)
                return BadRequest("Ekspozitura not found.");

            ekspozitura.Id = request.Id;
            ekspozitura.JMBG = request.JMBG;
            ekspozitura.FirstName = request.FirstName;
            ekspozitura.JMBG = request.JMBG;
            ekspozitura.FirstName = request.FirstName;
            ekspozitura.LastName = request.LastName;
            ekspozitura.ParentName = request.ParentName;
            ekspozitura.Address = request.Address;
            ekspozitura.PhoneNumbers = request.PhoneNumbers;
            ekspozitura.EmailAddresses = request.EmailAddresses;
            ekspozitura.Role = request.Role;
            ekspozitura.HiredFromDate = request.HiredFromDate;
            ekspozitura.HiredUntilDate = request.HiredUntilDate;
            ekspozitura.ExpoId = request.ExpoId;
            ekspozitura.Expo = request.Expo;
            ekspozitura.IsExpoChief = request.IsExpoChief;

            await _context.SaveChangesAsync();

            return Ok(await _context.Workers.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Worker>>> Delete(int id)
        {
            var ekspozitura = await _context.Workers.FindAsync(id);
            if (ekspozitura == null)
                return BadRequest("Ekspozitura not found.");

            _context.Workers.Remove(ekspozitura);
            await _context.SaveChangesAsync();

            return Ok(await _context.Workers.ToListAsync());
        }

    }
}
