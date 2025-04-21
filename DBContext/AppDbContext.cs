using EntityProject.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.DBContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        //SimplexLiquidationServiceRequest
        public DbSet<SimplexLiquidationServiceRequest> SimplexLiquidationServiceRequest { get; set; }

        public DbSet<PaymentNotificationOutsideOfFlutterwave> paymentnotificationoutsideofflutterwaves { set; get; }
        public DbSet<ClientBank> ClientBank { get; set; }
        public DbSet<IdCard> IdCard { get; set; }
        public DbSet<Signature> Signature { get; set; }
        public DbSet<UtilityBill> UtilityBill { get; set; }
        public DbSet<AssetCustomerReasonForNotReceivngOtpatReg> AssetCustomerReasonForNotReceivngOtpatRegs { get; set; }
        public DbSet<BvnValidation> BvnValidations { get; set; }

        public DbSet<PinRequestChange> PinRequestChanges { get; set; }
        public DbSet<CustomerDataNotFromBvn> CustomerDataNotFromBvn { get; set; }

        public DbSet<TMMFDetail> TMMFDetails { get; set; }
        public DbSet<HistoricalPerformance> HistoricalPerformances { get; set; }

        public DbSet<CustomerDevice> CustomerDevice { get; set; }
        public DbSet<MobileDevice> MobileDevice { get; set; }
        public DbSet<OtpSession> OtpSession { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<RegistrationOtpSession> RegistrationOtpSessions { get; set; }
        public DbSet<RegistrationSession> RegistrationSession { get; set; }
        public DbSet<UserCredentials> UserCredentials { get; set; }

        public DbSet<UserSession> UserSession { get; set; }

        private readonly string _connectionString;

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
       : base(options)
        {
            _connectionString = configuration.GetConnectionString("dbconn");
        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _connectionString;
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql(
                 _connectionString,
             options => options.MigrationsAssembly("EntityProject") // Change to your actual migrations project
   );
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Users>().ToTable("assetusers");
            // modelBuilder.Entity<AssetCredentials>().ToTable("asset_credentials");
            //modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
