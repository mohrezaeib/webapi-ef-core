using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.Models;

namespace webapi.Infrastructure.EF.Configurations
{
    public class UserConfig : IEntityTypeConfiguration< webapi.CoreEntities.Models.User>
    {
        public void Configure(EntityTypeBuilder<webapi.CoreEntities.Models.User> builder)
    {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.HasMany(x => x.Cars).WithOne(x => x.Owner).HasForeignKey(x => x.OwnerId);
                //HasOne<User>(c => c.Owner)
                //.WithMany(o => o.Cars)
                //    .HasForeignKey(c => c.OwnerId);
        }
}
}
