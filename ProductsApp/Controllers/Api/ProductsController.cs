using Microsoft.AspNetCore.Mvc;
using ProductsApp.Data;
using ProductsApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //2 steps here:   Create the private var and inject the DBcontext in the controller:DM3

        private readonly WProductsDBContext _context;

        public ProductsController(WProductsDBContext context)
        {
            _context = context; 
        }

        //GET : api/GetProducts
      
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var products = from p in _context.Product.Where(s => s.Product_Category == "Personal Care"
                           && s.Product_Name == "Axe Soap")
                           select p;

            return products.ToList();
        }

        //GET: api/<ProductsController>
        //[HttpGet]
        //public IEnumerable<Product> GetProducts()
        //{
        //    // var schools = from s in _context.Product.Where(s => s.Product_Category == "Personal Care")
        //    //              select s;
        //    //return schools.ToList();
        //    // return _context.Product.ToList();
            
        //    //LINQ:
        //    var office = from o in _context.Product
        //                 .Where(o => o.Product_Category == "Personal Care")
        //                 select o;
                                
            
        //    return office.ToList();

        //    //parame.....

        //}


        //[HttpGet]
        //public IEnumerable<Product> GetProducts()
        //{

        //    var top = from l in _context.Product
        //              .Where(l => l.Product_Category == "School Items")
        //              select l;

        //    return top.ToList();
        //}



        // GET: api/<ProductsController>
        // [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ProductsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

       // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

       // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
