using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LanchesMac.Repositories.Interfaces
{
    public class BebidaRepository : IBebidaRepository
    {
        private readonly AppDbContext _context;

        public BebidaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bebida> Bebidas => _context.Bebidas.Include(categoria => categoria.Categoria);
        public IEnumerable<Bebida> BebidasPreferidas => _context.Bebidas
                                   .Where(bebida => bebida.IsBebidaPreferida)
                                   .Include(categoria => categoria.Categoria);

        public Bebida GetBebidaById(int bebidaId) => _context.Bebidas.
                                                     FirstOrDefault(bebida =>
                                                     bebida.BebidaId == bebidaId);
    }
}
