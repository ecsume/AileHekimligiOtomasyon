using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface ISaglikOcagi
    {
        SaglikOcagi Add(Entity.SaglikOcagi s);
        SaglikOcagi Update(SaglikOcagi s);
        bool Delete(SaglikOcagi s);
        List<SaglikOcagi> List();
    }
}
