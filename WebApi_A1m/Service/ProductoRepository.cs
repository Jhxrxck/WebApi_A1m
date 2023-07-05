using WebApi_A1m.Model;

namespace WebApi_A1m.Service
{
    public class ProductoRepository : IProductoRopa
    {
        /**/
        public static List<dbProducto> lstProducto =
            new List<dbProducto>()

        {
           

        };
        public void Add(dbProducto obj)
        {
            lstProducto.Add(obj);
        }

        public void add(dbProducto obj)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            lstProducto.Remove(ObtenerPorId(id));
        }

        private dbProducto ObtenerPorId(int id)
        {
            return lstProducto.Where(tpro => tpro.Id == id)
                                  .FirstOrDefault();
        }

        public IEnumerable<dbProducto> GetAllProducts()
        {
            return lstProducto;
        }

        public void modificar(dbProducto objPro)
        {
            var obj = lstProducto.Where(tpro => tpro.Id == objPro.Id)
                                 .FirstOrDefault();
            obj.Id = objPro.Id;   
            obj.NombreProducto = objPro.NombreProducto;
            obj.DescripcionProducto = objPro.DescripcionProducto;
            obj.precio = objPro.precio;
            obj.ImagenUrl= objPro.ImagenUrl;
            obj.CategoriaId = objPro.CategoriaId;
            obj.CTipoAplicaionId= objPro.CTipoAplicaionId;
        }

        dbProducto IProductoRopa.ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
