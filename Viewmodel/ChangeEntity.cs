using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ChangeEntity
    {
        private Base entity;
        private CreateSql createSql;

        public ChangeEntity(CreateSql createSql, Base entity)
        {
            this.createSql = createSql;
            this.entity = entity;
        }

        public Base Entity { get => entity; set => entity = value; }
        public CreateSql CreateSql { get => createSql; set => createSql = value; }
    }

    public delegate void CreateSql(Base entity, OleDbCommand command);

}
