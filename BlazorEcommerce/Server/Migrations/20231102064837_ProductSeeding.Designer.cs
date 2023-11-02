﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231102064837_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "How to win Friends and Influence People was first published in 1937 in an edition of only five thousand copies. Neither Dale Carnegie nor the publishers, Simon and Schuster, anticipated more than this modest sale. To their amazement, the book became an overnight sensation, and edition after edition rolled off the presses to keep up with the increasing public demand. How to Win Friends and Influence People took its place in publishing history as one of the all-time international bestsellers.",
                            ImageUrl = "https://www.junkybooks.com/administrator/bookimages/637bec3a0013b5.59756966.jpg",
                            Price = 9.99m,
                            Title = "How To Win Friends And Influence People"
                        },
                        new
                        {
                            Id = 2,
                            Description = "After a five-year research project, Jim Collins concludes that good to great can and does happen. In this book, he uncovers the underlying variables that enable any type of organisation to make the leap from good to great while other organisations remain only good. Rigorously supported by evidence, his findings are surprising - at times even shocking - to the modern mind.",
                            ImageUrl = "https://www.junkybooks.com/administrator/bookimages/62e44ecfe91e32.09252838.jpg",
                            Price = 4.99m,
                            Title = "Good To Great"
                        },
                        new
                        {
                            Id = 3,
                            Description = "My Story ON THE FINAL day of my sophomore year of high school, I was hit in the face with a baseball bat. As my classmate took a full swing, the bat slipped out of his hands and came flying toward me before striking me directly between the eyes. I have no memory of the moment of impact. The bat smashed into my face with such force that it crushed my nose into a distorted U-shape.",
                            ImageUrl = "https://www.junkybooks.com/administrator/bookimages/63cd1d6ea3b950.84305411.jpg",
                            Price = 5m,
                            Title = "Atomic Habits"
                        },
                        new
                        {
                            Id = 4,
                            Description = "I have little use for the past and rarely think about it; however, I would briefly like to tell you how I came to be a spiritual teacher and how this book came into existence. Until my thirtieth year, I lived in a state of almost continuous anxiety interspersed with periods of suicidal depression. It feels now as if I am talking about some past lifetime or somebody else’s life. One night not long after my twenty-ninth birthday, I woke up in the early hours with a feeling of absolute dread.",
                            ImageUrl = "https://www.junkybooks.com/administrator/bookimages/63d6fb6f536044.36249533.jpg",
                            Price = 6.69m,
                            Title = "The Power Of Now"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
