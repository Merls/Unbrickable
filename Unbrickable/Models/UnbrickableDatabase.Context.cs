﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unbrickable.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UnbrickableDatabase : DbContext
    {
        public UnbrickableDatabase()
            : base("name=UnbrickableDatabase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessLevel> AccessLevels { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<BackUp> BackUps { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Salutation> Salutations { get; set; }
        public virtual DbSet<TransactionItem> TransactionItems { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionStatus> TransactionStatus { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}