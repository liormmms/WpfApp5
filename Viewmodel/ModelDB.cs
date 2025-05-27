using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ModelDB : BaseDb
    {
        static private Modellist list = new Modellist();

        public static Model.Model1 SelectById(int id)
        {
            ModelDB db = new ModelDB();
            list = db.SelectAll();

            Model.Model1 g = list.Find(item => item.Id == id);
            return g;
        }
        public Modellist SelectAll()
        {
            command.CommandText = $"SELECT * FROM model";
            Modellist groupList = new Modellist(base.Select());
            return groupList;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {

            Model1 k = entity as Model1;
            if (k != null)
            {
                string sql = $"DELETE FROM model where id=@pid";
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
            Model1 model = entity as Model1;
            if (model != null)
            {
                string sql = $"Insert into model(brnadname,modelname) values (@brandname,@modelname)";
                command.CommandText = sql;
                command.Parameters.Add(new OleDbParameter("@brnadname", model.Brandname));
                command.Parameters.Add(new OleDbParameter("@modelname", model.Moedlname));

            }


        }

        protected override Base CreateModel(Base entity)
        {
            Model.Model1 usr = entity as Model.Model1;
           
            usr.Brandname =  BrandDb.SelectById(int.Parse(reader["brandname"].ToString()));
            usr.Moedlname = reader["modelname"].ToString();
            base.CreateModel(entity);
            return usr;
        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Model1 model = entity as Model1;
            if (model != null)
            {

                string sql = $"UPDATE model " +
                             $" set brandname=@brandname, modelname=@modelname " +
                             $" WHERE id=@Id";
                command.CommandText = sql;

                command.Parameters.Add(new OleDbParameter("@brandname", model.Brandname.Id));
                command.Parameters.Add(new OleDbParameter("@modelname", model.Moedlname));
                command.Parameters.Add(new OleDbParameter("@Id", model.Id));

            }
        }

        protected override Base NewEntity()
        {
            return new Model.Model1();
        }
    }
}

