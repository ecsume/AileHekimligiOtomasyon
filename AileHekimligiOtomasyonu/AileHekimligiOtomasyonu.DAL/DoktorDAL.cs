using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;
using AileHekimligiOtomasyonu.DAL.Interface;

namespace AileHekimligiOtomasyonu.DAL
{
    public class DoktorDAL : IDoktor
    {
        public Doktor Add(Doktor D)
        {
            using (AileHekimligidbEntities a=new AileHekimligidbEntities())
            {
                a.Doktors.Add(D);
                a.SaveChanges();
                return D;
            }
        }

        public bool Delete(Doktor D)
        {
            using (AileHekimligidbEntities a=new AileHekimligidbEntities())
            {
                var result = a.Doktors.Find(D.DoktorId);
                a.Doktors.Remove(result);
                a.SaveChanges();
                return true;
            }
        }

        public List<Doktor> List()
        {
            using (AileHekimligidbEntities a=new AileHekimligidbEntities())
            {
                var DoktorListesi = a.Doktors.ToList();
                List<Doktor> liste = new List<Doktor>();
             
                foreach (var item in DoktorListesi)
                {
                    Doktor d = new Doktor();
                    d.DoktorId = item.DoktorId;
                    d.Ad = item.Ad;
                    d.Soyad = item.Soyad;
                    d.SaglikOcagiId = item.SaglikOcagiId;
                    d.SaglikOcagi = item.SaglikOcagi;
                    d.Randevus = item.Randevus;
                    d.Muayenes = item.Muayenes;
                    liste.Add(d);
                } return liste;
            }
        }

        public Doktor Update(Doktor D)
        {
            using (AileHekimligidbEntities a=new AileHekimligidbEntities())
            {
                a.Entry(D).State = EntityState.Modified;
                a.SaveChanges();
                return D;
            }
        }
    }
}
