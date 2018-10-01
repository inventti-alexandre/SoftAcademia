using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Usuario
{
    class UsuarioBusiness
    {
        public int CadastrarUsuario(UsuarioDTO dto)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.CadastrarUsuario(dto);
        }

        public int AlterarUsuario(UsuarioDTO dto)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.AlterarUsuario(dto);
        }

        public int RemoverUsuario(UsuarioDTO dto)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.RemoverUsuario(dto);
        }

        public List<view_Usuario_Filial> Consultar()
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.Consultar();
        }

        public List<view_Usuario_Filial> ConsultarPorNome(string nome)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorNome(nome);
        }

        public List<view_Usuario_Filial> ConsultarPorNome_Filial(string nome, int filial)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorNome_Filial(nome, filial);
        }
    }
}
