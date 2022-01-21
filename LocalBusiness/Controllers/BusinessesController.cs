using LocalBusiness.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly LocalBusinessContext _db;

    public BusinessesController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string name, string city, string county, string type, string category, int price, int rating, string sortBy_asc, string sortBy_dsc, string sortBy_most)
    {
      var query = _db.Businesses.AsQueryable();
      var queryTwo = _db.Businesses;
      
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if ( city != null)
      {
        query = query.Where(entry => entry.City == city);
      }
      if (county != null)
      {
        query = query.Where(entry => entry.County == county);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }
      if (price != 0)
      {
        query = query.Where(entry => entry.Price == price);
      }
      if (rating != 0 )
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      if (sortBy_asc != null)
      {
        if (sortBy_asc == "name")
        {
          query = query.OrderBy(entry => entry.Name);
        }  
        if (sortBy_asc == "city")
        {
          query = query.OrderBy(entry => entry.City);
        }
        if (sortBy_asc == "county")
        {
          query = query.OrderBy(entry => entry.City);
        }
        if (sortBy_asc == "type")
        {
          query = query.OrderBy(entry => entry.Type);
        }
        if (sortBy_asc == "category")
        {
          query = query.OrderBy(entry => entry.Category);
        }
        if (sortBy_asc == "county")
        {
          query = query.OrderBy(entry => entry.County);
        }
        if (sortBy_asc == "price")
        {
          query = query.OrderBy(entry => entry.Price);
        }
        if (sortBy_asc == "rating")
        {
          query = query.OrderBy(entry => entry.Rating);
        }
      }


      if (sortBy_dsc != null)
      {
        if (sortBy_dsc == "name")
        {
          query = query.OrderByDescending(entry => entry.Name);
        }
        if (sortBy_dsc == "city")
        {
          query = query.OrderByDescending(entry => entry.City);
        }
        if (sortBy_dsc == "county")
        {
          query = query.OrderByDescending(entry => entry.City);
        }
        if (sortBy_dsc == "type")
        {
          query = query.OrderByDescending(entry => entry.Type);
        }
        if (sortBy_dsc == "category")
        {
          query = query.OrderBy(entry => entry.Category);
        }
        if (sortBy_dsc == "county")
        {
          query = query.OrderByDescending(entry => entry.County);
        }
        if (sortBy_dsc == "price")
        {
          query = query.OrderByDescending(entry => entry.Price);
        }
        if (sortBy_dsc == "rating")
        {
          query = query.OrderByDescending(entry => entry.Rating);
        }
      }


      // ***WIP IN PROGRESS***
      // if (sortBy_most != null)
      // {
      //   var queryList = query.ToList();
      //   if (sortBy_most == "city")
      //   {
      //     var test = query.GroupBy(find => find.City).OrderByDescending(g => g.Count()).Take(5).Select(g => g.Key).ToList();
      //     List<Business> testMe = test.Cast<Business>().ToList();
      //     foreach (string element in test)
      //     {
      //       Business testing = element;
      //     }
      //     query = testMe;
      //   }
      // }
      
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }
      return business;
    }

    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId}, business);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Business>> Put(Business business, int id)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      _db.Entry(business).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(find => find.BusinessId == id);
    }
  }
}