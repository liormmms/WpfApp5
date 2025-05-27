using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BuyerDb:BaseDb
    {
        static private BuyerList list = new BuyerList();

        public static Model.Buyer SelectById(int id)
        {
            BuyerDb db = new BuyerDb();
            list = db.SelectAll();

            Model.Buyer g = list.Find(item => item.Id == id);
           return g;
        }
        public BuyerList SelectAll()
        {
            command.CommandText = $"SELECT * FROM buyer";
            BuyerList groupList = new BuyerList(base.Select());
            return groupList;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Buyer buyer = new Buyer();
            if (buyer != null) 
            {
                string sql = $"DELETE FROM buyer where id=@pid";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@pid", buyer.Id));
            }
          

        }

       

        protected override Base CreateModel(Base entity)
        {
            Buyer usr = entity as Buyer;
            usr.tz = int.Parse(reader[1].ToString());
            usr.fname = reader[2].ToString();
            usr.lname = reader[3].ToString();
            usr.city = CityDb.SelectById(int.Parse(reader["city"].ToString()));
            var y = reader[4].ToString();
            int x = int.Parse(y);
            base.CreateModel(entity);
            return usr;
        }
        protected override Base NewEntity()
        {
            return new Model.Buyer();
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Buyer buyer = entity as Buyer;
            if (buyer != null)
            {
                string sql = $"Insert into buyer (tz,fname,lname,city) values (@tz,@fname,@lname,@city)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@tz", buyer.tz));
                command.Parameters.Add(new OleDbParameter("@fname", buyer.fname));
                command.Parameters.Add(new OleDbParameter("@lname", buyer.lname));
                command.Parameters.Add(new OleDbParameter("@city", buyer.city));



            }


        }
        protected override void CreateInserdSQL(Base entity, OleDbCommand cmd)
        {
            Buyer buyer = entity as Buyer;
            if (buyer != null)
            {
                string sql = $"Insert into buyer (tz,fname,lname,city) values (@tz,@fname,@lname,@city)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@tz", buyer.tz));
                command.Parameters.Add(new OleDbParameter("@fname", buyer.fname));
                command.Parameters.Add(new OleDbParameter("@lname", buyer.lname));
                command.Parameters.Add(new OleDbParameter("@city", buyer.city));



            }


        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Buyer buyer = entity as Buyer;
            if (buyer != null)
            {

                string sql = $"UPDATE buyer " +
                             $" set tz=@tz, fname=@fname, lname=@lname, city=@city " +
                             $" WHERE id=@Id";
                command.CommandText = sql;

                command.Parameters.Add(new OleDbParameter("@tz", buyer.tz));
                command.Parameters.Add(new OleDbParameter("@tz", buyer.fname));

                command.Parameters.Add(new OleDbParameter("@tz", buyer.lname));

                command.Parameters.Add(new OleDbParameter("@tz", buyer.city.Id));

                command.Parameters.Add(new OleDbParameter("@Id", buyer.Id));





            }
        }
    }
}
