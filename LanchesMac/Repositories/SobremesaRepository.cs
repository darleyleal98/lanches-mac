using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LanchesMac.Repositories
{
    public class SobremesaRepository : ISobremesaRepository
    {
        private readonly AppDbContext _context;

        public SobremesaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Sobremesa> Sobremesas => _context.Sobremesas.Include(categoria => categoria.Categoria);
        public IEnumerable<Sobremesa> LanchesPreferidos => _context.Sobremesas
                                   .Where(lanche => lanche.IsLanchePreferido)
                                   .Include(categoria => categoria.Categoria);

        public Lanche GetLancheById(int lancheId) => _context.Lanches.
                                                     FirstOrDefault(lanche =>
                                                     lanche.LancheId == lancheId);
    }
}
}
