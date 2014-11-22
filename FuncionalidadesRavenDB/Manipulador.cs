using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client;

namespace FuncionalidadesRavenDB
{
    class Manipulador
    {

        public bool insertUsuario(int _id, String _nome, char _sexo, int _idade, DateTime dataNasc, long telefone)
        {
            Usuario user = new Usuario 
            {   id = _id , 
                nome = _nome, 
                idade = _idade, 
                sexo = _sexo, 
                dataNascimento = dataNasc,
                telefone = telefone
            };

            IDocumentSession sessao = Banco.getSession();

            sessao.Store(user);
            sessao.SaveChanges();
            sessao.Dispose();


            return true;
        }

        public Usuario buscaUsuario(String nomeUsuario) 
        {
            Usuario [] usuario = null;
            using (var session = Banco.getSession())
            {   
                //linq que retorna um objeto usuario com nome andré                
                try 
                {
                    usuario = session.Query<Usuario>().ToArray();
                }
                catch (System.NotSupportedException e )
                {
                    throw new System.NotSupportedException("Erro ao buscar usuário! "+ e.Message+" Source:" + e.Source);
                }

            }
            return usuario.First();
        }


    }
}
