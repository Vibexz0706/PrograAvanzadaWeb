
using Microsoft.EntityFrameworkCore;

namespace Entities.Entities;

public partial class PrograWebContext : DbContext
{
    public PrograWebContext()
    {

    }

    public PrograWebContext(DbContextOptions<PrograWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<UsuarioAplicacion> UsuarioAplicacion { get; set; } 

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<TabCurso> TabCursos { get; set; }

    public virtual DbSet<TabCursoImpartir> TabCursoImpartirs { get; set; }

    public virtual DbSet<TabEstado> TabEstados { get; set; }

    public virtual DbSet<TabEstudiante> TabEstudiantes { get; set; }

    public virtual DbSet<TabHorario> TabHorarios { get; set; }

    public virtual DbSet<TabIngrediente> TabIngredientes { get; set; }

    public virtual DbSet<TabInstruccion> TabInstruccions { get; set; }

    public virtual DbSet<TabMatricula> TabMatriculas { get; set; }

    public virtual DbSet<TabProfesor> TabProfesors { get; set; }

    public virtual DbSet<TabReceta> TabReceta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=PrograWeb;Integrated Security=True;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TabCurso>(entity =>
        {
            entity.HasKey(e => e.IdCurso).HasName("PK_TAB_CURSO");

            entity.ToTable("TabCurso");

            entity.Property(e => e.IdCurso).HasColumnName("ID_CURSO");
            entity.Property(e => e.Curso)
                .HasMaxLength(50)
                .HasColumnName("CURSO");
            entity.Property(e => e.FechaFin).HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio).HasColumnName("FECHA_INICIO");
            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.IdHorario).HasColumnName("ID_HORARIO");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.TabCursos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK_TAB_CURSO_TAB_ESTADO");

            entity.HasOne(d => d.IdHorarioNavigation).WithMany(p => p.TabCursos)
                .HasForeignKey(d => d.IdHorario)
                .HasConstraintName("FK_TAB_CURSO_TAB_HORARIO");
        });

        modelBuilder.Entity<TabCursoImpartir>(entity =>
        {
            entity.HasKey(e => e.IdCursoImpartir).HasName("PK_TAB_CURSO_IMPARTIR");

            entity.ToTable("TabCursoImpartir");

            entity.Property(e => e.IdCursoImpartir)
                .ValueGeneratedNever()
                .HasColumnName("ID_CURSO_IMPARTIR");
            entity.Property(e => e.IdCurso).HasColumnName("ID_CURSO");
            entity.Property(e => e.IdProfesor).HasColumnName("ID_PROFESOR");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.TabCursoImpartirs)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK_TAB_CURSO_IMPARTIR_TAB_PROFESOR");
        });

        modelBuilder.Entity<TabEstado>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK_TAB_ESTADO");

            entity.ToTable("TabEstado");

            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasColumnName("ESTADO");
        });

        modelBuilder.Entity<TabEstudiante>(entity =>
        {
            entity.HasKey(e => e.IdEstudiante).HasName("PK_TAB_ESTUDIANTE");

            entity.ToTable("TabEstudiante");

            entity.Property(e => e.IdEstudiante).HasColumnName("ID_ESTUDIANTE");
            entity.Property(e => e.ApellidoMat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_MAT");
            entity.Property(e => e.ApellidoPat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_PAT");
            entity.Property(e => e.Cedula)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.FechaNacimiento).HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<TabHorario>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK_TAB_HORARIO");

            entity.ToTable("TabHorario");

            entity.Property(e => e.IdHorario).HasColumnName("ID_HORARIO");
            entity.Property(e => e.Horario)
                .HasMaxLength(50)
                .HasColumnName("HORARIO");
        });

        modelBuilder.Entity<TabIngrediente>(entity =>
        {
            entity.HasKey(e => e.IdIngredientes).HasName("PK_TAB_INGREDIENTE");

            entity.ToTable("TabIngrediente");

            entity.Property(e => e.IdIngredientes).HasColumnName("ID_INGREDIENTES");
            entity.Property(e => e.IdReceta).HasColumnName("ID_RECETA");
            entity.Property(e => e.Ingrediente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INGREDIENTE");

            entity.HasOne(d => d.IdRecetaNavigation).WithMany(p => p.TabIngredientes)
                .HasForeignKey(d => d.IdReceta)
                .HasConstraintName("FK_TAB_INGREDIENTE_TAB_RECETA");
        });

        modelBuilder.Entity<TabInstruccion>(entity =>
        {
            entity.HasKey(e => e.IdInstrucciones).HasName("PK_TAB_INSTRUCCION");

            entity.ToTable("TabInstruccion");

            entity.Property(e => e.IdInstrucciones).HasColumnName("ID_INSTRUCCIONES");
            entity.Property(e => e.IdReceta).HasColumnName("ID_RECETA");
            entity.Property(e => e.Instruccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INSTRUCCION");

            entity.HasOne(d => d.IdRecetaNavigation).WithMany(p => p.TabInstruccions)
                .HasForeignKey(d => d.IdReceta)
                .HasConstraintName("FK_TAB_INSTRUCCION_TAB_RECETA");
        });

        modelBuilder.Entity<TabMatricula>(entity =>
        {
            entity.HasKey(e => e.IdMatricula).HasName("PK_TAB_MATRICULA");

            entity.ToTable("TabMatricula");

            entity.Property(e => e.IdMatricula).HasColumnName("ID_MATRICULA");
            entity.Property(e => e.IdCurso).HasColumnName("ID_CURSO");
            entity.Property(e => e.IdEstudiante).HasColumnName("ID_ESTUDIANTE");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.TabMatriculas)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK_TAB_MATRICULA_TAB_CURSO");
        });

        modelBuilder.Entity<TabProfesor>(entity =>
        {
            entity.HasKey(e => e.IdProfesor).HasName("PK_TAB_PROFESOR");

            entity.ToTable("TabProfesor");

            entity.Property(e => e.IdProfesor)
                .ValueGeneratedNever()
                .HasColumnName("ID_PROFESOR");
            entity.Property(e => e.ApellidoMat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_MAT");
            entity.Property(e => e.ApellidoPat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_PAT");
            entity.Property(e => e.Cedula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.FechaNacimiento).HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<TabReceta>(entity =>
        {
            entity.HasKey(e => e.IdReceta).HasName("PK_TAB_RECETA");

            entity.Property(e => e.IdReceta).HasColumnName("ID_RECETA");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.FechaCreacion).HasColumnName("FECHA_CREACION");
            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.NomReceta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_RECETA");
            entity.Property(e => e.Porciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PORCIONES");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.TabReceta)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK_TAB_RECETA_TAB_ESTADO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
