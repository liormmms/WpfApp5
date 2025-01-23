using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KindController : ControllerBase
    {
        [HttpGet]
        [ActionName("kindselector")]
        public Kindlist Selectallkinds()
        {
            KindDb db = new KindDb();
            Kindlist result = db.SelectAll();
            return result;
        }
        [HttpGet]
        [ActionName("buyerselector")]
        public BuyerList SelectAllbuyers()
        {
           
            {
                BuyerDb db = new BuyerDb();
                BuyerList bd = db.SelectAll();
                return bd;
            }
        }

        [HttpGet]
        [ActionName("modelselector")]
        public Modellist SelectAllmodels()
        {
            ModelDB db = new ModelDB();
            Modellist bd = db.SelectAll();
            return bd;
        }
        [HttpGet]
        [ActionName("cityselector")]
        public Citylist SelectAllcities()
        {
            CityDb db = new CityDb();
            Citylist bd = db.SelectAll();
            return bd;
        }
        [HttpGet]
        [ActionName("carsselector")]
        public Carlist SelectAllcars()
        {
            CarDb db = new CarDb();
            Carlist bd = db.SelectAll();
            return bd;
        }
        [HttpGet]
        [ActionName("favoriteselector")]
        public Fvoritelist SelectAllcfavorites()
        {
            FavoriteDb db = new FavoriteDb();
            Fvoritelist bd = db.SelectAll1();
            return bd;
        }
        [HttpGet]
        [ActionName("Brandselector")]
        public BuyerList SelectAllbrands()
        {
            BuyerDb db = new BuyerDb();
            BuyerList bd = db.SelectAll();
            return bd;
        }
        [HttpGet]
        [ActionName("sellerselector")]
        public Sellerlist SelectAllsellers()
        {
            sellerDb db = new sellerDb();
            Sellerlist bd = db.SelectAll();
            return bd;
        }
        [HttpDelete("{id}")]
        [ActionName("Deleteseller")]
        public int DeleteAllsellers(int id)
        {
            Seller s = sellerDb.SelectById(id);
            sellerDb db = new sellerDb();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("Deletekind")]
        public int DeleteAllkind(int id)
        {
            Kind s = KindDb.SelectById(id);
            KindDb db = new KindDb();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("Deletecars")]
        public int DeleteAllcars(int id)
        {
            Car s = CarDb.SelectById(id);
            CarDb db = new CarDb();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("Deletebuyer")]
        public int DeleteAllbuyer(int id)
        {
            Buyer s = BuyerDb.SelectById(id);
            BuyerDb db = new BuyerDb();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("Deletemodel")]
        public int DeleteAllmodels(int id)
        {
            Model1 s = ModelDB.SelectById(id);
            ModelDB db = new ModelDB();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("Deletecity")]
        public int DeleteAllcity(int id)
        {
            City1 s = CityDb.SelectById(id);
            CityDb db = new CityDb();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("Deletebrand")]
        public int DeleteAllbrands(int id)
        {
            Brand s = BrandDb.SelectById(id);
            BrandDb db = new BrandDb();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("Deletefavorite")]
        public int DeleteAllfavorites(int id)
        {
            Favorite s = FavoriteDb.SelectById(id);
            FavoriteDb db = new FavoriteDb();
            db.Delete(s);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updatebrand")]
        public int UpdateAllbrands([FromBody] Brand c)
        {
            BrandDb db = new BrandDb();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updatemodel")]
        public int UpdateAllmodel([FromBody] Model1 c)
        {
            ModelDB db = new ModelDB();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updatekind")]
        public int UpdateAllkinds([FromBody] Kind c)
        {
            KindDb db = new KindDb();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updatecars")]
        public int UpdateAllcars([FromBody] Car c)
        {
            CarDb db = new CarDb();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updatefavorite")]
        public int UpdateAllfavorites([FromBody] Favorite c)
        {
            FavoriteDb db = new FavoriteDb();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updatecity")]
        public int UpdateAllcities([FromBody] City1 c)
        {
            CityDb db = new CityDb();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updatebuyer")]
        public int UpdateAllbuyers([FromBody] Buyer c)
        {
            BuyerDb db = new BuyerDb();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Updateseller")]
        public int UpdateAllsellers([FromBody] Seller c)
        {
            sellerDb db = new sellerDb();
            db.Update(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Insertseller")]
        public int InsertAllsellers([FromBody] Seller c)
        {
            sellerDb db = new sellerDb();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Insertbuyer")]
        public int InsertAllbuyers([FromBody] Seller c)
        {
            BuyerDb db = new BuyerDb();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Insertcar")]
        public int InsertAllcars([FromBody] Car c)
        {
            CarDb db = new CarDb();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Insertcity")]
        public int InsertAllcities([FromBody] City1 c)
        {
            CityDb db = new CityDb();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Insertfavorite")]
        public int InsertAllfavorites([FromBody] Favorite c)
        {
            FavoriteDb db = new FavoriteDb();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Insertkind")]
        public int InsertAllkinds([FromBody] Kind c)
        {
            KindDb db = new KindDb();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpGet]
        [ActionName("Insertmodel")]
        public int InsertAllmodels([FromBody] Model1 c)
        {
            ModelDB db = new ModelDB();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;
        }



    }
}
