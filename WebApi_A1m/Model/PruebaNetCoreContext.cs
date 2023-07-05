
using Microsoft.EntityFrameworkCore;
using WebApi_A1m.Model;

namespace MCLothesPro.Modelo
{
   
    public partial class PruebaNetCoreContex : DbContext
    {
        public PruebaNetCoreContex()
        {
        }

        public PruebaNetCoreContex(DbContextOptions<PruebaNetCoreContex> options)
            : base(options)
        {
        }

        public virtual DbSet<dbProducto> TbProductos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=sql5106.site4now.net;Initial Catalog=db_a9ac4e_mclothes;User Id=db_a9ac4e_mclothes_admin;Password=1234ROPA");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dbProducto>(entity =>
            {
                _ = entity.HasKey(e => e.Id).HasName("");

                entity.ToTable("TB_Productos");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PRODUCTO");

                entity.Property(e => e.DescripcionCorta)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_CORTA");

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_PRODUCTO");

                entity.Property(e => e.precio)
                    .HasColumnType("money")
                    .HasColumnName("PRECIO");

                entity.Property(e => e.ImagenUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEN_URL");

                entity.Property(e => e.CategoriaId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORIA_ID");

                entity.Property(e => e.CTipoAplicaionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CTIPO_APLICACION_ID");
            }); 
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }











}
