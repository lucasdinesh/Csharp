using System.Collections.Generic;
using DemoWsTemplateV1.Models;

namespace DemoWsTemplateV1.Services
{
    public interface ICepService
    {
        IEnumerable<ConsultaCep> ConsultaTodos();

        ConsultaCep ConsultaPorCep(string cep);

        void Cadastrar(ConsultaCep cep);
    }
}