using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class Usuario
    {
        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        public Usuario()
        {
            listaUsuarios.Add(new UsuarioModel
            {
                nome = "'Aluno1'",
                sobrenome = "'Aluno 2'",
                endereco = "'Rua 111, 100'",
                email = "'Teste@teste.com'",
                nascimento = Convert.ToDateTime("05/09/1975")
            });
        }

        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuarios)
            {
                if(usuario.email == usuarioModelo.email)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }

        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;
            foreach (UsuarioModel _usuario in listaUsuarios)
                 if (_usuario.email == Email)
                    _usuarioModel = _usuario;

                return _usuarioModel;
        }

        public void DeletarUsuario(string Email)
        {
            foreach (UsuarioModel _usuario in listaUsuarios)
            {
                if(_usuario.email == Email)
                {
                    listaUsuarios.Remove(_usuario);
                    break;
                }
            }
        }
    }
}