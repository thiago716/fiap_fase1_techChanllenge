using Application.Service.Interface;
using Application.ViewModel;
using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebApi.Extensions;

namespace WebApi.Controllers;
[Route("api/v1/contacts")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;
    private readonly IMemoryCache _cache;

    public ContactController(IContactService contactService, IMemoryCache cache)
    {
        _contactService = contactService;
        _cache = cache;
    }

    [HttpGet]
    public async Task<ActionResult<List<Contact>>> GetAllAsync()
    {
        try
        {
            var contacts = await _contactService.GetAllAsync();

            return Ok(new ResultViewModel<IList<Contact>>(contacts));
        }
        catch (SystemException)
        {
            // 01X01 é um código único qualquer que facilita identificar onde o erro foi gerado (Uma boa prática)
            return StatusCode(500, new ResultViewModel<IList<Contact>>("01X01 - Internal server error")); 
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Contact>> GetByIdAsync(int id)
    {
        try
        {
            var contact = await _contactService.GetByIdAsync(id);

            if (contact is null)
                return NoContent();

            return Ok(new ResultViewModel<Contact>(contact));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<Contact>("01X02- Internal server error"));
        }
    }

    [HttpGet("ddd-code/{id:int}")]
    public async Task<ActionResult<List<Contact>>> GetAllByDddAsync(int id)
    {
        try
        {
            var cacheKey = $"ContactsByDDDCodeCache_{id}";
            
            var contacts = await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5);
                return await _contactService.GetAllByDddAsync(id);
            });
                        
            return Ok(new ResultViewModel<IList<Contact>>(contacts));
        }
        catch (ArgumentException)
        {
            return BadRequest(new ResultViewModel<Contact>("01X03 - Invalid direct distance dialing code"));
        }
        catch (Exception)
        {
            return StatusCode(500, new ResultViewModel<Contact>("01X04- Internal server error"));
        }
    }

    [HttpPost()]
    public async Task<IActionResult> PostAsync([FromBody] ContactViewModel model)
    {
        try
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(new ResultViewModel<Contact>(ModelState.GetErrors()));
            }

            var contact = new Contact
            {
                Name = model.Name,
                Phone = model.Phone,
                Email = model.Email,
                DddId = model.DddId,
            };

            await _contactService.CreateAsync(contact);

            return Created($"api/v1/contacts/{contact.Id}", new ResultViewModel<Contact>(contact));
        }
        catch (Exception)
        {
            return StatusCode(500, new ResultViewModel<Contact>("01X05 - Internal server error"));
        }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody] ContactViewModel model)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResultViewModel<Contact>(ModelState.GetErrors()));
            }

            var contact = await _contactService.GetByIdAsync(id);
            
            if (contact is null)
                return BadRequest(new ResultViewModel<Contact>("01X06 - Invalid contact id"));

            contact.Name = model.Name;
            contact.Phone = model.Phone;
            contact.Email = model.Email;
            contact.DddId = model.DddId;

            await _contactService.EditAsync(contact);
                        
            return Ok(new ResultViewModel<Contact>(contact));
        }
        catch (Exception)
        {
            return StatusCode(500, new ResultViewModel<Contact>("01X07 - Internal server error"));
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] int id)
    {
        try
        {
            var contact = await _contactService.GetByIdAsync(id);

            if (contact is null)
                return BadRequest(new ResultViewModel<Contact>("01X08 - Invalid contact id"));

            await _contactService.DeleteAsync(contact);

            return NoContent();
        }
        catch (Exception)
        {
            return StatusCode(500, new ResultViewModel<Contact>("01X09 - Internal server error"));
        }
    }
}
