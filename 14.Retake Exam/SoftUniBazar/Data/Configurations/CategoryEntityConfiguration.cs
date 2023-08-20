﻿namespace SoftUniBazar.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SoftUniBazar.Data;
    using SoftUniBazar.Data.Models;

    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;
            category = new Category
            {
                Id = 1,
                Name = "Books"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 2,
                Name = "Cars"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 3,
                Name = "Clothes"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 4,
                Name = "Home"
            };
            categories.Add(category);

            category = new Category
            {
                Id = 5,
                Name = "Technology"
            };
            categories.Add(category);


            return categories.ToArray();
        }
    }
}