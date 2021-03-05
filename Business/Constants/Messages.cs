using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
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
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isismde zaten baska bir urun var.";
        public static string CategoryLimitExceded="category limiti aşıldığı için yeni ürün eklenemez.";
        public static string AuthorizationDenied="Yetkiniz Yok.";
        public static string UserRegistered="User Registered";
        public static string UserAlreadyExists="user already exist";
        public static string SuccessfulLogin="successful login";
        public static string PasswordError="Password Error";
        public static string UserNotFound="user not found";
        public static string AccessTokenCreated="access token created";
    }
}
