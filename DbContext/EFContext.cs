using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DBContext
{
    public class EFContext : DbContext
    {
        private string _connectionstring;
        public EFContext(string connectcionstring)
        {
            connectcionstring = _connectionstring;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(_connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region "Client Module"
            //One to Many relationship - as One Client Type can have multiple Clients
            modelBuilder.Entity<Mst_Client>()
                .HasOne<Mst_Client_Type>(x => x.Mst_Client_Type)
                .WithMany(x => x.Mst_Clients)
                .HasForeignKey(x => x.Client_Type_Id);

            //One to Many relationship - as One Client can have multiple Client Locations
            modelBuilder.Entity<Mst_Client_Locations>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Mst_Client_Locations)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One Country can have multiple Client Locations
            modelBuilder.Entity<Mst_Client_Locations>()
                .HasOne<Mst_Country>(x => x.Mst_Country)
                .WithMany(x => x.Mst_Client_Locations)
                .HasForeignKey(x => x.Country_Id);

            //One to Many relationship - as One State can have multiple Client Locations
            modelBuilder.Entity<Mst_Client_Locations>()
                .HasOne<Mst_State>(x => x.Mst_State)
                .WithMany(x => x.Mst_Client_Locations)
                .HasForeignKey(x => x.State_Id);

            //One to Many relationship - as One City can have multiple Client Locations
            modelBuilder.Entity<Mst_Client_Locations>()
                .HasOne<Mst_City>(x => x.Mst_City)
                .WithMany(x => x.Mst_Client_Locations)
                .HasForeignKey(x => x.City_Id);

            //One to Many relationship - as One Client can have Multiple Buyer Clients
            modelBuilder.Entity<Trn_Client_Mappings>()
                .HasOne<Mst_Client>(x => x.BuyerClient)
                .WithMany(x => x.BuyerClientMappings)
                .HasForeignKey(x => x.Buyer_Client_Id);

            //One to Many relationship - as One Client can have Multiple Seller Clients
            modelBuilder.Entity<Trn_Client_Mappings>()
                .HasOne<Mst_Client>(x => x.SellerClient)
                .WithMany(x => x.SellerClientMappings)
                .HasForeignKey(x => x.Seller_Client_Id);
            #endregion

            #region "Products Module"
            //One to Many relationship - as One Client can have multiple Categories
            modelBuilder.Entity<Mst_Category>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Mst_Categories)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One Client can have multiple Material types
            modelBuilder.Entity<Mst_Material_Type>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Mst_Material_Types)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One Client can have multiple Products
            modelBuilder.Entity<Mst_Products>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Mst_Products)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One UOM can have multiple Products
            modelBuilder.Entity<Mst_Products>()
                .HasOne<Mst_UOM>(x => x.Mst_UOM)
                .WithMany(x => x.Mst_Products)
                .HasForeignKey(x => x.UOM_Id);

            //One to Many relationship - as One Material Type can have multiple Products
            modelBuilder.Entity<Mst_Products>()
                .HasOne<Mst_Material_Type>(x => x.Mst_Material_Type)
                .WithMany(x => x.Mst_Products)
                .HasForeignKey(x => x.Material_Type_Id);

            //One to Many relationship - as One Category can have multiple Products
            modelBuilder.Entity<Mst_Products>()
                .HasOne<Mst_Category>(x => x.Mst_Category)
                .WithMany(x => x.Mst_Products)
                .HasForeignKey(x => x.Category_Id);

            //One to Many relationship - as One Buyer Product can have multiple Seller Products
            modelBuilder.Entity<Trn_Product_Mappings>()
                .HasOne<Mst_Products>(x => x.BuyerProduct)
                .WithMany(x => x.BuyerProducts)
                .HasForeignKey(x => x.Buyer_Product_id);

            //One to Many relationship - as One Seller Product can have multiple Buyer Products
            modelBuilder.Entity<Trn_Product_Mappings>()
                .HasOne<Mst_Products>(x => x.SellerProduct)
                .WithMany(x => x.SellerProducts)
                .HasForeignKey(x => x.Seller_Product_id);


            #endregion

            #region "User Module"
            //One to Many relationship - as One Client can have multiple Desinations
            modelBuilder.Entity<Mst_Designation>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Designations)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One Department can have multiple Users
            modelBuilder.Entity<Mst_User>()
                .HasOne<Mst_Department>(x => x.Mst_Department)
                .WithMany(x => x.Mst_User)
                .HasForeignKey(x => x.Department_Id);

            //One to Many relationship - as One Designation can have multiple Users
            modelBuilder.Entity<Mst_User>()
                .HasOne<Mst_Designation>(x => x.Mst_Designation)
                .WithMany(x => x.Mst_User)
                .HasForeignKey(x => x.Designation_Id);

            //One to Many relationship - as One Client can have multiple Users
            modelBuilder.Entity<Mst_User>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Mst_User)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One Client Location can have multiple Users
            modelBuilder.Entity<Mst_User>()
                .HasOne<Mst_Client_Locations>(x => x.Mst_Client_Locations)
                .WithMany(x => x.Mst_User)
                .HasForeignKey(x => x.Client_location_Id);

            #endregion

            #region "RFQ Module"
            //One to Many relationship - as One Client can have multiple Pr Details
            modelBuilder.Entity<Mst_Pr_Details>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Mst_Pr_Details)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One Client Location can have multiple RFQs
            modelBuilder.Entity<Mst_RFQ>()
                .HasOne<Mst_Client_Locations>(x => x.Mst_Client_Locations)
                .WithMany(x => x.Mst_RFQs)
                .HasForeignKey(x => x.Delivery_Location_Id);

            //One to Many relationship - as One RFQ can have multiple RFQ Details
            modelBuilder.Entity<Trn_RFQ_Details>()
                .HasOne<Mst_RFQ>(x => x.Mst_RFQ)
                .WithMany(x => x.Trn_RFQ_Details)
                .HasForeignKey(x => x.RFQ_ID);

            //One to Many relationship - as One Product can have multiple RFQ Details
            modelBuilder.Entity<Trn_RFQ_Details>()
                .HasOne<Mst_Products>(x => x.Mst_Products)
                .WithMany(x => x.Trn_RFQ_Details)
                .HasForeignKey(x => x.Product_Id);

            //One to Many relationship - as One Client can have multiple Payment Terms
            modelBuilder.Entity<Mst_Payment_Term>()
                .HasOne<Mst_Client>(x => x.Mst_Client)
                .WithMany(x => x.Mst_Payment_Terms)
                .HasForeignKey(x => x.Client_Id);

            //One to Many relationship - as One RFQ can have multiple Quotations
            modelBuilder.Entity<Trn_RFQ_Quotations>()
                .HasOne<Mst_RFQ>(x => x.Mst_RFQ)
                .WithMany(x => x.Trn_RFQ_Quotations)
                .HasForeignKey(x => x.RFQ_ID);

            //One to Many relationship - as One RFQ Details can have multiple Quotations
            modelBuilder.Entity<Trn_RFQ_Quotations>()
                .HasOne<Trn_RFQ_Details>(x => x.Trn_RFQ_Details)
                .WithMany(x => x.Trn_RFQ_Quotations)
                .HasForeignKey(x => x.RFQ_Detail_Id);

            //One to Many relationship - as One Payment Term can have multiple Quotations
            modelBuilder.Entity<Trn_RFQ_Quotations>()
                .HasOne<Mst_Payment_Term>(x => x.Mst_Payment_Term)
                .WithMany(x => x.Trn_RFQ_Quotations)
                .HasForeignKey(x => x.Payment_Term_Id);

            //One to Many relationship - as One Inco Term can have multiple Quotations
            modelBuilder.Entity<Trn_RFQ_Quotations>()
                .HasOne<Mst_INCO_Term>(x => x.Mst_INCO_Term)
                .WithMany(x => x.Trn_RFQ_Quotations)
                .HasForeignKey(x => x.Inco_Term_Id);
            #endregion

            #region "General Masters"
            //One to Many relationship - as One Country can have multiple States
            modelBuilder.Entity<Mst_State>()
                .HasOne<Mst_Country>(x=>x.Mst_Country)
                .WithMany(x=>x.Mst_Countries)
                .HasForeignKey(x => x.Country_Id);

            //One to Many relationship - as One State can have multiple Cities
            modelBuilder.Entity<Mst_City>()
                .HasOne<Mst_State>(x => x.Mst_State)
                .WithMany(x => x.Mst_Cities)
                .HasForeignKey(x => x.State_Id);
            #endregion
        }

        //Add Entites Below
        public virtual DbSet<Mst_Client_Type> Mst_Client_Type { get; set; }
        public virtual DbSet<Mst_Client> Mst_Client { get; set; }
        public virtual DbSet<Mst_Client_Locations> Mst_Client_Locations { get; set; }
        public virtual DbSet<Trn_Client_Mappings> Trn_Client_Mappings { get; set; }
        public virtual DbSet<Mst_Department> Mst_Department { get; set; }
        public virtual DbSet<Mst_Designation> Mst_Designations { get; set; }
        public virtual DbSet<Mst_User> Mst_User { get; set; }
        public virtual DbSet<Mst_Category> Mst_Categories { get; set; }
        public virtual DbSet<Mst_Material_Type> Mst_Material_Types { get; set; }
        public virtual DbSet<Mst_UOM> Mst_UOM { get; set; }
        public virtual DbSet<Mst_Products> Mst_Products { get; set; }
        public virtual DbSet<Trn_Product_Mappings> Trn_Product_Mappings { get; set; }
        public virtual DbSet<Mst_Pr_Details> Mst_Pr_Details { get; set; }
        public virtual DbSet<Mst_RFQ> Mst_RFQs { get; set; }
        public virtual DbSet<Trn_RFQ_Details> Trn_RFQ_Details { get; set; }
        public virtual DbSet<Mst_Payment_Term> Mst_Payment_Terms { get; set; }
        public virtual DbSet<Mst_INCO_Term> Mst_INCO_Terms { get; set; }
        public virtual DbSet<Trn_RFQ_Quotations> Trn_RFQ_Quotations { get; set; }
        public virtual DbSet<Mst_Country> Mst_Country { get; set; }
        public virtual DbSet<Mst_State> Mst_State { get; set; }
        public virtual DbSet<Mst_City> Mst_Cities { get; set; }
    }
}
