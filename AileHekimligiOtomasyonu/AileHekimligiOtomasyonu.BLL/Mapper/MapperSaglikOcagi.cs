using AileHekimligiOtomasyonu.BLL.Model;
using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Mapper
{
    public class MapperSaglikOcagi
    {
        public static SaglikOcagi ConvertToSaglikOcagi(SaglikOcagiModel som)
        {
            SaglikOcagi s = new SaglikOcagi();
            s.Doktors = som.Doktors;
            s.SaglikOcagiAd = som.SaglikOcagiAd;
            s.SaglikOcagiAdres = som.SaglikOcagiAdres;
            s.SaglikOcagiId = som.SaglikOcagiId;
            return s;
        }

        public static SaglikOcagiModel ConvertToSaglikOcagiModel(SaglikOcagi som)
        {
            SaglikOcagiModel s = new SaglikOcagiModel();
            s.Doktors = som.Doktors;
            s.SaglikOcagiAd = som.SaglikOcagiAd;
            s.SaglikOcagiAdres = som.SaglikOcagiAdres;
            s.SaglikOcagiId = som.SaglikOcagiId;
            return s;
        }
    }
}
