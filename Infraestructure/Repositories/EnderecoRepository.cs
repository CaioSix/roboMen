using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.BulkExtensions;

namespace Infraestructure.Repositories
{
    internal class EnderecoRepository : IEnderecoRepository
    {

        private readonly SixXDbContext _context;

        public EnderecoRepository(SixXDbContext context)
        {
            _context = context;
        }

        public async Task Add(List<Endereco> enderecos)
        {
            await _context.BulkInsertAsync(enderecos);
        }

        public async Task AtualizarDados(Endereco endereco)
        {
            _context.Enderecos.Update(endereco);
            await _context.AddRangeAsync();
        }

        public async Task<Endereco?> Get(int id)
        {
            return _context.Enderecos.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<List<Endereco>> List()
        {
            return _context.Enderecos.ToList();
        }

        public async Task<Endereco?> ObterCepParaTratamento(string roboo)
        {
            var ceps = _context.Enderecos.Where(
                x =>
                (x.Status == Domain.Enums.EnumStatus.EmAndamento && x.Robo == roboo)
                ||
                (x.Status == Domain.Enums.EnumStatus.Aberto && string.IsNullOrEmpty(x.Robo))

            ).FirstOrDefault();

            return cep;

        }
    }
}
