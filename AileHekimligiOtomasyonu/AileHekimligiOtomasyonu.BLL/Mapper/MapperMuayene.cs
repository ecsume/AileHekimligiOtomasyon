using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public class MapperMuayene
    {
        public static Muayene ConvertToMuayene(MuayeneModel mm)
        {
            var muayene = new Muayene();
            muayene.Doktor = mm.Doktor;
            muayene.DoktorId = mm.DoktorId;
            muayene.Hasta = mm.Hasta;
            muayene.HastaId = mm.HastaId;
            muayene.Ilac = mm.Ilac;
            muayene.IlacId = mm.IlacId;
            muayene.MuayeneId = mm.MuayeneId;
            muayene.Sikayet = mm.Sikayet;
            muayene.Tani = mm.Tani;
            muayene.TaniId = mm.TaniId;
            return muayene;
        }

        public static MuayeneModel ConvertToMuayeneModel(Muayene mm)
        {
            var muayene = new MuayeneModel();
            muayene.Doktor = mm.Doktor;
            muayene.DoktorId = mm.DoktorId;
            muayene.Hasta = mm.Hasta;
            muayene.HastaId = mm.HastaId;
            muayene.Ilac = mm.Ilac;
            muayene.IlacId = mm.IlacId;
            muayene.MuayeneId = mm.MuayeneId;
            muayene.Sikayet = mm.Sikayet;
            muayene.Tani = mm.Tani;
            muayene.TaniId = mm.TaniId;
            return muayene;
        }
    }
}
