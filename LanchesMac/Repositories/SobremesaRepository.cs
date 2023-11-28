using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LanchesMac.Repositories.Interfaces
{
    public class SobremesaRepository : ISobremesaRepository
    {
        private readonly AppDbContext _context;

        public SobremesaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Sobremesa> Sobremesas => _context.Sobremesas.Include(categoria => categoria.Categoria);
        public IEnumerable<Sobremesa> SobremesasPrferidas => _context.Sobremesas
                                   .Where(sobremesas => sobremesas.IsSobremesaPreferida)
                                   .Include(categoria => categoria.Categoria);

        public Sobremesa GetSobremesaById(int sobremesaId) => _context.Sobremesas.
                                                     FirstOrDefault(sobremesas =>
                                                     sobremesas.SobremesaId == sobremesaId);
    }
}