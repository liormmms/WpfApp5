using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BrandDb:BaseDb
    {
        static private Brandlist list = new Brandlist();

        public static Model.Brand SelectById(int id)
        {
           BrandDb db = new BrandDb();
            list = db.SelectAll();

            Model.Brand g = list.Find(item => item.Id == id);
            return g;
        }
        public Brandlist SelectAll()
        {
            command.CommandText = $"SELECT * FROM brands";
            Brandlist groupList = new Brandlist(base.Select());
            return groupList;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Brand k = entity as Brand;
            if (k != null)
            {
                string sql = $"DELETE FROM brands where id=@pid";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@pid", k.Id));
            }
        }

        protected override void CreateInserdSQL(Base entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Brand brand = entity as Brand;
            if (brand != null)
            {
                string sql = $"Insert into brands (bname,worth,numcars) values (@bname,@worth,@numcars)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@bname", brand.Bname));
                command.Parameters.Add(new OleDbParameter("@worth", brand.worth));
                command.Parameters.Add(new OleDbParameter("@numcars", brand.numcars));

            }


        }

        protected override Base CreateModel(Base entity)
        {
            Model.Brand usr = entity as Model.Brand;
            usr.Bname = reader["Bname"].ToString();
            usr.worth = int.Parse(reader["worth"].ToString());
            usr.numcars = int.Parse(reader["numcars"].ToString());
            base.CreateModel(entity);
            return usr;
        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Brand brand = entity as Brand;
            if (brand != null)
            {

                string sql = $"UPDATE brands " +
                             $" set bname=@bname,worth=@worth,numcars=@numcars " +
                             $" WHERE id=@Id";
                command.CommandText = sql;

                command.Parameters.Add(new OleDbParameter("@bname", brand.Bname));
                command.Parameters.Add(new OleDbParameter("@worth", brand.worth));
                command.Parameters.Add(new OleDbParameter("@bname", brand.numcars));
                command.Parameters.Add(new OleDbParameter("@Id", brand.Id));





            }
        }

        protected override Base NewEntity()
        {
            return new Model.Brand();
        }
    }
}
