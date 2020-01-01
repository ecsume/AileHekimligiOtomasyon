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
    public class RandevuBLL : IRandevuBLL
    {
        public void Guncelle(RandevuModel model)
        {
            var randevu = Mapper.MapperRandevu.ConvertToRandevu(model);
            RandevuDAL randevuDAL = new RandevuDAL();
            randevuDAL.Update(randevu);
        }

        public void Kaydet(RandevuModel model)
        {
            var randevu = Mapper.MapperRandevu.ConvertToRandevu(model);
            RandevuDAL randevuDAL = new RandevuDAL();
            randevuDAL.Add(randevu);
        }

        public List<RandevuModel> Listele()
        {
            RandevuDAL randevuDAL = new RandevuDAL();
            var Randevulistesi = randevuDAL.List();
            List<RandevuModel> List = new List<RandevuModel>();
            foreach (var item in Randevulistesi)
            {
                var k = Mapper.MapperRandevu.ConvertToRandevuModel(item);
                List.Add(k);
            }
            return List;
        }

        public List<RandevuRaporList> BugununRandevuListesi()
        {
            RandevuDAL randevuDAL = new RandevuDAL();
            var basTar = DateTime.Now.Date;
            var bitTar = DateTime.Now.AddDays(1);
            var randevuList = randevuDAL.List()
                .Where(x => x.RandevuTarihi >= basTar && x.RandevuTarihi < bitTar)
                .Select(x => new RandevuRaporList
                {
                    HastaAdi = $"{x.Hasta.Adi} { x.Hasta.Soyadi}",
                    DoktorAdi = $"{x.Doktor.Ad} { x.Doktor.Soyad}",
                    RandevuTarihi = x.RandevuTarihi
                }).ToList();

            return randevuList;
        }

        public List<RandevuRaporList> HastaGecmisRandevu(int hastaId)
        {
            RandevuDAL randevuDAL = new RandevuDAL();
            var randevuList = randevuDAL.List()
                .Where(x => x.HastaId == hastaId)
                .Select(x => new RandevuRaporList
                {
                    HastaAdi = $"{x.Hasta.Adi} { x.Hasta.Soyadi}",
                    DoktorAdi = $"{x.Doktor.Ad} { x.Doktor.Soyad}",
                    RandevuTarihi = x.RandevuTarihi
                }).ToList();

            return randevuList;
        }

        public void Sil(int id)
        {
            Randevu randevu = new Randevu
            {
                RandevuId = id
            };
            RandevuDAL randevuDAL = new RandevuDAL();
            randevuDAL.Delete(randevu);
        }
    }

    public class RandevuRaporList
    {
        public string DoktorAdi { get; set; }
        public string HastaAdi { get; set; }
        public DateTime RandevuTarihi { get; set; }
    }
}
