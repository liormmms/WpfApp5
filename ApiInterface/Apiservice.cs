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
        {        //http://localhost:5203/api/Kind/buyerselector
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

        public async Task<int> Deletebrand(int id)
        {
            return (await client.DeleteAsync(uri + $"Deletebrands/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Deletebuyers(int id)
        {
            return (await client.DeleteAsync(uri + $"Deletebuyers/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Deletecar(int id)
        {
            return (await client.DeleteAsync(uri + $"Deletecars/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Deletecity(int id)
        {
            return (await client.DeleteAsync(uri + $"Deletebuyers/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Deletefavorite(int id)
        {
            return (await client.DeleteAsync(uri + $"Deletefavorites/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteKinds(int id)
        {
            return (await client.DeleteAsync(uri + $"Deletekinds/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Deletemodel(int id)
        {
            return (await client.DeleteAsync(uri + $"Deletemodels/{id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Deleteseller(int id)
        {
            return (await client.DeleteAsync(uri + $"Deleteseller/{id}")).IsSuccessStatusCode ? 1 : 0;
        }
       
        public async Task<Brandlist> Getbrand()
        {
            return await client.GetFromJsonAsync<Brandlist>(uri + "brandselector");
        }

        public async Task<BuyerList> Getbuyers()
        {
           
            return await client.GetFromJsonAsync<BuyerList>(uri+ "buyerselector");
        }

        public async Task<Carlist> GetCars()
        {
            return await client.GetFromJsonAsync<Carlist>(uri + "carsselector");
        }

        public async Task<Citylist> Getcities()
        {
            return await client.GetFromJsonAsync<Citylist>(uri + "cityselector");
        }

        public async Task<Fvoritelist> Getfavorites()
        {
            return await client.GetFromJsonAsync<Fvoritelist>(uri + "favoriteselector");
        }

        public async Task<Kindlist> GetKinds()
        {//http://localhost:5203/api/Kind/kindselector
            return await client.GetFromJsonAsync<Kindlist>(uri + "kindselector");
        }

        public async Task<Modellist> Getmodels()
        {
            return await client.GetFromJsonAsync<Modellist>(uri + "modelselector");
        }

        public async Task<Sellerlist> Getseller()
        {
            return await client.GetFromJsonAsync<Sellerlist>(uri + "sellerselector");
        }

        public async Task<int> Insertbrand(Brand k)
        {
            return (await client.PostAsJsonAsync<Brand>(uri + $"Insertbrands", k)).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<int> Insertbuyers(Buyer k)
        {
            return (await client.PostAsJsonAsync<Buyer>(uri + $"Insertbuyer", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Insertcar(Car k)
        {
            return (await client.PostAsJsonAsync<Car>(uri + $"Insertcars", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Insertcity(City1 k)
        {
            return (await client.PostAsJsonAsync<City1>(uri + $"Insertcities", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Insertfavorite(Favorite k)
        {
            return (await client.PostAsJsonAsync<Favorite>(uri + $"Insertfavorites", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertKinds(Kind k)
        {
            return (await client.PostAsJsonAsync<Kind>(uri + $"Insertkinds", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Insertmodel(Model1 k)
        {
            return (await client.PostAsJsonAsync<Model1>(uri + $"Insertmodels", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Insertseller(Seller k)
        {
            return (await client.PostAsJsonAsync<Seller>(uri + $"Insertsellers", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Updatebrand(Brand k)
        {
            return (await client.PutAsJsonAsync<Brand>(uri + $"Insertbrands", k)).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<int> Updatebuyers(Buyer k)
        {
            return (await client.PutAsJsonAsync<Buyer>(uri + $"Insertbuyers", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Updatecar(Car k)
        {
            return (await client.PutAsJsonAsync<Car>(uri + $"Insertcar", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Updatecity(City1 k)
        {
            return (await client.PutAsJsonAsync<City1>(uri + $"Insertcity", k)).IsSuccessStatusCode ? 1 : 0;

        }

        public async Task<int> Updatefavorite(Favorite k)
        {
            return (await client.PutAsJsonAsync<Favorite>(uri + $"Insertfavorite", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateKinds(Kind k)
        {
            return (await client.PutAsJsonAsync<Kind>(uri + $"Insertkind", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Updatemodel(Model1 k)
        {
            return (await client.PutAsJsonAsync<Model1>(uri + $"Insertmodel", k)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> Updateseller(Seller k)
        {
            return (await client.PutAsJsonAsync<Seller>(uri + $"Insertseller", k)).IsSuccessStatusCode ? 1 : 0;
        }

       
    }
}
