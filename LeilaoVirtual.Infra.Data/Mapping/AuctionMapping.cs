using LeilaoVirtual.Domain.Features.Auctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Mapping
{
    public class AuctionMapping : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired();

            builder.HasMany(p => p.Moves)
                .WithOne(p => p.Auction);
              


        }
    }
}
