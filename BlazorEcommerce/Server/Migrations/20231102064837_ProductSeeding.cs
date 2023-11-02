using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "How to win Friends and Influence People was first published in 1937 in an edition of only five thousand copies. Neither Dale Carnegie nor the publishers, Simon and Schuster, anticipated more than this modest sale. To their amazement, the book became an overnight sensation, and edition after edition rolled off the presses to keep up with the increasing public demand. How to Win Friends and Influence People took its place in publishing history as one of the all-time international bestsellers.", "https://www.junkybooks.com/administrator/bookimages/637bec3a0013b5.59756966.jpg", 9.99m, "How To Win Friends And Influence People" },
                    { 2, "After a five-year research project, Jim Collins concludes that good to great can and does happen. In this book, he uncovers the underlying variables that enable any type of organisation to make the leap from good to great while other organisations remain only good. Rigorously supported by evidence, his findings are surprising - at times even shocking - to the modern mind.", "https://www.junkybooks.com/administrator/bookimages/62e44ecfe91e32.09252838.jpg", 4.99m, "Good To Great" },
                    { 3, "My Story ON THE FINAL day of my sophomore year of high school, I was hit in the face with a baseball bat. As my classmate took a full swing, the bat slipped out of his hands and came flying toward me before striking me directly between the eyes. I have no memory of the moment of impact. The bat smashed into my face with such force that it crushed my nose into a distorted U-shape.", "https://www.junkybooks.com/administrator/bookimages/63cd1d6ea3b950.84305411.jpg", 5m, "Atomic Habits" },
                    { 4, "I have little use for the past and rarely think about it; however, I would briefly like to tell you how I came to be a spiritual teacher and how this book came into existence. Until my thirtieth year, I lived in a state of almost continuous anxiety interspersed with periods of suicidal depression. It feels now as if I am talking about some past lifetime or somebody else’s life. One night not long after my twenty-ninth birthday, I woke up in the early hours with a feeling of absolute dread.", "https://www.junkybooks.com/administrator/bookimages/63d6fb6f536044.36249533.jpg", 6.69m, "The Power Of Now" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
