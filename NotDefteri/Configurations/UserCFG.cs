using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotDefteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri.Configurations
{
    internal class UserCFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a=> a.FirstName).HasMaxLength(50);
            builder.Property(a=> a.LastName).HasMaxLength(50);
            builder.Property(a=> a.UserName).HasMaxLength(50);
            builder.Property(a=> a.Password).HasMaxLength(50);

            //02.06.2023 14:06 tarihini atar hep alttaki o yüzden baseclassta dattime.now islemini yapiyoruz.
            //builder.Property(a => a.CreationDate).HasDefaultValue(DateTime.Now);

            builder.Property(a=>a.isActive).HasDefaultValue(false);
            builder.HasData(
                new User()
                {
                    Id = 1,
                    isActive = true,
                    FirstName = "Bilge",
                    LastName = "Adam",
                    UserName = "admin",
                    Password = "admin123",
                    UserType = Enums.UserType.Admin
                }
            );
        }
    }
}
