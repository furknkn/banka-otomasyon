using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    interface IHavaleYapabilen
    {
        Boolean Havale(Hesap h, decimal para,HesapOzeti ha,HesapOzeti h1,string a);
    }
}
