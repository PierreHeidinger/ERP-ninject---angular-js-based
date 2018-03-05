
using NPoco;
using NPoco.StoredProcedures;
using System.Collections.Generic;

namespace Persistence.MicroORM.NPoco
{
    public class RepositoryBase<Entity> where Entity : class
    {
        internal const string connectionString = "mssql";
        private Database _contexto;

        private Database GetInstance()
        {
            _contexto = new Database(connectionString);
            return _contexto;
        }

        public bool Add(Entity entity)
        {
            using (var db = GetInstance())
            {
                db.Insert<Entity>(entity);
                return true;
            }
        }

        public bool Delete(Entity entity)
        {
            using (var db = GetInstance())
            {
                db.Delete<Entity>(entity);
                return true;
            }
        }
        public bool Update(Entity entity)
        {
            using (IDatabase db = GetInstance())
            {
                db.Update(entity);
                return true;
            }
        }

        public Entity GetById(int id)
        {
            using (var db = GetInstance())
            {
                return db.SingleById<Entity>(id);
            }
        }

        public IList<Entity> GetAll()
        {
            using (IDatabase db = GetInstance())
            {
                return db.Fetch<Entity>();
            }
        }

        public IEnumerable<Type> useStoreProcedure<Type>(string storeProcedure, Parameter[] parameters = null)
        {
            using (IDatabase db = GetInstance())
            {
                if(parameters != null) { 

                    return db.QueryStoredProcedure<Type>(storeProcedure, parameters);

                }
                else
                {
                    return db.QueryStoredProcedure<Type>(storeProcedure);
                }
            }
        }


    }
}
