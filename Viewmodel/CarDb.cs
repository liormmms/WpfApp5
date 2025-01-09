using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CarDb:BaseDb
    {
        static private Carlist list = new Carlist();

        public static Model.Car SelectById(int id)
        {
            CarDb db = new CarDb();
            list = db.SelectAll();
            Model.Car g = list.Find(item => item.Id == id);
            return g;
        }
        public Carlist SelectAll()
        {
            command.CommandText = $"SELECT * FROM Car";
            Carlist groupList = new Carlist(base.Select());
            return groupList;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Car k = entity as Car;
            if (k != null)
            {
                string sql = $"DELETE FROM Car where id=@pid";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@pid", k.Id));
            }
        }

        

        protected override Base CreateModel(Base entity)
        {
            Model.Car usr = entity as Model.Car;
            usr.Modelname =  ModelDB.SelectById(int.Parse(reader["modelname"].ToString()));
            usr.Price = int.Parse(reader["price"].ToString());
            usr.Location = CityDb.SelectById(int.Parse(reader["Location"].ToString()));
            usr.Carkind = KindDb.SelectById(int.Parse(reader["kind"].ToString()));
            usr.CarSeller = sellerDb.SelectById(int.Parse(reader["seller"].ToString()));
            usr.CarBrand = BrandDb.SelectById(int.Parse(reader["brandname"].ToString()));
            base.CreateModel(entity);
            return usr;
        }
        protected override Base NewEntity()
        {
            return new Model.Car();
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Car car = entity as Car;
            if (car != null)
            {
                //string sql = $"Insert into buyer (tz,fname,lname,city) values (@tz,@fname,@lname,@city)";
                string sql = $"Insert into car (brandName,seller,price,location,kind,modelname) values (@CarBrand,@seller,@price,@location,@kind,@modelname)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@CarBrand", car.CarBrand.Id));
                command.Parameters.Add(new OleDbParameter("@seller", car.CarSeller.Id));
                command.Parameters.Add(new OleDbParameter("@price", car.Price));
                command.Parameters.Add(new OleDbParameter("@location", car.Location.Id));
                command.Parameters.Add(new OleDbParameter("@kind", car.Carkind.Id));
                command.Parameters.Add(new OleDbParameter("@modelname", car.Modelname.Id));





            }


        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Car car = entity as Car;
            if (car != null)
            {

                string sql = $"UPDATE car " +
                             $"set brandname=@CarBrnad, seller=@carseller, price=@price, location=@location, kind=@kind, picture=@picture, modelname=@modelname " +
                             $" WHERE id=@Id";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@CarBrand", car.CarBrand.Id));
                command.Parameters.Add(new OleDbParameter("@carseller", car.CarSeller.Id));
                command.Parameters.Add(new OleDbParameter("@price", car.Price));
                command.Parameters.Add(new OleDbParameter("@location", car.Location.Id));
                command.Parameters.Add(new OleDbParameter("@kind", car.Carkind.Id));
                command.Parameters.Add(new OleDbParameter("@picture",""));

                command.Parameters.Add(new OleDbParameter("@modelname", car.Modelname.Id));





            }
        }
    }
}
