using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class PersonsInfoContext : DbContext
    {
        public PersonsInfoContext()
        {
        }

        public PersonsInfoContext(DbContextOptions<PersonsInfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public virtual DbSet<CompanyContact> CompanyContacts { get; set; }
        public virtual DbSet<CompanyEmail> CompanyEmails { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CoutryState> CoutryStates { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<FamilyContact> FamilyContacts { get; set; }
        public virtual DbSet<FamilyEducationDetail> FamilyEducationDetails { get; set; }
        public virtual DbSet<FamilyEmail> FamilyEmails { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<InstitutionAddress> InstitutionAddresses { get; set; }
        public virtual DbSet<InstitutionContact> InstitutionContacts { get; set; }
        public virtual DbSet<InstitutionEmail> InstitutionEmails { get; set; }
        public virtual DbSet<MarritalStatus> MarritalStatuses { get; set; }
        public virtual DbSet<Medium> Mediums { get; set; }
        public virtual DbSet<Qualificationtype> Qualificationtypes { get; set; }
        public virtual DbSet<RelationType> RelationTypes { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAddressDetail> UserAddressDetails { get; set; }
        public virtual DbSet<UserCompany> UserCompanies { get; set; }
        public virtual DbSet<UserContact> UserContacts { get; set; }
        public virtual DbSet<UserEducationDetail> UserEducationDetails { get; set; }
        public virtual DbSet<UserEmail> UserEmails { get; set; }
        public virtual DbSet<UserSkill> UserSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-CG283C9;Database=PersonsInfo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyAddress>(entity =>
            {
                entity.ToTable("CompanyAddress");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__CompanyAd__Compa__59FA5E80");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__CompanyAd__Count__5AEE82B9");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__CompanyAd__State__5BE2A6F2");
            });

            modelBuilder.Entity<CompanyContact>(entity =>
            {
                entity.HasOne(d => d.CompanyAddress)
                    .WithMany(p => p.CompanyContacts)
                    .HasForeignKey(d => d.CompanyAddressId)
                    .HasConstraintName("FK__CompanyCo__Compa__5CD6CB2B");
            });

            modelBuilder.Entity<CompanyEmail>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.HasOne(d => d.CompanyAddress)
                    .WithMany(p => p.CompanyEmails)
                    .HasForeignKey(d => d.CompanyAddressId)
                    .HasConstraintName("FK__CompanyEm__Compa__5DCAEF64");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoutryState>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CoutryStates)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__CoutrySta__Count__5EBF139D");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CoutryStates)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__CoutrySta__State__5FB337D6");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.ToTable("Family");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.RelationType)
                    .WithMany(p => p.Families)
                    .HasForeignKey(d => d.RelationTypeId)
                    .HasConstraintName("FK__Family__Relation__60A75C0F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Families)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Family__UserId__619B8048");
            });

            modelBuilder.Entity<FamilyContact>(entity =>
            {
                entity.HasOne(d => d.Family)
                    .WithMany(p => p.FamilyContacts)
                    .HasForeignKey(d => d.FamilyId)
                    .HasConstraintName("FK__FamilyCon__Famil__628FA481");
            });

            modelBuilder.Entity<FamilyEducationDetail>(entity =>
            {
                entity.HasOne(d => d.Family)
                    .WithMany(p => p.FamilyEducationDetails)
                    .HasForeignKey(d => d.FamilyId)
                    .HasConstraintName("FK__FamilyEdu__Famil__6383C8BA");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.FamilyEducationDetails)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK__FamilyEdu__Insti__6477ECF3");

                entity.HasOne(d => d.Qualificationtype)
                    .WithMany(p => p.FamilyEducationDetails)
                    .HasForeignKey(d => d.QualificationtypeId)
                    .HasConstraintName("FK__FamilyEdu__Quali__656C112C");
            });

            modelBuilder.Entity<FamilyEmail>(entity =>
            {
                entity.HasOne(d => d.InstitutionAddress)
                    .WithMany(p => p.FamilyEmails)
                    .HasForeignKey(d => d.InstitutionAddressId)
                    .HasConstraintName("FK__FamilyEma__Insti__66603565");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GenderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK__Instituti__Mediu__6D0D32F4");

                entity.HasOne(d => d.Qualificationtype)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.QualificationtypeId)
                    .HasConstraintName("FK__Instituti__Quali__6E01572D");
            });

            modelBuilder.Entity<InstitutionAddress>(entity =>
            {
                entity.ToTable("InstitutionAddress");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.InstitutionAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Instituti__Count__6754599E");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionAddressInstitutions)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK__Instituti__Insti__68487DD7");

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.InstitutionAddresses)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK__Instituti__Mediu__693CA210");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.InstitutionAddressStates)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__Instituti__State__6A30C649");
            });

            modelBuilder.Entity<InstitutionContact>(entity =>
            {
                entity.HasOne(d => d.InstitutionAddress)
                    .WithMany(p => p.InstitutionContacts)
                    .HasForeignKey(d => d.InstitutionAddressId)
                    .HasConstraintName("FK__Instituti__Insti__6B24EA82");
            });

            modelBuilder.Entity<InstitutionEmail>(entity =>
            {
                entity.HasOne(d => d.InstitutionAddress)
                    .WithMany(p => p.InstitutionEmails)
                    .HasForeignKey(d => d.InstitutionAddressId)
                    .HasConstraintName("FK__Instituti__Insti__6C190EBB");
            });

            modelBuilder.Entity<MarritalStatus>(entity =>
            {
                entity.ToTable("MarritalStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Medium1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Medium");
            });

            modelBuilder.Entity<Qualificationtype>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RelationType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SkillName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PanCardNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VoterId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__Users__GenderId__787EE5A0");

                entity.HasOne(d => d.MarritalStatus)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.MarritalStatusId)
                    .HasConstraintName("FK__Users__MarritalS__797309D9");
            });

            modelBuilder.Entity<UserAddressDetail>(entity =>
            {
                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.UserAddressDetails)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__UserAddre__Count__6EF57B66");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.UserAddressDetails)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__UserAddre__State__6FE99F9F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddressDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserAddre__UserI__70DDC3D8");
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.ToTable("UserCompany");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__UserCompa__Compa__71D1E811");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK__UserCompa__Desig__72C60C4A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserCompa__UserI__73BA3083");
            });

            modelBuilder.Entity<UserContact>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserContacts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserConta__UserI__74AE54BC");
            });

            modelBuilder.Entity<UserEducationDetail>(entity =>
            {
                entity.HasOne(d => d.Qualificationtype)
                    .WithMany(p => p.UserEducationDetails)
                    .HasForeignKey(d => d.QualificationtypeId)
                    .HasConstraintName("FK__UserEduca__Quali__75A278F5");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEducationDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserEduca__UserI__76969D2E");
            });

            modelBuilder.Entity<UserEmail>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEmails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserEmail__UserI__778AC167");
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__UserSkill__Skill__7A672E12");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserSkill__UserI__7B5B524B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
