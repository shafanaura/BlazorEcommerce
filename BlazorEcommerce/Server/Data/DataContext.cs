namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Novel",
                    Url = "novel"
                },
                new Category
                {
                    Id = 2,
                    Name = "Comic",
                    Url = "comic"
                },
                new Category
                {
                    Id = 3,
                    Name = "Biography",
                    Url = "biography"
                },
                new Category
                {
                    Id = 4,
                    Name = "Science Fiction",
                    Url = "science-fiction"
                },
                new Category
                {
                    Id = 5,
                    Name = "Self-Help",
                    Url = "self-help"
                },
                new Category
                {
                    Id = 6,
                    Name = "Mystery",
                    Url = "mystery"
                },
                new Category
                {
                    Id = 7,
                    Name = "Fantasy",
                    Url = "fantasy"
                },
                new Category
                {
                    Id = 8,
                    Name = "Science",
                    Url = "science"
                },
                new Category
                {
                    Id = 9,
                    Name = "Cooking",
                    Url = "cooking"
                },
                new Category
                {
                    Id = 10,
                    Name = "History",
                    Url = "history"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "How To Win Friends And Influence People",
                    Author = "Dale Carnegie",
                    Description = "How to win Friends and Influence People was first published in 1937 in an edition of only five thousand copies. Neither Dale Carnegie nor the publishers, Simon and Schuster, anticipated more than this modest sale. To their amazement, the book became an overnight sensation, and edition after edition rolled off the presses to keep up with the increasing public demand. How to Win Friends and Influence People took its place in publishing history as one of the all-time international bestsellers.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1385181093i/18897254.jpg",
                    Price = 9.99m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Title = "Good To Great",
                    Author = "Jim Collins",
                    Description = "After a five-year research project, Jim Collins concludes that good to great can and does happen. In this book, he uncovers the underlying variables that enable any type of organisation to make the leap from good to great while other organisations remain only good. Rigorously supported by evidence, his findings are surprising - at times even shocking - to the modern mind.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1546097703i/76865.jpg",
                    Price = 4.99m,
                    CategoryId = 6,
                },
                new Product
                {
                    Id = 3,
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Description = "My Story ON THE FINAL day of my sophomore year of high school, I was hit in the face with a baseball bat. As my classmate took a full swing, the bat slipped out of his hands and came flying toward me before striking me directly between the eyes. I have no memory of the moment of impact. The bat smashed into my face with such force that it crushed my nose into a distorted U-shape.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1655988385i/40121378.jpg",
                    Price = 5m,
                    CategoryId = 6,
                },
                new Product
                {
                    Id = 4,
                    Title = "The Power Of Now",
                    Author = "Eckhart Tolle",
                    Description = "I have little use for the past and rarely think about it; however, I would briefly like to tell you how I came to be a spiritual teacher and how this book came into existence. Until my thirtieth year, I lived in a state of almost continuous anxiety interspersed with periods of suicidal depression. It feels now as if I am talking about some past lifetime or somebody else’s life. One night not long after my twenty-ninth birthday, I woke up in the early hours with a feeling of absolute dread.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1689947880i/6708.jpg",
                    Price = 6.69m,
                    CategoryId = 9,
                },
                new Product
                {
                    Id = 5,
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Description = "Dune is a science fiction novel written by Frank Herbert. It is the first novel in the Dune series and takes place in a distant future where interstellar travel and political intrigue are common. The story follows the young Paul Atreides as he navigates the treacherous desert planet of Arrakis.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1555447414i/44767458.jpg",
                    Price = 7.99m,
                    CategoryId = 4,
                },
                new Product
                {
                    Id = 6,
                    Title = "The 7 Habits of Highly Effective People",
                    Author = "Stephen R. Covey",
                    Description = "The 7 Habits of Highly Effective People is a self-help book written by Stephen R. Covey. It offers a holistic approach to personal and interpersonal effectiveness. Covey presents a framework for achieving one's goals and living a more meaningful life.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1421842784i/36072.jpg",
                    Price = 8.49m,
                    CategoryId = 5,
                },
                new Product
                {
                    Id = 7,
                    Title = "The Girl with the Dragon Tattoo",
                    Author = "Stieg Larsson",
                    Description = "The Girl with the Dragon Tattoo is a mystery novel by Stieg Larsson. It is the first book in the Millennium series and follows journalist Mikael Blomkvist and hacker Lisbeth Salander as they investigate a decades-old disappearance and uncover dark secrets.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1684638853i/2429135.jpg",
                    Price = 6.99m,
                    CategoryId = 6,
                },
                new Product
                {
                    Id = 8,
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Description = "The Lord of the Rings is a classic fantasy novel by J.R.R. Tolkien. It follows the epic journey of Frodo Baggins and his companions as they seek to destroy the One Ring and defeat the dark lord Sauron.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1546071216i/5907.jpg",
                    Price = 10.99m,
                    CategoryId = 7,
                },
                new Product
                {
                    Id = 9,
                    Title = "A Brief History of Time",
                    Author = "Stephen Hawking",
                    Description = "A Brief History of Time is a science book by Stephen Hawking. It explores complex scientific concepts in a way that is accessible to the general reader. Hawking discusses the nature of the universe, black holes, and the origins of the cosmos.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1333578746i/3869.jpg",
                    Price = 12.99m,
                    CategoryId = 8,
                },
                new Product
                {
                    Id = 10,
                    Title = "The Joy of Cooking",
                    Author = "Irma S. Rombauer",
                    Description = "The Joy of Cooking is a classic cookbook by Irma S. Rombauer. It contains a wide range of recipes and cooking tips for both beginners and experienced cooks. This book has been a staple in American kitchens for generations.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1379313627i/327847.jpg",
                    Price = 14.99m,
                    CategoryId = 9,
                },
                new Product
                {
                    Id = 11,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Description = "The Catcher in the Rye is a classic novel by J.D. Salinger. It follows the journey of Holden Caulfield as he navigates the challenges of adolescence in New York City.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1398034300i/5107.jpg",
                    Price = 7.49m,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 12,
                    Title = "Watchmen",
                    Author = "Alan Moore and Dave Gibbons",
                    Description = "Watchmen is a graphic novel by Alan Moore and Dave Gibbons. It explores complex themes of power and morality within a world of superheroes.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1442239711i/472331.jpg",
                    Price = 11.99m,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 13,
                    Title = "Einstein: His Life and Universe",
                    Author = "Walter Isaacson",
                    Description = "Einstein: His Life and Universe is a biography of Albert Einstein written by Walter Isaacson. It delves into the life and work of the renowned physicist.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328011405i/10884.jpg",
                    Price = 9.79m,
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 14,
                    Title = "Neuromancer",
                    Author = "William Gibson",
                    Description = "Neuromancer is a cyberpunk novel by William Gibson. It is known for its influence on the science fiction genre and the concept of cyberspace.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1554437249i/6088007.jpg",
                    Price = 6.99m,
                    CategoryId = 4,
                },
                new Product
                {
                    Id = 15,
                    Title = "The Subtle Art of Not Giving a F*ck",
                    Author = "Mark Manson",
                    Description = "The Subtle Art of Not Giving a F*ck is a self-help book by Mark Manson. It offers unconventional wisdom on living a meaningful life by focusing on what truly matters.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1465761302i/28257707.jpg",
                    Price = 8.99m,
                    CategoryId = 5,
                },
                new Product
                {
                    Id = 16,
                    Title = "Sherlock Holmes: The Adventures of the Complete Collection",
                    Author = "Arthur Conan Doyle",
                    Description = "Sherlock Holmes: The Adventures of the Complete Collection is a compilation of detective stories by Arthur Conan Doyle. It features the iconic detective Sherlock Holmes and his loyal friend Dr. John Watson as they solve mysteries in Victorian London.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1470647410i/31017736.jpg",
                    Price = 13.49m,
                    CategoryId = 6,
                },
                new Product
                {
                    Id = 17,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Author = "J.K. Rowling",
                    Description = "Harry Potter and the Sorcerer's Stone is the first book in the Harry Potter series by J.K. Rowling. It introduces readers to the magical world of Hogwarts and the young wizard Harry Potter's adventures.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1474154022i/3.jpg",
                    Price = 9.99m,
                    CategoryId = 7,
                },
                new Product
                {
                    Id = 18,
                    Title = "A Brief History of Nearly Everything",
                    Author = "Bill Bryson",
                    Description = "A Brief History of Nearly Everything is a science book by Bill Bryson. It explores a wide range of scientific topics and the history of scientific discovery in an engaging and accessible manner.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1655755179i/61324554.jpg",
                    Price = 10.79m,
                    CategoryId = 8,
                },
                new Product
                {
                    Id = 19,
                    Title = "The Joy of Baking",
                    Author = "Irma S. Rombauer",
                    Description = "The Joy of Baking is a comprehensive cookbook by Irma S. Rombauer. It contains a wide variety of baking recipes, from cookies to cakes and more, for bakers of all skill levels.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328754223i/805500.jpg",
                    Price = 14.99m,
                    CategoryId = 9,
                },
                new Product
                {
                    Id = 20,
                    Title = "The Art of War",
                    Author = "Sun Tzu",
                    Description = "The Art of War is an ancient Chinese military treatise attributed to Sun Tzu. It is a classic work on strategy, tactics, and warfare, with applications in business and leadership as well.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1630683326i/10534.jpg",
                    Price = 7.99m,
                    CategoryId = 10,
                }

            );
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
