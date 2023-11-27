using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using System.Collections.Generic;

namespace LanchesMac.Repositories
{
    public class BebidaRepository : IBebidaRepository
    {
        private readonly AppDbContext _context;

        public BebidaRepository(AppDbContext context)
        {
            _context = context;
        }



        public IEnumerable<Bebida> Bebidas => throw new NotImplementedException();

        public IEnumerable<Bebida> BebidasPreferidas => throw new NotImplementedException();

        public Bebida GetLancheById(int bebidaId)
        {
            throw new NotImplementedException();
        }
    }
}
