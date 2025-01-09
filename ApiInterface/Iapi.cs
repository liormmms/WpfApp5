using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterface
{
    public interface Iapi
    {
        public Task<Kindlist> GetKinds();
        public Task<int> DeleteKinds(int id);
        public Task<int> InsertKinds(Kind k);
        public Task<int> UpdateKinds(Kind k);

        public Task<BuyerList> Getbuyers();
        public Task<int> Deletebuyers(int id);
        public Task<int> Insertbuyers(Buyer k);
        public Task<int> Updatebuyers(Buyer k);

        public Task<Modellist> Getmodels();
        public Task<int> Deletemodel(int id);
        public Task<int> Insertmodel(Model1 k);
        public Task<int> Updatemodel(Model1 k);

        public Task<Citylist> Getcities();
        public Task<int> Deletecity(int id);
        public Task<int> Insertcity(City1 k);
        public Task<int> Updatecity(City1 k);


    }
}
