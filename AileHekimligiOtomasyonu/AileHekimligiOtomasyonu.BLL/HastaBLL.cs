using AileHekimligiOtomasyonu.BLL.Interfaces;
using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL
{
    public class HastaBLL : IHastaBLL
    {

        public void Guncelle(HastaModel model)
        {
            var hasta = Mapper.MapperHasta.ConverttoHasta(model);
            HastaDAL HastaDAL = new HastaDAL();
            HastaDAL.Update(hasta);
        }

        public int Kaydet(HastaModel model)
        {
            var hasta = Mapper.MapperHasta.ConverttoHasta(model);
            HastaDAL hastaDAL = new HastaDAL();
            hastaDAL.Add(hasta);
            return hasta.HastaId;
        }

        public List<HastaModel> Listele()
        {
            HastaDAL hastaDAL = new HastaDAL();
            var list = hastaDAL.List();
            List<HastaModel> hlist = new List<HastaModel>();
            foreach (var item in list)
            {
                var hm= Mapper.MapperHasta.ConverttoHastaModel(item);
                hlist.Add(hm);
            }return hlist;
        }

        public void Sil(int id)
        {
            Hasta hasta = new Hasta
            { HastaId = id };
            HastaDAL hastaDAL = new HastaDAL();
            hastaDAL.Delete(hasta);
        }
    }
}
