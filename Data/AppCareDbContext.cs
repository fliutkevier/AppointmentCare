using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Domain;

namespace Data
{
    public class AppCareDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        //public DbSet<Patient> Patients { get; set; }
        //public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<Speciality> Specialities { get; set; }
        //public DbSet<Appointment> Appointments { get; set; }
        //public DbSet<HealthInsurance> HealthInsurances { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOT-PROWLER\\SQLEXPRESS;Database=AppointmentCare_DB;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
