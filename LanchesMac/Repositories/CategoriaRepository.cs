﻿using LanchesMac.Context;
using LanchesMac.Models;
using System.Collections.Generic;

namespace LanchesMac.Repositories.Interfaces
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
