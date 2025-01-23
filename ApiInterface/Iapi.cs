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

        public Task<Carlist> GetCars();
        public Task<int> Deletecar(int id);
        public Task<int> Insertcar(Car k);
        public Task<int> Updatecar(Car k);

        public Task<Fvoritelist> Getfavorites();
        public Task<int> Deletefavorite(int id);
        public Task<int> Insertfavorite(Favorite k);
        public Task<int> Updatefavorite(Favorite k);

        public Task<Sellerlist> Getseller();
        public Task<int> Deleteseller(int id);
        public Task<int> Insertseller(Seller k);
        public Task<int> Updateseller(Seller k);

        public Task<Brandlist> Getbrand();
        public Task<int> Deletebrand(int id);
        public Task<int> Insertbrand(Brand k);
        public Task<int> Updatebrand(Brand k);

    }
}
