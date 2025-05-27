using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class KindDb:BaseDb
    {
        static private Kindlist list1 = new Kindlist();

        protected override Base CreateModel(Base entity)
        {
            Kind m = entity as Kind;
            m.kind = reader["kind"].ToString();
            return base.CreateModel(entity);
        }

        public Kindlist SelectAll()
        {
                    command.CommandText = $"SELECT * FROM carkind";
                  Kindlist mList = new Kindlist(base.Select());
                    return mList;
        }


  protected override Base NewEntity()
        {
            return new Kind();
        }
        public static Kind SelectById(int id)
        {
            KindDb db = new KindDb();
            list1 = db.SelectAll();
            Kind g = list1.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Kind k = entity as Kind;
            if (k != null)
            {
                string sql = $"DELETE FROM carkind where id=@pid";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@pid", k.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Kind k = entity as Kind;
            if (k != null)
            {
                string sql = $"Insert into carkind (kind) VALUES (@kind)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@kind", k.kind));
            }


        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Kind kind = entity as Kind;
            if (kind != null)
            {

                string sql = $"UPDATE carkind " +
                             $" set kind=@kind " +
                             $" WHERE id=@Id";
                command.CommandText = sql;
                
                command.Parameters.Add(new OleDbParameter("@kind", kind.kind));
                command.Parameters.Add(new OleDbParameter("@Id", kind.Id));





            }
        }

        protected override void CreateInserdSQL(Base entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}
