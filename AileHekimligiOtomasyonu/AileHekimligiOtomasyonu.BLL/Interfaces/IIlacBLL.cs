using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    interface IIlacBLL
    {
        void Kaydet(IlacModel model);
        void Guncelle(IlacModel model);
        void Sil(int id);
        List<IlacModel> Listele();
    }
}
