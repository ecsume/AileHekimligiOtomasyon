using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    interface IHastaBLL
    {
        int Kaydet(HastaModel model);
        void Guncelle(HastaModel model);
        void Sil(int id);
        List<HastaModel> Listele();
    }
}
