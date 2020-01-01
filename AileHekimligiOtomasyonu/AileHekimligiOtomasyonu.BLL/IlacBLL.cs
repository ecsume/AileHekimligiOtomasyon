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
    public class IlacBLL : IIlacBLL
    {
        public void Guncelle(IlacModel model)
        {
            var ilac = Mapper.MapperIlac.ConvertToIlac(model);

            IlacDAL IlacDAL = new IlacDAL();

            IlacDAL.Update(ilac);
        }

        public void Kaydet(IlacModel model)
        {
            var ilac = Mapper.MapperIlac.ConvertToIlac(model);
            IlacDAL IlacDAL = new IlacDAL();
            IlacDAL.Add(ilac);
        }

        public List<IlacModel> Listele()
        {
            IlacDAL ilacDAL = new IlacDAL();
            var Ilist = ilacDAL.List();

            List<IlacModel> List = new List<IlacModel>();
            foreach (var item in Ilist)
            {
                var dm = Mapper.MapperIlac.ConvertToIlacModel(item);
                List.Add(dm);
            }
            return List;
        }

        public void Sil(int id)
        {
            var Ilac = new Ilac
            {
                IlacId = id
            };
            IlacDAL IlacDAL = new IlacDAL();
            IlacDAL.Delete(Ilac);
        }
    }
}
