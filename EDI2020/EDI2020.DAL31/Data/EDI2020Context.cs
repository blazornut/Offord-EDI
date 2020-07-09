﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDI2020.DAL.Models;

using Microsoft.EntityFrameworkCore;


namespace EDI2020.DAL.Data
{
    public partial class EDI2020Context : DbContext
    {
        public EDI2020Context()
        {
        }

        public EDI2020Context(DbContextOptions<EDI2020Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<TeacherClass> Classes { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IntAccess).HasColumnName("intAccess");

                entity.Property(e => e.StrEmail)
                    .HasColumnName("strEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(25);

                entity.Property(e => e.StrPassword)
                    .HasColumnName("strPassword")
                    .HasMaxLength(25);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TeacherClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("classes");

                entity.Property(e => e.DtmCreated)
                    .HasColumnName("dtmCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntClassId).HasColumnName("intClassID");

                entity.Property(e => e.IntLanguage).HasColumnName("intLanguage");

                entity.Property(e => e.IntMonths).HasColumnName("intMonths");

                entity.Property(e => e.IntTeacherId).HasColumnName("intTeacherID");

                entity.Property(e => e.StrComments).HasColumnName("strComments");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("schools");

                entity.Property(e => e.DtmCreated)
                    .HasColumnName("dtmCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntElp).HasColumnName("intELP");

                entity.Property(e => e.IntProvince).HasColumnName("intProvince");

                entity.Property(e => e.IntSchoolId).HasColumnName("intSchoolID");

                entity.Property(e => e.IntSiteId).HasColumnName("intSiteID");

                entity.Property(e => e.StrAddress)
                    .HasColumnName("strAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.StrCity)
                    .HasColumnName("strCity")
                    .HasMaxLength(50);

                entity.Property(e => e.StrComments).HasColumnName("strComments");

                entity.Property(e => e.StrEmail)
                    .HasColumnName("strEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.StrFax)
                    .HasColumnName("strFax")
                    .HasMaxLength(14);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(100);

                entity.Property(e => e.StrPhone)
                    .HasColumnName("strPhone")
                    .HasMaxLength(14);

                entity.Property(e => e.StrPostal)
                    .HasColumnName("strPostal")
                    .HasMaxLength(7);

                entity.Property(e => e.StrPrincipal)
                    .HasColumnName("strPrincipal")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sites");

                entity.Property(e => e.DtmCreated)
                    .HasColumnName("dtmCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntProvince).HasColumnName("intProvince");

                entity.Property(e => e.IntSiteId).HasColumnName("intSiteID");

                entity.Property(e => e.StrAddress)
                    .HasColumnName("strAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.StrCity)
                    .HasColumnName("strCity")
                    .HasMaxLength(50);

                entity.Property(e => e.StrComments).HasColumnName("strComments");

                entity.Property(e => e.StrCoordinator)
                    .HasColumnName("strCoordinator")
                    .HasMaxLength(50);

                entity.Property(e => e.StrEmail)
                    .HasColumnName("strEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.StrFax)
                    .HasColumnName("strFax")
                    .HasMaxLength(14);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(75);

                entity.Property(e => e.StrPhone)
                    .HasColumnName("strPhone")
                    .HasMaxLength(14);

                entity.Property(e => e.StrPostal)
                    .HasColumnName("strPostal")
                    .HasMaxLength(7);

                entity.Property(e => e.StrQ10)
                    .HasColumnName("strQ10")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ10french)
                    .HasColumnName("strQ10French")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ11)
                    .HasColumnName("strQ11")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ11french)
                    .HasColumnName("strQ11French")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ6)
                    .HasColumnName("strQ6")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ6french)
                    .HasColumnName("strQ6French")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ7)
                    .HasColumnName("strQ7")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ7french)
                    .HasColumnName("strQ7French")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ8)
                    .HasColumnName("strQ8")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ8french)
                    .HasColumnName("strQ8French")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ9)
                    .HasColumnName("strQ9")
                    .HasMaxLength(255);

                entity.Property(e => e.StrQ9french)
                    .HasColumnName("strQ9French")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("teachers");

                entity.Property(e => e.DtmCreated)
                    .HasColumnName("dtmCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntAge).HasColumnName("intAge");

                entity.Property(e => e.IntQ5a).HasColumnName("intQ5a");

                entity.Property(e => e.IntQ5b).HasColumnName("intQ5b");

                entity.Property(e => e.IntQ5c).HasColumnName("intQ5c");

                entity.Property(e => e.IntQ5d).HasColumnName("intQ5d");

                entity.Property(e => e.IntQ6a).HasColumnName("intQ6a");

                entity.Property(e => e.IntQ6b).HasColumnName("intQ6b");

                entity.Property(e => e.IntQ6c).HasColumnName("intQ6c");

                entity.Property(e => e.IntQ6d).HasColumnName("intQ6d");

                entity.Property(e => e.IntQ6e).HasColumnName("intQ6e");

                entity.Property(e => e.IntQ6f).HasColumnName("intQ6f");

                entity.Property(e => e.IntQ6g).HasColumnName("intQ6g");

                entity.Property(e => e.IntQ6h).HasColumnName("intQ6h");

                entity.Property(e => e.IntQ6i).HasColumnName("intQ6i");

                entity.Property(e => e.IntQ6j).HasColumnName("intQ6j");

                entity.Property(e => e.IntQ6k).HasColumnName("intQ6k");

                entity.Property(e => e.IntSchoolId).HasColumnName("intSchoolID");

                entity.Property(e => e.IntSex).HasColumnName("intSex");

                entity.Property(e => e.IntTeacherId).HasColumnName("intTeacherID");

                entity.Property(e => e.StrEmail)
                    .HasColumnName("strEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.StrFax)
                    .HasColumnName("strFax")
                    .HasMaxLength(14);

                entity.Property(e => e.StrName)
                    .HasColumnName("strName")
                    .HasMaxLength(75);

                entity.Property(e => e.StrPassword)
                    .HasColumnName("strPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.StrPhone)
                    .HasColumnName("strPhone")
                    .HasMaxLength(14);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}