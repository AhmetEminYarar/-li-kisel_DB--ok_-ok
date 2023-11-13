using Cok_Cok_İliskisel_Db.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using Cok_Cok_İliskisel_Db.Requests;
using Cok_Cok_İliskisel_Db.MainEntity;
using Cok_Cok_İliskisel_Db.Entity;

namespace Cok_Cok_İliskisel_Db.Controllers
{
    [ApiController]
    [Route("Main")]
    public class MainController : ControllerBase
    {
        private readonly AppDbContext _appdbcontext;

        public MainController(AppDbContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        [HttpGet("Main/Person")]
        public async Task<IActionResult> PersonGet()
        {
            var list = await _appdbcontext.People.Include(a => a.names).Include(b => b.Surnames).Include(c => c.Ages).AsNoTracking().ToListAsync();

              JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
              {
                  ReferenceHandler = ReferenceHandler.IgnoreCycles,
                  WriteIndented = true,
              };
            return Ok(JsonSerializer.Serialize(list,jsonSerializerOptions));
        }
        [HttpPost("/Name")]
        public async Task<IActionResult> NamePost([FromBody] NameRequest request)
        {
            Name name = new Name()
            {
                Names = request.Names,
                PersonId = request.PersonId,
            };
            var add = await _appdbcontext.names.AddAsync(name);
            await _appdbcontext.SaveChangesAsync();
            return Ok("Ekelendi");
        }
        [HttpPost("/SurName")]
        public async Task<IActionResult> SurNamePost([FromBody] SurNameRequest request)
        {
            SurName surname = new SurName()
            {
                SurNames=request.SurNames,
                PersonId = request.PersonId,
            };
            var add = await _appdbcontext.Surnames.AddAsync(surname);
            await _appdbcontext.SaveChangesAsync();
            return Ok("Ekelendi");
        }
        [HttpPost("/Age")]
        public async Task<IActionResult> AgePost([FromBody] AgeRequest request)
        {
            Age age = new Age()
            {
                Ages=request.Ages,
                PersonId = request.PersonId,
            };
            var add = await _appdbcontext.Ages.AddAsync(age);
            await _appdbcontext.SaveChangesAsync();
            return Ok("Ekelendi");
        }
    }
}
