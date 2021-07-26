namespace Shop.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using ShopCarv.Dato.ModelsDB;

    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productsRepository;

        public ProductsController(IProductRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        // GET: api/<ProductsController>
        [HttpGet]

        public IActionResult GetProducts()
        {
            return Ok(productsRepository.GetAll());
        }


        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ProductsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProductsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
