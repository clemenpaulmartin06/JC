﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class JCEntities : DbContext
    {
        public JCEntities()
            : base("name=JCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ledger> ledgers { get; set; }
        public virtual DbSet<splash> splashes { get; set; }
        public virtual DbSet<user> users { get; set; }
    
        public virtual int delete_data_ledger(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_data_ledger", idParameter);
        }
    
        public virtual int insert_ledger(string username, Nullable<decimal> earned, Nullable<decimal> used, string description)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var earnedParameter = earned.HasValue ?
                new ObjectParameter("earned", earned) :
                new ObjectParameter("earned", typeof(decimal));
    
            var usedParameter = used.HasValue ?
                new ObjectParameter("used", used) :
                new ObjectParameter("used", typeof(decimal));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_ledger", usernameParameter, earnedParameter, usedParameter, descriptionParameter);
        }
    
        public virtual ObjectResult<view_ledger_Result> view_ledger(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<view_ledger_Result>("view_ledger", usernameParameter);
        }
    
        public virtual ObjectResult<view_data_Result> view_data(string username, Nullable<int> id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<view_data_Result>("view_data", usernameParameter, idParameter);
        }
    
        public virtual int update_data(string username, Nullable<int> id, string description, Nullable<decimal> earned, Nullable<decimal> used)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var earnedParameter = earned.HasValue ?
                new ObjectParameter("earned", earned) :
                new ObjectParameter("earned", typeof(decimal));
    
            var usedParameter = used.HasValue ?
                new ObjectParameter("used", used) :
                new ObjectParameter("used", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_data", usernameParameter, idParameter, descriptionParameter, earnedParameter, usedParameter);
        }
    }
}
