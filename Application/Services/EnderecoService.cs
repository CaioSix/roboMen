using Application.Adapters;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(List<EnderecoModel> enderecos)
        {
            var domains = EnderecoAdapter.Map(enderecos);
            await _repository.Add(domains);
        }

        public Task AtualizarDados(EnderecoModel endereco)
        {
            throw new NotImplementedException();
        }

        public Task<List<EnderecoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoModel> ObterCepParaTratamento(string roboo)
        {
            throw new NotImplementedException();
        }
    }
}
