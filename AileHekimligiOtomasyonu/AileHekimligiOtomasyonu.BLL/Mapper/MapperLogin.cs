using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public class MapperLogin
    {
        public static Login ConvertToLogin(LoginModel l)
        {
            var login = new Login();
            login.KullaniciID = l.KullaniciID;
            login.KullaniciAd = l.KullaniciAd;
            login.KullaniciSifre = l.KullaniciSifre;
            login.Tip = l.Tip;
            login.GirisID = l.GirisID;
            return login;
        }

        public static LoginModel ConvertToLoginModel(Login l)
        {
            var login = new LoginModel();
            login.KullaniciID = l.KullaniciID;
            login.KullaniciAd = l.KullaniciAd;
            login.KullaniciSifre = l.KullaniciSifre;
            login.Tip = l.Tip;
            return login;
        }
    }
}
