using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestShop.Dto.Requset;
using TestShop.Dto.Response;
using TestShop.Moduls;
using TestShop.Service;

namespace TestShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductController(IProduct product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        [Route("all")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<IEnumerable<ProductResponse>>(_product.GetProducts()));
        }

        // GET
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok(_mapper.Map<ProductResponse>(_product.GetProduct(id)));
        }

        // Post
        [HttpPost]
        [Route("add")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Add([FromBody] ProductRequset product)
        {
            _product.AddProduct(_mapper.Map<Product>(product));
        }
    }
}