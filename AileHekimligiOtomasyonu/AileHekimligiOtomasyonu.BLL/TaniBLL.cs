using AileHekimligiOtomasyonu.BLL.Interfaces;
using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL
{
   public class TaniBLL : ITaniBLL
    {
        public void Guncelle(TaniModel model)
        {
            var Tani = Mapper.MapperTani.ConvertToTani(model);
            TaniDAL taniDAL = new TaniDAL();
            taniDAL.Update(Tani);
        }

        public void Kaydet(TaniModel model)
        {
            var Tani = Mapper.MapperTani.ConvertToTani(model);
            TaniDAL taniDAL = new TaniDAL();
            taniDAL.Add(Tani);
        }

        public List<TaniModel> Listele()
        {
            TaniDAL taniDAL = new TaniDAL();
            var TaniListe = taniDAL.List();
            List<TaniModel> List = new List<TaniModel>();
            foreach (var item in TaniListe)
            {
                var k = Mapper.MapperTani.ConvertToTaniModel(item);
                List.Add(k);
            }return List;
        }

        public void Sil(int id)
        {
            var Tani = new Tani
            {
                TaniId = id
            };
            TaniDAL taniDAL = new TaniDAL();
            taniDAL.Delete(Tani);
        }
    }
}
