﻿using ERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task Adicionar(Usuario usuario);
        Task<IEnumerable<Usuario>> Listar();
        Task<Usuario> BuscarPorId(int id);
        Task Atualizar(Usuario usuario);
        Task AtualizarStatus(int idUsuario, bool status);
    }
}
