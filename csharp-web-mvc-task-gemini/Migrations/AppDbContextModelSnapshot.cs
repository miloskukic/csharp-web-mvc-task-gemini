// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_web_mvc_task_gemini.Data;

namespace csharp_web_mvc_task_gemini.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("csharp_web_mvc_task_gemini.Models.Radnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("BrutoPlata")
                        .HasColumnType("real");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NetoPlata")
                        .HasColumnType("real");

                    b.Property<float>("Nezaposlenost")
                        .HasColumnType("real");

                    b.Property<float>("NezaposlenostPoslodavac")
                        .HasColumnType("real");

                    b.Property<float>("PIO")
                        .HasColumnType("real");

                    b.Property<float>("PIOPoslodavac")
                        .HasColumnType("real");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UkupniTroskovi")
                        .HasColumnType("real");

                    b.Property<float>("Zdravstveno")
                        .HasColumnType("real");

                    b.Property<float>("ZdravstvenoPoslodavac")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Radnici");
                });
#pragma warning restore 612, 618
        }
    }
}
