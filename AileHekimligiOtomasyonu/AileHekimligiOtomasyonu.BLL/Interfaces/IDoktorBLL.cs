using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    public interface IDoktorBLL
    {
        int Kaydet(DoktorModel model);
        void Guncelle(DoktorModel model);
        void Sil(int id);
        List<DoktorModel> Listele();
        List<DoktorModelList> DoktorListele();

    }
}
