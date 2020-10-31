using LeilaoVirtual.Domain.Features.Moves;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Mapping
{
    public class MoveMapping : IEntityTypeConfiguration<Move>
    {
        public void Configure(EntityTypeBuilder<Move> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.MoveValue)
                .IsRequired();

            builder.HasOne(p => p.Auction);
             
        }
    }
}
