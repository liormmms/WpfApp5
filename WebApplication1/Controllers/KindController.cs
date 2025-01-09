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
    }
}
