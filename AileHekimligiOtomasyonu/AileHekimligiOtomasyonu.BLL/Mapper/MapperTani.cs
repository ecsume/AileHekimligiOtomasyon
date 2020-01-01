using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public class MapperTani
    {
        public static Tani ConvertToTani(TaniModel tm)
        {
            var t = new Tani();
            t.Aciklama = tm.Aciklama;
            t.TaniId = tm.TaniId;
            return t;
        }

        public static TaniModel ConvertToTaniModel(Tani tm)
        {
            var t = new TaniModel();
            t.Aciklama = tm.Aciklama;
            t.TaniId = tm.TaniId;
            return t;
        }
    }
}
