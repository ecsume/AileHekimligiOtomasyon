using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public class MapperIlac
    {
        public static Ilac ConvertToIlac(IlacModel i)
        {
            var ilac = new Ilac();
            ilac.IlacId = i.IlacId;
            ilac.IlacAdi = i.IlacAdi;
            ilac.Dozaj = i.Dozaj;
            ilac.KullanimSuresi = i.KullanimSuresi;
            ilac.Muayenes = i.Muayenes;
            return ilac;
        }

        public static IlacModel ConvertToIlacModel(Ilac i)
        {
            var ilac = new IlacModel();
            ilac.IlacId = i.IlacId;
            ilac.IlacAdi = i.IlacAdi;
            ilac.Dozaj = i.Dozaj;
            ilac.KullanimSuresi = i.KullanimSuresi;
            ilac.Muayenes = i.Muayenes;
            return ilac;
        }
    }
}
