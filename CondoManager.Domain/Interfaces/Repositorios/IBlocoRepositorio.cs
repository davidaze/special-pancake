﻿using CondoManager.Domain.Core.Interfaces;
using CondoManager.Domain.Entidades;
using CondoManager.Domain.Interfaces.Filtros;
using System.Linq;

namespace CondoManager.Domain.Interfaces.Repositorios
{
    public interface IBlocoRepositorio : IRepository<Bloco>
    {
        IQueryable<Bloco> FindByFilter(BlocoFiltro filtro);
    }
}
