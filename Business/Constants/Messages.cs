using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductGeted = "Ürünler Getirildi";
        public static string ProductDetailsGeted = "Ürün Detayları Listelendi";
        public static string ProductCountOfCategoryError = "Bu Kategoride 15'den fazla  ürün Bulunuyor";
        public static string ProductNameAlreadyExists = "Bu isimde ürün mevcut";

        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted = "Kategori Silindi";
        public static string CategoryUpdated = "Kategori Güncellendi";
        public static string CategoryGeted = "Kategoriler Getirildi";

        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı Adı veya Şifre Hatalı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Böyle Bir Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
