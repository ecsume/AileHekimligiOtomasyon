using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface ILogin
    {
        Login Add(Login l);
        Login Update(Login l);
        bool Delete(Login l);
        List<Login> List();
    }
}
