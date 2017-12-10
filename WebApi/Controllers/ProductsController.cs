using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts() {
            return products;
        }

        public IHttpActionResult GetProduct(int id) {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPut]
        public IHttpActionResult Put(int id,Product pr) {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null) {
                return NotFound();
            }
            product.Category = pr.Category;
            product.Name = pr.Name;
            product.Price = pr.Price;
            //Save to db -- pracujemy na referencji 
            return Ok(product);
        }

        [HttpPost]
        public IHttpActionResult Post(Product pr) {
            int nextid = products.Max(
                (p) => p.Id) +1;
            pr.Id = nextid;
            products.Add(pr);
            return Ok(pr);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id) {
            var product = 
                products.FirstOrDefault(
                    (p) => p.Id == id);
            if (product == null) {
                return NotFound();
            }
            products.Remove(product);
            return Ok(product);
        }

    }
}

