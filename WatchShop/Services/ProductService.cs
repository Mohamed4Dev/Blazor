using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Services
{
    public class ProductService
    {
        public List<Product> GetProducts() => new List<Product>
        {
            new Product{Id=1, Name="Watch 1", Description="Some quick example text to build on the card title and make up the bulk of the card's content.",
            ImageUrl="https://images-eu.ssl-images-amazon.com/images/G/42/Sunrise/SL/XCM_Manual_1323197_1661000_Egypt_SR_EG_CP_NT_SL_WomensMainPage_WomenWatchesSmart_3868574_440x440_en_AE.jpg",
            Price=110},
            new Product{Id=2 ,Name="Watch 2", Description="Some quick example text to build on the card title and make up the bulk of the card's content.",
            ImageUrl="https://images-eu.ssl-images-amazon.com/images/G/42/Sunrise/SL/XCM_Manual_1323197_1661000_Egypt_SR_EG_CP_NT_SL_WomensMainPage_WomenWatchesSmart_3868574_440x440_en_AE.jpg",
            Price=120},
            new Product{Id=3 ,Name="Watch 3", Description="Some quick example text to build on the card title and make up the bulk of the card's content.",
            ImageUrl="https://images-eu.ssl-images-amazon.com/images/G/42/Sunrise/SL/XCM_Manual_1323197_1661000_Egypt_SR_EG_CP_NT_SL_WomensMainPage_WomenWatchesSmart_3868574_440x440_en_AE.jpg",
            Price=130},
            new Product{Id=4 ,Name="Watch 4", Description="Some quick example text to build on the card title and make up the bulk of the card's content.",
            ImageUrl="https://images-eu.ssl-images-amazon.com/images/G/42/Sunrise/SL/XCM_Manual_1323197_1661000_Egypt_SR_EG_CP_NT_SL_WomensMainPage_WomenWatchesSmart_3868574_440x440_en_AE.jpg",
            Price=140},
            new Product{Id=5 ,Name="Watch 5", Description="Some quick example text to build on the card title and make up the bulk of the card's content.",
            ImageUrl="https://images-eu.ssl-images-amazon.com/images/G/42/Sunrise/SL/XCM_Manual_1323197_1661000_Egypt_SR_EG_CP_NT_SL_WomensMainPage_WomenWatchesSmart_3868574_440x440_en_AE.jpg",
            Price=150},
            new Product{Id=6 ,Name="Watch 6", Description="Some quick example text to build on the card title and make up the bulk of the card's content.",
            ImageUrl="https://images-eu.ssl-images-amazon.com/images/G/42/Sunrise/SL/XCM_Manual_1323197_1661000_Egypt_SR_EG_CP_NT_SL_WomensMainPage_WomenWatchesSmart_3868574_440x440_en_AE.jpg",
            Price=160},
        };
    }
}