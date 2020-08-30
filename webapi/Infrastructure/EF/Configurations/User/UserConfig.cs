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
            builder.Property(p => p.Name).IsRequired();
        }
}
}
