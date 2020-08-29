using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.Models;

namespace webapi.Infrastructure.EF.Configurations
{
    public class CarConfig : IEntityTypeConfiguration< webapi.CoreEntities.Models.Car>
    {
        public void Configure(EntityTypeBuilder<webapi.CoreEntities.Models.Car> builder)
    {
            builder.HasOne<User>(c => c.Owner).WithMany(o =>o.Cars)
                    .HasForeignKey(c => c.OwnerID);
        }
}
}
