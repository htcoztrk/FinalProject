using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    //new lemeyeceğiz buyüzden statik yaptık. tek tip olarak kalacak.
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "invalid product name";
        public static string MaintenanceTime="Sisem bakımda";
        public static string ProductsListed="Urunler listelendi";
        internal static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        internal static string ProductNameAlreadyExists="Bu isismde zaten baska bir urun var.";
        internal static string CategoryLimitExceded="category limiti aşıldığı için yeni ürün eklenemez.";
    }
}
