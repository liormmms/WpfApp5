using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Kindservice : Iapi
    {
        string uri;
            public HttpClient client;
        public  Kindservice()
        {
            uri = "http://localhost:5203";
            client = new HttpClient();
        }
        public async Task<Kindlist> GetAllKindes()
        {
            string x = uri + "/api/Kind/kindselector";
            return await client.GetFromJsonAsync<Kindlist>(uri + "/api/Kind/kindselector");
        }

        public async Task<int> DeleteAkind(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/Deletekind/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAKind(Kind c)
        {
            return (await client.PutAsJsonAsync<Kind>(uri + "/api/Insert/UpdateKind", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAkind(Kind c)
        {
            return (await client.PostAsJsonAsync<Kind>(uri + "/api/Insert/InsertKind", c)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<BuyerList> GetAllbuyers()
        {
            return await client.GetFromJsonAsync<BuyerList>(uri + "/api/Insert/kindSelector");
        }

        public async Task<int> DeleteAbuyer(int id)
        {
            return (await client.DeleteAsync(uri + "/api/Insert/Deletebuyer/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAbuyer(Kind c)
        {
            return (await client.PutAsJsonAsync<Kind>(uri + "/api/Insert/Updatebuyer", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAbuyer(Kind c)
        {
            return (await client.PostAsJsonAsync<Kind>(uri + "/api/Insert/Insertbuyer", c)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
