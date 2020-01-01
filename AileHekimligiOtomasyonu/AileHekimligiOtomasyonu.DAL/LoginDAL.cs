using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Interface;
using AileHekimligiOtomasyonu.DAL.Entity;
using System.Data.Entity;

namespace AileHekimligiOtomasyonu.DAL
{
    public class LoginDAL : ILogin
    {
        public Login Add(Login l)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Logins.Add(l);
                a.SaveChanges();
                return l;
            }
        }

        public bool Delete(Login l)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var result = a.Logins.Find(l.KullaniciID);
                a.Logins.Remove(result);
                a.SaveChanges();
                return true;
            }

        }

        public List<Login> List()
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var KullaniciListesi = a.Logins.ToList();
                List<Login> liste = new List<Login>();
                foreach (var item in KullaniciListesi)
                {
                    Login lg = new Login();
                    lg.KullaniciID = item.KullaniciID;
                    lg.KullaniciAd = item.KullaniciAd;
                    lg.KullaniciSifre = item.KullaniciSifre;
                    lg.Tip = item.Tip;
                    lg.GirisID = item.GirisID;
                    liste.Add(lg);
                } return liste;

            }
        }

        public Login Update(Login l)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Entry(l).State = EntityState.Modified;
                a.SaveChanges();
                return l;
            }
        }
    }
}
