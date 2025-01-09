using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FavoriteDb:BaseDb
    {
        static private Fvoritelist list1 = new Fvoritelist();

        protected override Base CreateModel(Base entity)
        {
            Favorite m = entity as Favorite;
            m.car = reader["car"].ToString();
            return base.CreateModel(entity);
        }

        public Fvoritelist SelectAll1()
        {
            command.CommandText = $"SELECT * FROM favorite";
            Fvoritelist mList = new Fvoritelist(base.Select());
            return mList;
        }


        protected override Base NewEntity()
        {
            return new Favorite();
        }

        public static Favorite SelectById(int id)
        {
            FavoriteDb db = new FavoriteDb();
            list1 = db.SelectAll1();
            Favorite g = list1.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Favorite k = entity as Favorite;
            if (k != null)
            {
                string sql = $"DELETE FROM favorite where id=@pid";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@pid", k.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Favorite f = entity as Favorite;
            if (f != null)
            {
                string sql = $"Insert into Favorite (car) values (@car)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@car", f.car));
            }


        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Favorite favorite = entity as Favorite;
            if (favorite != null)
            {

                string sql = $"UPDATE favorite " +
                             $" set car=@car " +
                             $" WHERE id=@Id";
                command.CommandText = sql;

                command.Parameters.Add(new OleDbParameter("@car", favorite.car));

                command.Parameters.Add(new OleDbParameter("@Id", favorite.Id));





            }
        }
    }
}
