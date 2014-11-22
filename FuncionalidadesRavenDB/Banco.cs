using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Document;
using Raven.Client;
namespace FuncionalidadesRavenDB
{
    class Banco
    {
        private static IDocumentSession session{get;set;}
        private static string DATABASENAME= "RAVENBD01";
        
        private Banco() { }

        public static IDocumentSession getSession()
        {
            if (session == null)
            {
                DocumentStore documentStore = new DocumentStore() 
                { 
                  Url =   "http://localhost:8080",
                  DefaultDatabase = DATABASENAME                
                };                
                documentStore.Initialize();
                session = documentStore.OpenSession();
            }

            return session;
        }

    }
}
