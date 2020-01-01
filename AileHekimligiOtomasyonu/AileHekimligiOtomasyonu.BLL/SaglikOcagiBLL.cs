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
    public class SaglikOcagiBLL : ISaglikOcagiBLL
    {
        public void Guncelle(SaglikOcagiModel model)
        {
            var k = Mapper.MapperSaglikOcagi.ConvertToSaglikOcagi(model);
            SaglikOcagiDAL sagliocagiDAL = new SaglikOcagiDAL();
            sagliocagiDAL.Update(k);
        }

        public void Kaydet(SaglikOcagiModel model)
        {
            var k = Mapper.MapperSaglikOcagi.ConvertToSaglikOcagi(model);
            SaglikOcagiDAL saglikocagiDAL = new SaglikOcagiDAL();
            saglikocagiDAL.Add(k);
        }

        public List<SaglikOcagiModel> Listele()
        {
            SaglikOcagiDAL saglikOcagiDAL = new SaglikOcagiDAL();
            var Saglikocagilistesi = saglikOcagiDAL.List();
            List<SaglikOcagiModel> List = new List<SaglikOcagiModel>();
            foreach (var item in Saglikocagilistesi)
            {
                var k = Mapper.MapperSaglikOcagi.ConvertToSaglikOcagiModel(item);
                List.Add(k);
            }return List;
        }

        public void Sil(int id)
        {
            SaglikOcagi saglikocagi = new SaglikOcagi
            {
                SaglikOcagiId = id
            };
            SaglikOcagiDAL saglikocagiDAL = new SaglikOcagiDAL();
            saglikocagiDAL.Delete(saglikocagi);
        }
    }
}
