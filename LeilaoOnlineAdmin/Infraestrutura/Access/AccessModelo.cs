using Infraestrutura.Database;
using Infraestrutura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestrutura.Access
{
    public class AccessModelo
    {
        public AccessModelo()
        {

        }

        public void Gravar(ModelModelo model)
        {
            try
            {
                using (var context = new DataContext())
                {
                    context.Add(model);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        public ModelModelo Ler(int id)
        {
            using (var context = new DataContext())
            {
                return context.Models.Where(o => o.Id == id).SingleOrDefault();
            }
        }

        public List<ModelModelo> Listar(int id)
        {
            using (var context = new DataContext())
            {
                return (from ci in context.Models
                            //where ci.Id == id
                        select ci).ToList();
            }
        }
    }
}
