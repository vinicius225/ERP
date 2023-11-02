using ERP.Aplication.Interfaces;
using ERP.Domain.Entities;
using ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Aplication.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task Adicionar(Usuario usuario)
        {
             await _usuarioRepository.Adicionar(usuario);
        }

        public async Task Atualizar(Usuario usuario)
        {
            await _usuarioRepository.Atualizar(usuario);
        }

        public async Task AtualizarStatus(int idUsuario, bool status)
        {
            await _usuarioRepository.AtualizarStatus(idUsuario, status);   
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _usuarioRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Usuario>> Listar()
        {
            return await _usuarioRepository.Listar();
        }
    }
}
