﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace purchasesPMS.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class purchasesEntities1 : DbContext
    {
        public purchasesEntities1()
            : base("name=purchasesEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Purchase_Items> Purchase_Items { get; set; }
        public virtual DbSet<TB_CURRENCIES> TB_CURRENCIES { get; set; }
        public virtual DbSet<TB_PRODUCTS> TB_PRODUCTS { get; set; }
        public virtual DbSet<TB_PURCHASES> TB_PURCHASES { get; set; }
        public virtual DbSet<TB_STOCKS> TB_STOCKS { get; set; }
        public virtual DbSet<TB_STORES> TB_STORES { get; set; }
        public virtual DbSet<TB_SUPPLIERS> TB_SUPPLIERS { get; set; }
        public virtual DbSet<TB_UNITES> TB_UNITES { get; set; }
        public virtual DbSet<TB_USERS> TB_USERS { get; set; }
        public virtual DbSet<purchases_view> purchases_view { get; set; }
    }
}
