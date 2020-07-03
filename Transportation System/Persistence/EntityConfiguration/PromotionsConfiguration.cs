using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;

namespace Transportation_System.Persistence.EntityConfiguration
{
    public class PromotionsConfiguration : IEntityTypeConfiguration<Promotions>
    {
        public void Configure(EntityTypeBuilder<Promotions> builder)
        {
            throw new NotImplementedException();
        }
    }
}
