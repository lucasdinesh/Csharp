using System.Collections.Concurrent;
using System.Collections.Generic;
using DemoWsTemplateV1.Models;



namespace DemoWsTemplateV1.Services
{

    public class CepMemoriaServices : ICepService
    {

        private readonly ConcurrentDictionary<string, ConsultaCep> _dados = new ConcurrentDictionary<string, ConsultaCep>();
        public ConsultaCep ConsultaPorCep(string cep)
        {
            ConsultaCep response;
            _dados.TryGetValue(cep, out response);
            return response;
        }

        public IEnumerable<ConsultaCep> ConsultaTodos()
        {
            return _dados.Values;
        }

        public CepMemoriaServices()
        {
         _dados.TryAdd("90619900", new ConsultaCep{
             Logradouro = " Avenida Ipiranga, 6681",
             Bairro = "Partenon",
             Cidade = "Porto Alegre",
             Estado = "RS",
             Cep = "90619900"
         });
          _dados.TryAdd("90160180", new ConsultaCep{
             Logradouro = " Avenida Erico Verissimo",
             Bairro = "Menino Deus",
             Cidade = "Porto Alegre",
             Estado = "RS",
             Cep = "90160180"
         });    
        }
    }
}