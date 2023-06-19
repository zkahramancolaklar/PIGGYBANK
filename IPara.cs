using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public interface IPara
    {
        string Adi { get; set; }
        float Degeri { get; set; }
        double Hacim();
    }
}
