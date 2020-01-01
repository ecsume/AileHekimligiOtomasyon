using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface ITani
    {
        Tani Add(Tani t);
        Tani Update(Tani t);
        bool Delete(Tani t);
        List<Tani> List();
    }
}
