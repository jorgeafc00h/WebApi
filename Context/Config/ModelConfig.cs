using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  in this file we define all tables relations with another tables using Fluent Api 
/// </summary>
namespace Context.Config
{
       
    //public class PropertyConfig : EntityTypeConfiguration<Property>
    //{
    //    public PropertyConfig()
    //    {
    //        HasOptional(p => p.Address).WithMany(p => p.Properties).HasForeignKey(p => p.AddressId).WillCascadeOnDelete(false);
    //        HasOptional(p => p.Contact).WithMany(p => p.AsContact).HasForeignKey(p => p.ContactId).WillCascadeOnDelete(false);
    //        HasRequired(p => p.BillingInformation).WithMany(p => p.BillingInfos).HasForeignKey(p => p.BillingInformationId).WillCascadeOnDelete(true);
    //        HasOptional(p => p.Plaintiff).WithMany(p => p.Properties).HasForeignKey(p => p.PlaintiffId).WillCascadeOnDelete(false);
    //        HasOptional(p => p.Mailing).WithMany(p => p.AsMailing).HasForeignKey(p => p.MailingId).WillCascadeOnDelete(true);
    //        //HasRequired(p => p.Owner).WithMany(p => p.ClientProperties).HasForeignKey(p => p.OwnerId).WillCascadeOnDelete(false);
    //        HasOptional(p => p.DefaultLicensee).WithMany(p => p.ClientProperties).HasForeignKey(p => p.DefaultLicenseId).WillCascadeOnDelete(false);
    //        HasOptional(p => p.AppealAttorney).WithMany(p => p.AppealProperties).HasForeignKey(p => p.AppealAttorneyId).WillCascadeOnDelete(false);

    //        HasRequired(p => p.Client).WithMany(p => p.ClientProperties).HasForeignKey(p => p.ClientId).WillCascadeOnDelete(false);
    //    }
    //}

  
}                                                                                      
