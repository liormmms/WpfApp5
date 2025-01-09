using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CityDb : BaseDb
    {
        static private Citylist list = new Citylist();
        protected override Base CreateModel(Base entity)
        {
            City1 m = entity as City1;
            m.cityname = reader["cityname"].ToString();
            return base.CreateModel(entity);
        }

        public Citylist SelectAll()
        {
            command.CommandText = $"SELECT * FROM city";
            Citylist mList = new Citylist (base.Select());
            return mList;
        }


        protected override Base NewEntity()
        {
            return new Model.City1();
        }

        public static City1 SelectById(int id)
        {
            CityDb db = new CityDb();
            list = db.SelectAll();
            City1 g = list.Find(item => item.Id == id);
            return g;

        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            City1 k = entity as City1;
            if (k != null)
            {
                string sql = $"DELETE FROM city where id=@pid";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@pid", k.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            City1 City1 = new City1();
            if (City1 != null)
            {
                string sql = $"Insert into city1 (cityname) values (@cityname)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@cityname", City1.cityname));
            }


        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            City1 city = entity as City1;
            if (city != null)
            {

                string sql = $"UPDATE city " +
                             $" set cityname=@cityname " +
                             $" WHERE id=@Id";
                command.CommandText = sql;

                command.Parameters.Add(new OleDbParameter("@cityname", city.cityname));
                command.Parameters.Add(new OleDbParameter("@Id", city.cityname));





            }
        }
    }
}
