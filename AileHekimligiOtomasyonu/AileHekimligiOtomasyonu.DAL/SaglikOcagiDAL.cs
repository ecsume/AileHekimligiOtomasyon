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
    public class SaglikOcagiDAL : ISaglikOcagi
    {
        public SaglikOcagi Add(SaglikOcagi s)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.SaglikOcagis.Add(s);
                a.SaveChanges();
                return s;
            }
        }

        public bool Delete(SaglikOcagi s)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var result = a.SaglikOcagis.Find(s.SaglikOcagiId);
                a.SaglikOcagis.Remove(result);
                a.SaveChanges();
                return true;
            }
        }

        public List<SaglikOcagi> List()
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                var Solistesi = a.SaglikOcagis.ToList();
                List<SaglikOcagi> liste = new List<SaglikOcagi>();
                foreach (var item in Solistesi)
                {
                    SaglikOcagi so = new SaglikOcagi();
                    so.SaglikOcagiId = item.SaglikOcagiId;
                    so.SaglikOcagiAdres = item.SaglikOcagiAdres;
                    so.SaglikOcagiAd = item.SaglikOcagiAd;
                    so.Doktors = item.Doktors;
                    liste.Add(so);
                }return liste;
            }
        }

        public SaglikOcagi Update(SaglikOcagi s)
        {
            using (AileHekimligidbEntities a = new AileHekimligidbEntities())
            {
                a.Entry(s).State = EntityState.Modified;
                a.SaveChanges();
                return s;
            }
        }
    }
}
