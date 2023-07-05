

namespace WebApi_A1m.Model
{
    public class dbProducto
    {
        public int Id { get; set; } 
        public string NombreProducto { get; set; }    
        public string DescripcionCorta { get; set;}
        
        public string DescripcionProducto { get; set;} 
        public double precio { get; set; }
        public string ImagenUrl { get; set; }   
        public string CategoriaId { get; set; }
        
        public string CTipoAplicaionId { get; set; }
    }
}
