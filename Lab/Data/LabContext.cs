using Lab.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Lab.Data
{
    public class LabContext : IdentityDbContext<ApplicationUser>
    {
        IConfiguration config;
        public LabContext ( IConfiguration _config)
        {
            this.config = _config;
        }

        public DbSet<LabInformation> LabsInformation { get; set; }

        public DbSet<LabOrders> LabOrders { get; set; }

        public DbSet<Patients> Patients { get; set; }

        public DbSet<TestsNames> TestNames { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Position> positions { get; set; }

        public DbSet<WorkType> workTypes { get; set; }

        public DbSet<Nationalities> Nationalities { get; set; }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(config.GetConnectionString("LabConn"));
            base.OnConfiguring(optionsBuilder);

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var Deptartment = modelBuilder.Entity<Department>(); // check

            var Nationalities = modelBuilder.Entity<Nationalities>(); // check

            var Patients = modelBuilder.Entity<Patients>(); // check

            var TestsNames = modelBuilder.Entity<TestsNames>(); // check

            var position = modelBuilder.Entity<Position>(); // check

            var labOrders = modelBuilder.Entity<LabOrders>(); // cheack

            var workType = modelBuilder.Entity<WorkType>(); // check

            var labInformation = modelBuilder.Entity<LabInformation>(); // check

            var employees = modelBuilder.Entity<Employee>();


            employees.HasOne(e => e.Departments).WithMany(e => e.Employees)
                     .HasForeignKey(d => d.DepartmentId);
            employees.HasOne(e => e.Positions).WithMany(e => e.Employees)
                     .HasForeignKey(d => d.PositionId);
            employees.HasOne(e => e.WorkType).WithMany(e => e.Employees)
                     .HasForeignKey(e => e.WorkTypeId);

            // Configure the relationships for entities that inherit from BaseModel
            Deptartment.HasOne(d => d.Added).WithMany(e => e.AddedDepartments)
                .HasForeignKey(d => d.AddedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            Deptartment
                .HasOne(d => d.Updated)
                .WithMany(e => e.UpdatedDepartments)
                .HasForeignKey(d => d.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);


            // Further configurations can be done for other entities inheriting from BaseModel
            //---
            Nationalities
               .HasOne(n => n.Added)
               .WithMany(e => e.AddedNationalities)
               .HasForeignKey(n => n.AddedById)
               .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            Nationalities
                .HasOne(n => n.Updated)
                .WithMany(e => e.UpdatedNationalities)
                .HasForeignKey(n => n.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            //---
            position
            .HasOne(p => p.Added)
             .WithMany(e => e.AddedPositions)
            .HasForeignKey(p => p.AddedById)
            .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            position
                .HasOne(p => p.Updated)
                .WithMany(e => e.UpdatedPositions)
                .HasForeignKey(p => p.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            TestsNames
                .HasOne(t => t.Added)
                .WithMany(e => e.AddedTestsNames)
                .HasForeignKey(t => t.AddedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            TestsNames
                .HasOne(t => t.Updated)
                .WithMany(e => e.UpdatedTestsNames)
                .HasForeignKey(t => t.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            workType
                .HasOne(w => w.Added)
                .WithMany( e => e.AddedWorkTypes)
                .HasForeignKey(w => w.AddedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            workType
                .HasOne(w => w.Updated)
                .WithMany(e => e.UpdatedWorkTypes)
                .HasForeignKey(w => w.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            Patients
                .HasOne(p => p.Added)
                .WithMany(e => e.AddedPatients)
                .HasForeignKey(p => p.AddedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            Patients
                .HasOne(p => p.Updated)
                .WithMany(e => e.UpdatedPatients)
                .HasForeignKey(p => p.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            labOrders
                .HasOne(d => d.Added)
                .WithMany(e => e.AddedLabOrders)
                .HasForeignKey(d => d.AddedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            labOrders
                .HasOne(d => d.Updated)
                .WithMany(e => e.UpdatedLabOrders)
                .HasForeignKey(d => d.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            labInformation
                .HasOne(d => d.Added)
                .WithMany(e => e.AddedLabInformation)
                .HasForeignKey(d => d.AddedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            labInformation
                .HasOne(d => d.Updated)
                .WithMany(e => e.UpdatedLabInformation)
                .HasForeignKey(d => d.UpdatedById)
                .OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }

    }
}

