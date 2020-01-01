using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    interface IMuayeneBLL
    {
        void Kaydet(MuayeneModel model);
        void Guncelle(MuayeneModel model);
        void Sil(int id);
        List<MuayeneModel> Listele();
    }
}
