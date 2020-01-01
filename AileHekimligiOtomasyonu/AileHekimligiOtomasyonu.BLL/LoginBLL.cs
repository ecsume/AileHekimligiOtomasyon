using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.BLL.Interfaces;
using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.BLL
{
    public class LoginBLL : ILoginBLL
    {
        public void Guncelle(LoginModel model)
        {
            var login = Mapper.MapperLogin.ConvertToLogin(model);
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.Update(login);
        }

        public void Kaydet(LoginModel model)
        {
            var login = Mapper.MapperLogin.ConvertToLogin(model);
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.Add(login);
        }

        public List<LoginModel> Listele()
        {
            LoginDAL loginDAL = new LoginDAL();
            var Llist = loginDAL.List();

            List<LoginModel> List = new List<LoginModel>();
            foreach (var item in Llist)
            {
                var dm = Mapper.MapperLogin.ConvertToLoginModel(item);

                List.Add(dm);
            }
            return List;
        }

        public void Sil(int id)
        {
            var Login = new Login
            {
                KullaniciID = id
            };
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.Delete(Login);
        }

        public LoginItem Login(string kullaniciAdi, string pass)
        {
            LoginDAL loginDAL = new LoginDAL();
            var kullanici = loginDAL.List().Where(x => x.KullaniciAd == kullaniciAdi && x.KullaniciSifre == pass).FirstOrDefault();
            
            return new LoginItem
            {
                GirisId = kullanici == null ? -1 : kullanici.GirisID,
                Tip = kullanici == null ? -1 : kullanici.Tip
            };
        }


    }

    public class LoginItem
    {
        public int GirisId { get; set; }
        public int Tip { get; set; }
    }
}
