using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEmpregado
{
    internal class Mensalista : Empregado
    {
        public Double SalarioMensal {  get; set; }

        //sobrescrevendo o metodo
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
