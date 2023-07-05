using WebApi_A1m.Model;

namespace WebApi_A1m.Service
{
    public interface IProductoRopa
    {
        IEnumerable<dbProducto> GetAllProducts();
        dbProducto ObtenerPorId(int id);
        void modificar(dbProducto obj);
        void Add(dbProducto obj);
        void eliminar(int id);
        
    }
}
