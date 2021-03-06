﻿using System;
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
            if (dto.ds_Senha == string.Empty)
                throw new ArgumentException("A senha não pode ser nula");

            UsuarioDatabase db = new UsuarioDatabase();
            return db.AlterarUsuario(dto);
        }

        public int RemoverUsuario(int id)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.RemoverUsuario(id);
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

        public view_Usuario_Filial ConsultarPorId(string id)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorId(id);
        }

        public List<view_Usuario_Filial> ConsultarPorNome_Filial(string nome, int filial)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorNome_Filial(nome, filial);
        }
    }
}
