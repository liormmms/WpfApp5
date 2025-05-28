using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class sellerDb : BuyerDb
    {
        static private Sellerlist list = new Sellerlist();
        public static List<ChangeEntity> deleted = new List<ChangeEntity>();

        public static Model.Seller SelectById(int id)
        {
            sellerDb db = new sellerDb();
            list = db.SelectAll();

            Model.Seller g = list.Find(item => item.Id == id);
            return g;
        }
        public Sellerlist SelectAll()
        {
            command.CommandText = $"SELECT * FROM seller";
            Sellerlist groupList = new Sellerlist(base.Select());
            return groupList;
        }



        protected override Base CreateModel(Base entity)
        {
            Model.Seller usr = entity as Model.Seller;
            usr.phone = reader["phone"].ToString();
            usr.sellerpass = reader["sellerPass"].ToString();
            usr.email = reader["email"].ToString();
            usr.city = CityDb.SelectById(int.Parse(reader["city"].ToString()));


            base.CreateModel(entity);
            return usr;
        }
        protected override Base NewEntity()
        {
            return new Model.Seller();
        }
        public virtual void Delete(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
            }
        }
        public override void Insert(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(this.CreateInserdSQL, entity));
                inserted.Add(new ChangeEntity(base.CreateInserdSQL, entity));
            }
        }

        //protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        //{
        //    Seller model = entity as Seller;
        //    if (model != null)
        //    {
        //        string sql = $"Insert into seller (phone,sellerpass,email,city) values (@phone,@sellerpass,@email,@city)";
        //        command.CommandText = sql;
        //        command.Parameters.Add(new OleDbParameter("@phone", model.phone));
        //        command.Parameters.Add(new OleDbParameter("@sellerpass", model.sellerpass));
        //        command.Parameters.Add(new OleDbParameter("@email", model.email));
        //        command.Parameters.Add(new OleDbParameter("@city", model.city.Id));
        //        command.Parameters.Add(new OleDbParameter("@phone", model.Id));


        //    }


        //}
        protected override void CreateInserdSQL(Base entity, OleDbCommand cmd)
        {
            Seller model = entity as Seller;
            if (model != null)
            {
                string sql = $"Insert into seller (phone,sellerpass,email,city) values (@phone,@sellerpass,@email,@city)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@phone", model.phone));
                command.Parameters.Add(new OleDbParameter("@sellerpass", model.sellerpass));
                command.Parameters.Add(new OleDbParameter("@email", model.email));
                command.Parameters.Add(new OleDbParameter("@city", model.city.Id));
                command.Parameters.Add(new OleDbParameter("@Id", model.Id));


            }


        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Seller model = entity as Seller;
            if (model != null)
            {

                string sql = $"UPDATE model " +
                             $" set phone=@phone, sellerpass=@sellerpass , email=@email , city=@city " +
                             $" WHERE id=@Id";
                command.CommandText = sql;

                command.Parameters.Add(new OleDbParameter("@phone", model.phone));
                command.Parameters.Add(new OleDbParameter("@sellerpass", model.sellerpass));
                command.Parameters.Add(new OleDbParameter("@email", model.email));
                command.Parameters.Add(new OleDbParameter("@city", model.city.Id));
                command.Parameters.Add(new OleDbParameter("@Id", model.Id));



            }
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {

            Seller model = entity as Seller;
            if (model != null)
            {
                string sql = $"DELETE FROM model where id=@pid";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@phone", model.phone));
                command.Parameters.Add(new OleDbParameter("@sellerpass", model.sellerpass));
                command.Parameters.Add(new OleDbParameter("@email", model.email));
                command.Parameters.Add(new OleDbParameter("@city", model.city.Id));
                command.Parameters.Add(new OleDbParameter("@Id", model.Id));
            }



        }
    }
}

