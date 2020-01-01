﻿using AileHekimligiOtomasyonu.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.BLL.Interfaces
{
    interface ITaniBLL
    {
        void Kaydet(TaniModel model);
        void Guncelle(TaniModel model);
        void Sil(int id);
        List<TaniModel> Listele();
    }
}
