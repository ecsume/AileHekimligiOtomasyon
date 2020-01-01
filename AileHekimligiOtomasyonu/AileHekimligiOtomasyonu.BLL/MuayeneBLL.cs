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
    public class MuayeneBLL : IMuayeneBLL
    {
        public void Guncelle(MuayeneModel model)
        {
            var muayene = Mapper.MapperMuayene.ConvertToMuayene(model);
            MuayeneDAL muayeneDAL = new MuayeneDAL();
            muayeneDAL.Update(muayene);
        }

        public void Kaydet(MuayeneModel model)
        {
            var muayene = Mapper.MapperMuayene.ConvertToMuayene(model);
            MuayeneDAL muayeneDAL = new MuayeneDAL();
            muayeneDAL.Add(muayene);
        }

        public List<MuayeneModel> Listele()
        {
            MuayeneDAL muayeneDAL = new MuayeneDAL();
            var Mlist = muayeneDAL.List();

            List<MuayeneModel> List = new List<MuayeneModel>();
            foreach (var item in Mlist)
            {
                var dm = Mapper.MapperMuayene.ConvertToMuayeneModel(item);
                List.Add(dm);
            }
            return List;
        }

        public void Sil(int id)
        {
            var muayene = new Muayene
            {
                MuayeneId = id
            };
            MuayeneDAL muayeneDAL = new MuayeneDAL();
            muayeneDAL.Delete(muayene);
        }

        public List<MuayeneList> GridListe()
        {
            MuayeneDAL muayeneDAL = new MuayeneDAL();
            var list = muayeneDAL.List().Select(x => new MuayeneList
            {
                DoktorAdi = $"{x.Doktor.Ad} {x.Doktor.Soyad}",
                HastaAdi = $"{x.Hasta.Adi} {x.Hasta.Soyadi}",
                Ilac = x.Ilac.IlacAdi,
                Sikayet = x.Sikayet,
                MuayeneId = x.MuayeneId,
                Tani = x.Tani.Aciklama

            }).ToList();

            return list;
        }
    }

    public class MuayeneList
    {
        public int MuayeneId { get; set; }
        public string DoktorAdi { get; set; }
        public string HastaAdi { get; set; }
        public string Tani { get; set; }
        public string Ilac { get; set; }
        public string Sikayet { get; set; }

    }
}
