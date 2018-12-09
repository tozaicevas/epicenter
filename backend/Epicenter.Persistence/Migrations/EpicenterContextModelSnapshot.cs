﻿// <auto-generated />
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Epicenter.Persistence.Migrations
{
    [DbContext(typeof(EpicenterContext))]
    partial class EpicenterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.MissingModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Reason");

                    b.HasKey("ID");

                    b.ToTable("MissingModels");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MissingModel");
                });

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.Timestamp", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateAndTime");

                    b.Property<int>("MissingModelID");

                    b.HasKey("ID");

                    b.HasIndex("MissingModelID");

                    b.ToTable("Timestamps");
                });

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.Person", b =>
                {
                    b.HasBaseType("EFGetStarted.AspNetCore.NewDb.Models.MissingModel");

                    b.Property<string>("FaceAPIID");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");
                });

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.Plate", b =>
                {
                    b.HasBaseType("EFGetStarted.AspNetCore.NewDb.Models.MissingModel");

                    b.Property<string>("NumberPlate");

                    b.ToTable("Plate");

                    b.HasDiscriminator().HasValue("Plate");
                });

            modelBuilder.Entity("EFGetStarted.AspNetCore.NewDb.Models.Timestamp", b =>
                {
                    b.HasOne("EFGetStarted.AspNetCore.NewDb.Models.MissingModel", "MissingModel")
                        .WithMany("Timestamps")
                        .HasForeignKey("MissingModelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
