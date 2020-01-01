using AileHekimligiOtomasyonu.BLL.Interfaces;
using AileHekimligiOtomasyonu.DAL;
using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.BLL
{
    public class DoktorBLL : IDoktorBLL
    {
        public void Guncelle(DoktorModel model)
        {
            var doktor = Mapper.MapperDoktor.ConvertToDoktor(model);

            DoktorDAL doktorDAL = new DoktorDAL();

            doktorDAL.Update(doktor);
        }

        public int Kaydet(DoktorModel model)
        {
            var doktor = Mapper.MapperDoktor.ConvertToDoktor(model);
            DoktorDAL doktorDAL = new DoktorDAL();
            doktorDAL.Add(doktor);
            return doktor.DoktorId;
        }

        public List<DoktorModel> Listele()
        {
            DoktorDAL doktorDal = new DoktorDAL();
            var dlist= doktorDal.List();

            List<DoktorModel> List = new List<DoktorModel>();
            foreach (var item in dlist)
            {
                var dm = Mapper.MapperDoktor.ConvertToDoktorModel(item);
                List.Add(dm);
            }
            return List;
        }

        public List<DoktorModelList> DoktorListele()
        {
            DoktorDAL doktorDal = new DoktorDAL();
            var dlist = doktorDal.List().Select(x => new DoktorModelList
            {
                Id = x.DoktorId,
                Adi = x.Ad,
                Soyadi = x.Soyad,
                SaglikOcagiAdi = x.SaglikOcagi.SaglikOcagiAd
            }).ToList();

            return dlist;
        }

        public void Sil(int id)
        {
            Doktor doktor = new Doktor { DoktorId = id };
            DoktorDAL doktorDAL = new DoktorDAL();
            doktorDAL.Delete(doktor);
        }

        public bool IsDoktor(int id)
        {
            DoktorDAL doktorDAL = new DoktorDAL();

            return doktorDAL.List().FirstOrDefault(x => x.DoktorId == id) == null ? false : true;
        }
    }

    public class DoktorModelList
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SaglikOcagiAdi { get; set; }

    }
}
