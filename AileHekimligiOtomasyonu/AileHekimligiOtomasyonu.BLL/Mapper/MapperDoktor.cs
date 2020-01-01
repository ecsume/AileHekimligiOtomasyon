using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;
using AileHekimligiOtomasyonu.BLL.Model;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public static class MapperDoktor
    {
        public static Doktor ConvertToDoktor(DoktorModel dm)
        {
            Doktor d = new Doktor();
            d.DoktorId = dm.DoktorId;
            d.Ad = dm.Ad;
            d.Soyad = dm.Soyad;
            d.SaglikOcagiId = dm.SaglikOcagiId;
            d.Randevus = dm.Randevus;
            d.Muayenes = dm.Muayenes;
            return d;
        }

        public static DoktorModel ConvertToDoktorModel(Doktor dm)
        {
            DoktorModel d = new DoktorModel();
            d.DoktorId = dm.DoktorId;
            d.Ad = dm.Ad;
            d.Soyad = dm.Soyad;
            d.SaglikOcagi = dm.SaglikOcagi;
            d.SaglikOcagiId = dm.SaglikOcagiId;
            d.Randevus = dm.Randevus;
            d.Muayenes = dm.Muayenes;
            return d;
        }
    }
}
