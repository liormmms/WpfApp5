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
            m.car =CarDb.SelectById(int.Parse(reader["car"].ToString()));
            return base.CreateModel(entity);
            //usr.Location = CityDb.SelectById(int.Parse(reader["Location"].ToString()));
        }

        public Fvoritelist SelectAll1()
        {
            command.CommandText = $"SELECT * FROM favorite";
            Fvoritelist mList = new Fvoritelist(base.Select());
            return mList;
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
                command.Parameters.Add(new OleDbParameter("@car", f.car.Id));
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

                command.Parameters.Add(new OleDbParameter("@car", favorite.car.Id));

                command.Parameters.Add(new OleDbParameter("@Id", favorite.Id));





            }
        }

        protected override Base NewEntity()
        {
            return new Model.Favorite();
        }

        protected override void CreateInserdSQL(Base entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}
