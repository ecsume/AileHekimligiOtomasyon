using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    interface IRandevuBLL
    {
        void Kaydet(RandevuModel model);
        void Guncelle(RandevuModel model);
        void Sil(int id);
        List<RandevuModel> Listele();
    }
}
