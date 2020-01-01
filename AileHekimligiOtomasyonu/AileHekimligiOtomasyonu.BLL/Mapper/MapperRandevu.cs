using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public class MapperRandevu
    {
        public static Randevu ConvertToRandevu(RandevuModel rm)
        {
            var r = new Randevu();
            r.Doktor = rm.Doktor;
            r.DoktorId = rm.DoktorId;
            r.Hasta = rm.Hasta;
            r.HastaId = rm.HastaId;
            r.RandevuId = rm.RandevuId;
            r.RandevuTarihi = rm.RandevuTarihi;
            return r;
        }

        public static RandevuModel ConvertToRandevuModel(Randevu rm)
        {
            var r = new RandevuModel();
            r.Doktor = rm.Doktor;
            r.DoktorId = rm.DoktorId;
            r.Hasta = rm.Hasta;
            r.HastaId = rm.HastaId;
            r.RandevuId = rm.RandevuId;
            r.RandevuTarihi = rm.RandevuTarihi;
            return r;
        }
    }
}
