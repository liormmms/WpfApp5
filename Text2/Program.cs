// See https://aka.ms/new-console-template for more information
//TEST GROUPTYPE

using ApiInterface;
using Model;
using System.Diagnostics;
using System.Net.Http.Json;
using ViewModel;
#region



//Kind kc = KindDb.SelectById(1);
//KindDb kcdb = new KindDb();
//Kindlist kcs = kcdb.SelectAll();
//Console.WriteLine("students list before :");
//foreach (Kind c in kcs)
//    Console.WriteLine(c.kind);
////Kind kLast = kcs.Last();
////kcdb.Delete(kLast);
////kcdb.SaveChanges();
//Console.WriteLine("delete:");
//kcs = kcdb.SelectAll();
//foreach (Kind c in kcs)
//    Console.WriteLine(c.kind);
//Kind ky = new Kind() { kind = "luxury" };
//KindDb kyd = new KindDb();
//kyd.Insert(ky);
//kyd.SaveChanges();
//Kindlist kinds = kyd.SelectAll();
//foreach (Kind c in kinds)
//{
//    Console.WriteLine(c.kind);
//}
//Kind p2 = kinds[2];
//p2.kind = "electric";
//kyd.Update(p2);
//kyd.SaveChanges();
//Kindlist kinds1 = kyd.SelectAll();
//foreach (Kind c in kinds1)
//{
//    Console.WriteLine(c.kind);
//}


//#endregion
//#region
//Brand brc = BrandDb.SelectById(1);
//BrandDb brdb = new BrandDb();
//Brandlist brs = brdb.SelectAll();
//Console.WriteLine("students list before :");
//foreach (Brand c in brs)
//    Console.WriteLine(c.worth);
//Brand brLast = brs.Last();
////brdb.Delete(brLast);
////brdb.SaveChanges();
//Console.WriteLine("delete:");
//brs = brdb.SelectAll();
//foreach (Brand c in brs)
//    Console.WriteLine(c.worth);
//Brand bry = new Brand() { worth = 4440, Bname = "suzuki", numcars = 3 };
//BrandDb brd = new BrandDb();
////brd.Insert(bry);
////brd.SaveChanges();
//Brandlist brands = brd.SelectAll();
//foreach (Brand c in brands)
//{
//    Console.WriteLine(c.worth);
//}
//Brand b2 = brands[2];
//b2.Bname = "kia";
//brd.Update(b2);
//brd.SaveChanges();
//Brandlist brands1 = brd.SelectAll();
//foreach (Brand c in brands1)
//{
//    Console.WriteLine(c.Bname);
//}

//#endregion
//#region
//Seller sc = sellerDb.SelectById(1);
//sellerDb sDB = new sellerDb();
//Sellerlist sts = sDB.SelectAll();
//Console.WriteLine("students list before :");
//foreach (Seller c in sts)
//    Console.WriteLine(c.lname);
//Seller sLast = sts.Last();
////sDB.Delete(sLast);
////sDB.SaveChanges();
//Console.WriteLine("delete:");
//sts = sDB.SelectAll();
//foreach (Seller c in sts)
//    Console.WriteLine(c.lname);
//#endregion
//#region
//City1 c1c = CityDb.SelectById(1);
//CityDb c1DB = new CityDb();
//Citylist csts = c1DB.SelectAll();
//Console.WriteLine("students list before :");
//foreach (City1 c in csts)
//    Console.WriteLine(c.cityname);
//City1 cLast = csts.Last();
////c1DB.Delete(sLast);
////c1DB.SaveChanges();
//Console.WriteLine("delete:");
//csts = c1DB.SelectAll();
//foreach (City1 c in csts)
//    Console.WriteLine(c.cityname);
//City1 cy = new City1() { cityname = "haifa" };
//CityDb cyd = new CityDb();
//cyd.Insert(cy);
//cyd.SaveChanges();
//Citylist cities = cyd.SelectAll();
//foreach (City1 c in cities)
//{
//    Console.WriteLine(c.cityname);
//}
//City1 c2 = cities[2];
//c2.cityname = "natnia";
//cyd.Update(c2);
//cyd.SaveChanges();
//Citylist cities1 = cyd.SelectAll();
//foreach (City1 c in cities1)
//{
//    Console.WriteLine(c.cityname);
//}
//#endregion
//#region
//Model1 mc = ModelDB.SelectById(1);
//ModelDB mDB = new ModelDB();
//Modellist ms = mDB.SelectAll();
//Console.WriteLine("students list before :");
//foreach (Model1 c in ms)
//    Console.WriteLine(c.Moedlname);
//Model1 mLast = ms.Last();
////mDB.Delete(mLast);
////mDB.SaveChanges();
//Console.WriteLine("delete:");
//ms = mDB.SelectAll();
//foreach (Model1 c in ms)
//    Console.WriteLine(c.Moedlname);
//Model1 m2 = ms[0];
//m2.Moedlname = "picanto";
//mDB.Update(m2);
//mDB.SaveChanges();
//Modellist ms1 = mDB.SelectAll();
//foreach (Model1 c in ms1)
//{
//    Console.WriteLine(c.Moedlname);
//}

//#endregion
//#region
//Buyer by = new Buyer() { city = csts[0], fname = "liroi", lname = "toman", tz = 7689543 };
//BuyerDb byd = new BuyerDb();
//BuyerList bs = byd.SelectAll();
////byd.Insert(by);
////byd.SaveChanges();
//BuyerList buyers = byd.SelectAll();
//foreach (Buyer c in buyers)
//{
//    Console.WriteLine(c.fname);
//}
//Buyer bu2 = buyers[2];
//bu2.fname = "natnia";
//byd.Update(bu2);
//byd.SaveChanges();
//BuyerList buyers2 = byd.SelectAll();
//foreach (Buyer c in buyers2)
//{
//    Console.WriteLine(c.fname);
//}


//#endregion
//#region

//Car cay = new Car() { Location = csts[0], Price = 44400, Modelname = ms[0], CarSeller = sts[1], CarBrand = brs[0], Carkind = kinds[0], pic = "yuy", km = 5666 };
//CarDb cad = new CarDb();
//cad.Insert(cay);
//cad.SaveChanges();
//Carlist cars = cad.SelectAll();
//foreach (Car c in cars)
//{
//    //Console.WriteLine(c.Modelname + " " + c.Carkind + " " + c.CarSeller.fname);
//}
//Car cu2 = new Car() { Location = csts[0], Price = 44400, Modelname = ms[0], CarSeller = sts[1], CarBrand = brs[0], Carkind = kinds[0], pic="yuy", km=5666 };
//cu2.Price = 49000;
//cad.Update(cu2);
//cad.SaveChanges();
//Carlist cras = cad.SelectAll();
//foreach (Car c in cras)
//{
//    Console.WriteLine(c.Price);
//}
//Car caLast = cars.Last();
//cad.Delete(mLast);
//cad.SaveChanges();
//Console.WriteLine("delete:");
//cars = cad.SelectAll();
//foreach (Car c in cars)
//    Console.WriteLine(c.Price);
#endregion
#region
Favorite fc = FavoriteDb.SelectById(1);
FavoriteDb fdb = new FavoriteDb();
Fvoritelist fcs = fdb.SelectAll1();
Console.WriteLine("students list before :");
foreach (Favorite c in fcs)
    Console.WriteLine(c.car);
Favorite fLast = fcs.Last();
fdb.Delete(fLast);
fdb.SaveChanges();
//Console.WriteLine("delete:");
//fcs = fdb.SelectAll1();
//foreach (Favorite c in fcs)
//    Console.WriteLine(c.car);
//Favorite fy = new Favorite() { };
//FavoriteDb fyd = new FavoriteDb();
////kyd.Insert(ky);
////kyd.SaveChanges();
//Fvoritelist favorits = fyd.SelectAll1();
//foreach (Favorite c in favorits)
//{
//    Console.WriteLine(c.car);
//}
//Favorite fu2 = favorits[2];
//fu2.car = cu2;
//fyd.Update(fu2);
//fyd.SaveChanges();
//Fvoritelist favorites = fyd.SelectAll1();
//foreach (Buyer c in buyers2)
//{
//    Console.WriteLine(c.fname);
//}
//Apiservice apiservice = new();
//Kindlist cities = await apiservice.GetKinds();
//Console.WriteLine(cities.Count);
//int id = cities.Last().Id;
//await apiservice.DeleteKinds(id);
//Console.WriteLine(cities.Count);

//Kind c1 = new Kind() { kind = "rare" };
//await apiservice.InsertKinds(c1);
//Kind myCity = cities.First();
//myCity.kind = "rare";
//await apiservice.UpdateKinds(myCity);
//#endregion



//Apiservice apiservice1 = new();
//Brandlist brands = await apiservice1.Getbrand();
//Console.WriteLine(brands.Count);
//int bd = brands.Last().Id;
//await apiservice1.Deletebrand(bd);
//Console.WriteLine(brands.Count);

//Brand b1 = new Brand() { Bname = "fiat" };
//await apiservice1.Insertbrand(b1);
//Brand mybrand = brands.First();
//mybrand.Bname = "porch";
//await apiservice1.Updatebrand(mybrand);



//Apiservice apiservice2 = new();
//Carlist cars = await apiservice2.GetCars();
//Console.WriteLine(cars.Count);
//int cd = cars.Last().Id;
//await apiservice2.Deletecar(bd);
//Console.WriteLine(cars.Count);

//Car c2 = new Car() { Price = 4000 };
//await apiservice1.Insertcar(c2);
//Car mycar = cars.First();
//mycar.Price = 60000;
//await apiservice2.Updatecar(mycar);



//Apiservice apiservice3 = new();
//Citylist cities2 = await apiservice3.Getcities();
//Console.WriteLine(cities2.Count);
//int c3 = cities.Last().Id;
//await apiservice3.Deletecity(c3);
//Console.WriteLine(cities.Count);

//Car c2 = new Car() { Price = 4000 };
//await apiservice1.Insertcar(c2);
//Car mycar = cars.First();
//mycar.Price = 60000;
//await apiservice2.Updatecar(mycar);

#endregion
