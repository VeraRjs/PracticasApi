using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cooldos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<Articulo> Articulos { get; set; } = new List<Articulo>() { };

        // GET api/values
        [HttpGet]

        public ActionResult<List<Articulo>> Get()
        {
            return Articulos;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Articulo> Get(int id)
        {
            for (int i = 0; i < Articulos.Count - 1; i++)
            {

                if (Articulos[i].Id == id)
                {

                    return Articulos[i];

                }

            }

            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Articulo value)
        {
            int maxId = 1;

            if (Articulos.Count != 0)
            {
                maxId = Articulos[Articulos.Count - 1].Id + 1;
            }

            value.Id = maxId;

            Articulos.Add(value);
            //if (this.Articulos){}

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Articulo value)
        {
            for (int i = 0; i < Articulos.Count; i++)
            {
                int idAux;
                if (Articulos[i].Id == id)
                {
                    idAux = Articulos[i].Id;
                    Articulos[i] = value;
                    Articulos[i].Id = idAux;
                    return Ok();

                }
            }
            return NotFound();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            for (int i = 0; i < Articulos.Count - 1; i++)
            {

                if (Articulos[i].Id == id)
                {

                    Articulos.RemoveAt(id);

                }
            }

        }
    }

}