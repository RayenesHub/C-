using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationCore.Domain;

namespace Test.Infrastructure.Configuration
{
    public class PrestationConfig : IEntityTypeConfiguration<Prestation>
    {
        public void Configure(EntityTypeBuilder<Prestation> builder)
        {
            
            builder.HasOne(p => p.Myclient)
                .WithMany(c => c.Prestations)
                .HasForeignKey(p => p.ClientFK);

            builder.HasOne(p => p.MyPrestataire)
                .WithMany(c => c.Prestations)
                .HasForeignKey(p => p.PrestataireFK);

        //(clé primaire composée)
            builder.HasKey(p => new
            {
                p.ClientFK,
                p.PrestataireFK,
                p.HeureDebut
            });
            builder.Property(p => p.HeureDebut)
                .IsRequired()
                .HasColumnName("HeureRDV");


        }
    }
}
