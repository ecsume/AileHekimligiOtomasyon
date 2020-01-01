using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    interface ILoginBLL
    {
        void Kaydet(LoginModel model);
        void Guncelle(LoginModel model);
        void Sil(int id);
        List<LoginModel> Listele();
    }
}
