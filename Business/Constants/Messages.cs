using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string UnitPriceInvalid = "Ürün fiyatı geçersiz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Aynı ürün ismi zaten var";
        public static string OutOfCategoryCount = "Kategori sayısı çok fazla";
        public static string CategoryLimitExceded = "Kategori Sayisi Aşıldı";
        public static string AuthorizationDenied = "Yetki Sağlanamadı";
        public static string UserRegistered = "Kullanıcı Kaydı Başarılı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Yanlış";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Böyle bir kullanıcı var";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
