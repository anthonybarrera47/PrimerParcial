using PrimerParcial.DAL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.BLL
{
    public class VendedorBLL
    {
        public static bool Guardar(Vendedor vendedor)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if(contexto.vendedor.Add(vendedor)!=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
                
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(vendedor).State = System.Data.Entity.EntityState.Modified;
                if(contexto.SaveChanges()>0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Vendedor vendedor = contexto.vendedor.Find(id);
                contexto.vendedor.Remove(vendedor);
                if(contexto.SaveChanges()>0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        public static Vendedor Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Vendedor vendedor = new Vendedor();
            try
            {
                vendedor = contexto.vendedor.Find(id);
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return vendedor;
        }
        public static List<Vendedor> GetList(Expression<Func<Vendedor,bool>>expression)
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            Contexto contexto = new Contexto();
            try
            {
                vendedores = contexto.vendedor.Where(expression).ToList();
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return vendedores;
        }
    }
}
