using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterface
{
    public class Apiservice : Iapi
    {
        string uri;
        HttpClient client;

        public Apiservice()
        {
            uri = "http://localhost:5203/api/Kind/";
            client = new HttpClient();
        }
        public Apiservice(HttpClient client, string baseUri)
        {
            uri = "http://localhost:5203/api/Kind/";
            client = new HttpClient();
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.uri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
        }

        public Task<int> Deletebrand(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Deletebuyers(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Deletecar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Deletecity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Deletefavorite(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteKinds(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Deletemodel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Deleteseller(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Carlist> Getbrand()
        {
            throw new NotImplementedException();
        }

        public async Task<BuyerList> Getbuyers()
        {
            return await client.GetFromJsonAsync<BuyerList>(uri+ "buyerselector");
        }

        public Task<Carlist> GetCars()
        {
            throw new NotImplementedException();
        }

        public Task<Citylist> Getcities()
        {
            throw new NotImplementedException();
        }

        public Task<Carlist> Getfavorites()
        {
            throw new NotImplementedException();
        }

        public Task<Kindlist> GetKinds()
        {
            throw new NotImplementedException();
        }

        public Task<Modellist> Getmodels()
        {
            throw new NotImplementedException();
        }

        public Task<Carlist> Getseller()
        {
            throw new NotImplementedException();
        }

        public Task<int> Insertbrand(Favorite k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insertbuyers(Buyer k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insertcar(Car k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insertcity(City1 k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insertfavorite(Favorite k)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertKinds(Kind k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insertmodel(Model1 k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insertseller(Favorite k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Updatebrand(Favorite k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Updatebuyers(Buyer k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Updatecar(Car k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Updatecity(City1 k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Updatefavorite(Favorite k)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateKinds(Kind k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Updatemodel(Model1 k)
        {
            throw new NotImplementedException();
        }

        public Task<int> Updateseller(Favorite k)
        {
            throw new NotImplementedException();
        }
    }
}
