using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Obras.Bibliograficas.Alessandro.Domain;
using Obras.Bibliograficas.Alessandro.Domain.Autores;

namespace Obras.Bibliograficas.Alessandro.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AutorController : ControllerBase
	{
		IAutorService _service;

		public AutorController(IAutorService service)
		{
			_service = service;
		}

		// GET api/autores
		[HttpGet]
		public ActionResult<IEnumerable<Autor>> Get()
		{
			return _service.Listar();
		}

		// GET api/autores/5
		//[HttpGet("{id}")]
		//public ActionResult<Autor> Get(int id)
		//{
		//	return _service.Buscar(id);
		//}

		// POST api/autores
		[HttpPost]
		public ActionResult Post([FromBody] Autor anuncio)
		{
			if (ModelState.IsValid)
			{
				_service.Cadastrar(anuncio);
				return Ok();
			}
			else
			{
				return BadRequest(ModelState);
			};
		}

		// PUT api/autores/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromBody] Autor anuncio)
		{
			if (ModelState.IsValid)
			{
				_service.Alterar(anuncio);
				return Ok(anuncio);
			}
			else
			{
				return BadRequest(ModelState);
			};
		}

		// DELETE api/autores/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			_service.Remover(new Autor { Id = id });
			return Ok();
		}
	}
}