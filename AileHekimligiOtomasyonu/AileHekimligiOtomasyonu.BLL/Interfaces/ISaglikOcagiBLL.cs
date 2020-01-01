using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    interface ISaglikOcagiBLL
    {
        void Kaydet(SaglikOcagiModel model);
        void Guncelle(SaglikOcagiModel model);
        void Sil(int id);
        List<SaglikOcagiModel> Listele();
    }
}
