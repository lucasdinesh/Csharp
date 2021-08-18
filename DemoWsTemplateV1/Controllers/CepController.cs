using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoWsTemplateV1.Models;
using DemoWsTemplateV1.Services;

namespace DemoWsTemplateV1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        private readonly ILogger<CepController> _logger;

        private readonly ICepService _cepService;

        public CepController(ILogger<CepController> logger, ICepService cepService)
        {
            _logger = logger;
            _cepService = cepService;
        }


        //GET /cep/01316461
        [HttpGet("{cep:regex(^\\d{{8}}$}")]

        public ActionResult<ConsultaCep> ConsultaCep(string cep)
        {
            _logger.LogInformation($"ConsultaCep:{cep}");
            var response = _cepService.ConsultaPorCep(cep);
            if(response == null)
            {
                return NotFound();
            }
            return response;
        
        }


        //GET /cep
        [HttpGet]

        public IEnumerable<ConsultaCep> ConsultaCeps()
        {
            _logger.LogInformation("ConsultaCeps");
            return _cepService.ConsultaTodos().
            OrderBy(c => c.Estado).
            ThenBy(c => c.Cidade);
        }

        //POST /cep

        [HttpPost]

        public ActionResult<ConsultaCep> CadastrarCep(ConsultaCep novoCep)
        {
            _logger.LogInformation($"CadastrarCep: {novoCep}");
            var existente = _cepService.ConsultaPorCep(novoCep.Cep);
            if (existente != null)
            {
                return BadRequest();
            }
            _cepService.Cadastrar(novoCep);
            return Created(); 
        }

    }
}
