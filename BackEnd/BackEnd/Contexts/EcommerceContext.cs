using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BackEnd.Contexts;

public class EcommerceContext : IdentityDbContext<ApplicationUser>
{

    public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApplicationUser> Users { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Chat_Message> Chat_Messages { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User_Connection> User_Connections { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-942NCGB\\SQLEXPRESS;Initial Catalog=Ecommerce;Integrated Security=True");


    protected override void OnModelCreating(ModelBuilder builder)
    {
        //modelBuilder.Entity<Cart>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    entity.HasOne(d => d.Product).WithMany(p => p.Carts)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_Carts_Product");
        //});

        //modelBuilder.Entity<Category>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    entity.HasOne(d => d.Parent)
        //    .WithMany(p => p.InverseParent)
        //    .HasForeignKey(c => c.Parent_Id)
        //    .HasConstraintName("FK_Categories_Categories_Parent_Id")
        //    .OnDelete(DeleteBehavior.NoAction);
        //});

        //modelBuilder.Entity<Chat_Message>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedNever();
        //});

        //modelBuilder.Entity<Image>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK_Image");

        //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    entity.HasOne(d => d.Product).WithMany(p => p.Images)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_Image_Products");
        //});

        //modelBuilder.Entity<Permission>(entity =>
        //{
        //    entity.HasIndex(e => e.User_Id, "IX_Permissions_User_Id")
        //        .IsUnique()
        //        .HasFilter("([User_Id] IS NOT NULL)");

        //    entity.Property(e => e.Id).ValueGeneratedNever();
        //});

        //modelBuilder.Entity<Product>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK_Product");

        //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    entity.HasOne(d => d.Category).WithMany(p => p.Products)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_Product_Categories");
        //});

        //modelBuilder.Entity<User_Connection>(entity =>
        //{
        //    entity.HasKey(e => new { e.User_ID, e.Connection_ID }).HasName("PK__User_Con__51B222138C204A39");
        //});

        base.OnModelCreating(builder);
    }
}