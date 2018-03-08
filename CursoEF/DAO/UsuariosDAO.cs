using CursoEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.DAO
{
    public class UsuariosDAO
    {
        private EntidadesContext contexto;

        public UsuariosDAO()
        {
            contexto = new EntidadesContext();
            contexto.Database.CreateIfNotExists();
        }

        /// <summary>
        /// Adiciona um novo Usuário no banco de dados.
        /// </summary>
        /// <param name="usuario"></param>
        public void Adiciona(Usuario usuario)
        {
            contexto.Usuario.Add(usuario);
            contexto.SaveChanges();
        }

        /// <summary>
        /// Faz uma busca de Usuário por Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario BuscaPorId(int id)
        {
            Usuario u = contexto.Usuario.Find(id);
            if (u != null)
                return contexto.Usuario.Find(id);

            return null;
        }

        //public List<Usuario> BuscaUsuarios(Usuario usuario)
        //{
        //    List<Usuario> Usuarios;
            //#region Lista Todos os Usuários do Banco
            //foreach (var user in contexto.Usuario)
            //{
            //    Console.WriteLine(user.Id + " - " + user.Nome);
            //}
            //#endregion
        //    return user.Id + " - " + user.Nome;
        //}

        /// <summary>
        /// Remove o Usuário do banco de dados.
        /// </summary>
        /// <param name="u"></param>
        public void RemoveUsuario(Usuario u)
        {
            contexto.Usuario.Remove(u);
            contexto.SaveChanges();
        }
    }
}
