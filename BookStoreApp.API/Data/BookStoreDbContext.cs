using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookStoreApp.API.Data
{
    public partial class BookStoreDbContext : IdentityDbContext<ApiUser>
    {
        public BookStoreDbContext()
        {
        }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
           base.OnModelCreating(builder);

           builder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Name = "user",
                   NormalizedName = "USER",
                   Id = "2a03e792-b707-4689-aea5-f83fde6dd875"
               },
               new IdentityRole
               {
                   Name = "Administrator",
                   NormalizedName = "ADMINISTRATOR",
                   Id = "e301b28a-320e-4c7b-9e4e-20689a685afd"
               }
               );

            var hasher = new PasswordHasher<ApiUser>();

            builder.Entity<ApiUser>().HasData(
                new ApiUser
                {
                    Id = "9accb19b-c635-4c63-86ee-3a3ac9de7343",
                    Email = "nadirashvili8@gmail.com",
                    NormalizedEmail =  "NADIRASHVILI8@GMAIL.COM",
                    UserName = "nadirashvili8@gmail.com",
                    NormalizedUserName = "NADIRASHVILI8@GMAIL.COM",
                    FirstName = "admin",
                    LastName = "admin",
                    PasswordHash =hasher.HashPassword(null,"P@ssoword1")
                },
                new ApiUser
                {
                Id = "df2fe041-5f27-4a6c-869b-75092cc0d08d",
                    Email = "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    UserName = "user@gmail.com",
                    NormalizedUserName = "USER@GMAIL.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssoword1")
                }
                
                );

                builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2a03e792-b707-4689-aea5-f83fde6dd875",
                    UserId = "df2fe041-5f27-4a6c-869b-75092cc0d08d"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "e301b28a-320e-4c7b-9e4e-20689a685afd",
                     UserId = "9accb19b-c635-4c63-86ee-3a3ac9de7343"
                 }
                );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
