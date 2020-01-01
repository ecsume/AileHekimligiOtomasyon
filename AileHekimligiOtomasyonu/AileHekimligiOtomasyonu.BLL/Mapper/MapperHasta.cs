using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public class MapperHasta
    {
        public static Hasta ConverttoHasta(HastaModel h)
        {
            Hasta hh = new Hasta();
            hh.HastaId = h.HastaId;
            hh.Adi = h.Adi;
            hh.Soyadi = h.Soyadi;
            hh.AnneAd = h.AnneAd;
            hh.BabaAd = h.BabaAd;
            hh.Cinsiyet = h.Cinsiyet;
            hh.DogumTarihi = h.DogumTarihi;
            hh.Email = h.Email;
            hh.Resim = h.Resim;
            hh.TcKimlik = h.TcKimlik;
            return hh;
        }

        public static HastaModel ConverttoHastaModel(Hasta h)
        {
            HastaModel hh = new HastaModel();
            hh.HastaId = h.HastaId;
            hh.Adi = h.Adi;
            hh.Soyadi = h.Soyadi;
            hh.AnneAd = h.AnneAd;
            hh.BabaAd = h.BabaAd;
            hh.Cinsiyet = h.Cinsiyet;
            hh.DogumTarihi = h.DogumTarihi;
            hh.Email = h.Email;
            hh.Resim = h.Resim;
            hh.TcKimlik = h.TcKimlik;
            hh.Randevus = h.Randevus;
            hh.Muayenes = h.Muayenes;
            return hh;
        }
    }
}
