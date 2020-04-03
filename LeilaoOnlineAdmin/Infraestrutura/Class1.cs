//using System;

using Infraestrutura.Access;
using Infraestrutura.Model;
using System;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public class Class1
    {
        public void Main()
        {
            //PessoaFisica obj = new PessoaFisica();
            //PessoaFisicaAccess dao = new PessoaFisicaAccess();
            ModelModelo obj = new ModelModelo();
            AccessModelo dao = new AccessModelo();

            //obj.Nome = "Patrik";
            //obj.NomeMae = "Mãe";
            //obj.NomePai = "Pai";
            //obj.Rg = "RG";
            ////obj.Cpf = "703.111.222-23";
            obj.Nome = "Teste";

            dao.Gravar(obj);
        }
    }
}
