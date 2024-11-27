using Microsoft.EntityFrameworkCore;

namespace LitList.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        if (context.Users.Any())
        {
            return;
        }
        context.Users.AddRange(
            new User { Name="Caity", DateJoined=DateTime.Parse("11/25/2024"), Bio="I love reading all genres of fiction!" },
            new User { Name="Jake", DateJoined=DateTime.Parse("10/14/2024"), Bio="Big fan of mystery novels and thrillers." },
            new User { Name="Lila", DateJoined=DateTime.Parse("09/07/2024"), Bio="Historical fiction is my favorite!" },
            new User { Name="Tom", DateJoined=DateTime.Parse("08/22/2024"), Bio="I enjoy collecting and reading first editions." },
            new User { Name="Sophia", DateJoined=DateTime.Parse("07/30/2024"), Bio="Fantasy books take me to another world." },
            new User { Name="Leo", DateJoined=DateTime.Parse("06/18/2024"), Bio="Reading biographies inspires me." },
            new User { Name="Mia", DateJoined=DateTime.Parse("05/09/2024"), Bio="A book a day keeps the boredom away." },
            new User { Name="Ryan", DateJoined=DateTime.Parse("04/12/2024"), Bio="I love reading about personal development." },
            new User { Name="Isabella", DateJoined=DateTime.Parse("03/25/2024"), Bio="Poetry books are my passion." },
            new User { Name="Ethan", DateJoined=DateTime.Parse("02/14/2024"), Bio="I could spend hours lost in science fiction." },
            new User { Name="Olivia", DateJoined=DateTime.Parse("01/05/2024"), Bio="Classical literature is my favorite genre." },
            new User { Name="Aiden", DateJoined=DateTime.Parse("12/28/2023"), Bio="Audiobooks are my go-to for road trips." },
            new User { Name="Emma", DateJoined=DateTime.Parse("11/15/2023"), Bio="I enjoy reading novels with strong female leads." },
            new User { Name="Lucas", DateJoined=DateTime.Parse("10/09/2023"), Bio="Non-fiction books broaden my perspective." },
            new User { Name="Ella", DateJoined=DateTime.Parse("09/23/2023"), Bio="Bookstores are my happy place." },
            new User { Name="Nathan", DateJoined=DateTime.Parse("08/01/2023"), Bio="I write book reviews for fun." },
            new User { Name="Charlotte", DateJoined=DateTime.Parse("07/14/2023"), Bio="Thrillers and suspense keep me on edge!" },
            new User { Name="James", DateJoined=DateTime.Parse("06/28/2023"), Bio="I can’t resist a good detective story." },
            new User { Name="Grace", DateJoined=DateTime.Parse("05/11/2023"), Bio="Book clubs are where I thrive." },
            new User { Name="Liam", DateJoined=DateTime.Parse("04/03/2023"), Bio="Libraries feel like home to me." },
            new User { Name="Ava", DateJoined=DateTime.Parse("03/17/2023"), Bio="I enjoy reading graphic novels and manga." },
            new User { Name="Mason", DateJoined=DateTime.Parse("02/10/2023"), Bio="Self-help books inspire me every day." },
            new User { Name="Chloe", DateJoined=DateTime.Parse("01/29/2023"), Bio="Nothing beats curling up with a good romance novel." },
            new User { Name="Benjamin", DateJoined=DateTime.Parse("01/08/2023"), Bio="I’m always searching for the next bestseller." },
            new User { Name="Zoe", DateJoined=DateTime.Parse("12/18/2022"), Bio="Literary classics have my heart." }
        );
        context.SaveChanges();

        // 50 books
        context.Books.AddRange(
            new Book { Title="Not in Love", Author="Ali Hazelwood", Pages=384, Genre="Romance" },
            new Book { Title="The Last Sunrise", Author="James Patterson", Pages=320, Genre="Thriller" },
            new Book { Title="Under the Cherry Blossom", Author="Sakura Tanaka", Pages=280, Genre="Historical Fiction" },
            new Book { Title="Galactic Ventures", Author="Isaac Freeman", Pages=450, Genre="Science Fiction" },
            new Book { Title="Cooking for the Soul", Author="Martha Green", Pages=220, Genre="Non-Fiction" },
            new Book { Title="A Whisper in the Shadows", Author="Lila Winters", Pages=370, Genre="Mystery" },
            new Book { Title="Windswept Hearts", Author="Sophia Bennett", Pages=310, Genre="Romance" },
            new Book { Title="Lost in the Labyrinth", Author="Tom Matthews", Pages=410, Genre="Fantasy" },
            new Book { Title="The Investor's Guide", Author="Ryan Carter", Pages=200, Genre="Non-Fiction" },
            new Book { Title="Echoes of the Past", Author="Olivia Harper", Pages=360, Genre="Historical Fiction" },
            new Book { Title="Starlight Expedition", Author="Leo Turner", Pages=500, Genre="Science Fiction" },
            new Book { Title="Mind Games", Author="Ethan Walker", Pages=340, Genre="Thriller" },
            new Book { Title="Poetic Dreams", Author="Mia Collins", Pages=120, Genre="Poetry" },
            new Book { Title="The Art of Letting Go", Author="Grace Morgan", Pages=270, Genre="Self-Help" },
            new Book { Title="Beneath the Willow Tree", Author="Ava Sinclair", Pages=290, Genre="Romance" },
            new Book { Title="The Hacker's Code", Author="Nathan Grant", Pages=380, Genre="Tech Thriller" },
            new Book { Title="Haunted by Secrets", Author="Emma Sullivan", Pages=400, Genre="Horror" },
            new Book { Title="An Ocean Apart", Author="Lucas Rivera", Pages=310, Genre="Contemporary Fiction" },
            new Book { Title="The Forgotten Kingdom", Author="Charlotte Hayes", Pages=460, Genre="Fantasy" },
            new Book { Title="Between the Lines", Author="Ella Brooks", Pages=250, Genre="Romance" },
            new Book { Title="The Shadow's Edge", Author="James Black", Pages=390, Genre="Thriller" },
            new Book { Title="When We Were Young", Author="Chloe Adams", Pages=280, Genre="Historical Fiction" },
            new Book { Title="A Universe Within", Author="Liam Daniels", Pages=490, Genre="Science Fiction" },
            new Book { Title="Pages of Fire", Author="Sophia Reed", Pages=350, Genre="Fantasy" },
            new Book { Title="The Mystery of Hollow Hill", Author="Benjamin Cross", Pages=330, Genre="Mystery" },
            new Book { Title="Tides of Destiny", Author="Zoe Hart", Pages=370, Genre="Romance" },
            new Book { Title="The Innovator's Mindset", Author="Ryan Patel", Pages=200, Genre="Non-Fiction" },
            new Book { Title="Moonlit Shadows", Author="Ella Monroe", Pages=420, Genre="Thriller" },
            new Book { Title="Roots and Wings", Author="Chloe Bennett", Pages=310, Genre="Contemporary Fiction" },
            new Book { Title="The Stardust Prophecy", Author="Aiden Clark", Pages=470, Genre="Fantasy" },
            new Book { Title="Breaking Free", Author="Mason Taylor", Pages=320, Genre="Self-Help" },
            new Book { Title="Threads of Fate", Author="Olivia Martinez", Pages=300, Genre="Romance" },
            new Book { Title="The Quantum Paradox", Author="Ethan Reed", Pages=530, Genre="Science Fiction" },
            new Book { Title="Beneath the Surface", Author="Lila Johnson", Pages=340, Genre="Mystery" },
            new Book { Title="Courage to Change", Author="Grace Anderson", Pages=260, Genre="Self-Help" },
            new Book { Title="The Secret Gardeners", Author="Isabella Lane", Pages=270, Genre="Historical Fiction" },
            new Book { Title="Chasing Stars", Author="Leo Archer", Pages=480, Genre="Science Fiction" },
            new Book { Title="Heartstrings", Author="Mia Foster", Pages=310, Genre="Romance" },
            new Book { Title="Dark Descent", Author="Sophia Bennett", Pages=390, Genre="Thriller" },
            new Book { Title="Through the Looking Glass", Author="James Holloway", Pages=350, Genre="Fantasy" },
            new Book { Title="Unraveled Lies", Author="Lucas Grant", Pages=330, Genre="Mystery" },
            new Book { Title="Waves of Serenity", Author="Emma Carter", Pages=280, Genre="Romance" },
            new Book { Title="The Rising Dawn", Author="Charlotte Woods", Pages=400, Genre="Fantasy" },
            new Book { Title="Boundless Horizons", Author="Nathan Porter", Pages=450, Genre="Science Fiction" },
            new Book { Title="The Secret Keeper", Author="Ava Roberts", Pages=300, Genre="Historical Fiction" },
            new Book { Title="Daring to Dream", Author="Grace Knight", Pages=240, Genre="Self-Help" },
            new Book { Title="The Crimson Pact", Author="Ethan Moore", Pages=410, Genre="Fantasy" },
            new Book { Title="Love in Bloom", Author="Lila Rose", Pages=320, Genre="Romance" },
            new Book { Title="Fractured Realities", Author="Lucas Gray", Pages=480, Genre="Science Fiction" },
            new Book { Title="The Enigma of Evelyn", Author="Chloe White", Pages=310, Genre="Mystery" }
        );
        context.SaveChanges();

        // UserBooks
        List<UserBook> userBooks = new List<UserBook>
        {
            // Books assigned to User 1
            new UserBook { UserID = 1, BookID = 1 },
            new UserBook { UserID = 1, BookID = 12 },
            new UserBook { UserID = 1, BookID = 23 },

            // Books assigned to User 2
            new UserBook { UserID = 2, BookID = 2 },
            new UserBook { UserID = 2, BookID = 15 },

            // Books assigned to User 3
            new UserBook { UserID = 3, BookID = 3 },
            new UserBook { UserID = 3, BookID = 7 },
            new UserBook { UserID = 3, BookID = 22 },
            new UserBook { UserID = 3, BookID = 31 },

            // Books assigned to User 4
            new UserBook { UserID = 4, BookID = 4 },
            new UserBook { UserID = 4, BookID = 18 },
            new UserBook { UserID = 4, BookID = 24 },

            // Books assigned to User 5
            new UserBook { UserID = 5, BookID = 5 },
            new UserBook { UserID = 5, BookID = 11 },
            new UserBook { UserID = 5, BookID = 25 },
            new UserBook { UserID = 5, BookID = 34 },
            new UserBook { UserID = 5, BookID = 42 },

            // Books assigned to User 6
            new UserBook { UserID = 6, BookID = 6 },
            new UserBook { UserID = 6, BookID = 19 },

            // Books assigned to User 7
            new UserBook { UserID = 7, BookID = 7 },
            new UserBook { UserID = 7, BookID = 16 },
            new UserBook { UserID = 7, BookID = 28 },
            new UserBook { UserID = 7, BookID = 41 },
            new UserBook { UserID = 7, BookID = 49 },

            // Books assigned to User 8
            new UserBook { UserID = 8, BookID = 8 },

            // Books assigned to User 9
            new UserBook { UserID = 9, BookID = 9 },
            new UserBook { UserID = 9, BookID = 13 },
            new UserBook { UserID = 9, BookID = 21 },
            new UserBook { UserID = 9, BookID = 36 },
            new UserBook { UserID = 9, BookID = 44 },
            new UserBook { UserID = 9, BookID = 48 },

            // Books assigned to User 10
            new UserBook { UserID = 10, BookID = 10 },
            new UserBook { UserID = 10, BookID = 29 },

            // Books assigned to User 11
            new UserBook { UserID = 11, BookID = 11 },
            new UserBook { UserID = 11, BookID = 14 },
            new UserBook { UserID = 11, BookID = 27 },
            new UserBook { UserID = 11, BookID = 39 },

            // Books assigned to User 12
            new UserBook { UserID = 12, BookID = 12 },
            new UserBook { UserID = 12, BookID = 32 },
            new UserBook { UserID = 12, BookID = 45 },

            // Books assigned to User 13
            new UserBook { UserID = 13, BookID = 13 },
            new UserBook { UserID = 13, BookID = 20 },
            new UserBook { UserID = 13, BookID = 33 },
            new UserBook { UserID = 13, BookID = 37 },

            // Books assigned to User 14
            new UserBook { UserID = 14, BookID = 14 },
            new UserBook { UserID = 14, BookID = 26 },
            new UserBook { UserID = 14, BookID = 30 },
            new UserBook { UserID = 14, BookID = 40 },
            new UserBook { UserID = 14, BookID = 47 },

            // Books assigned to User 15
            new UserBook { UserID = 15, BookID = 15 },
            new UserBook { UserID = 15, BookID = 35 },

            // Books assigned to User 16
            new UserBook { UserID = 16, BookID = 16 },
            new UserBook { UserID = 16, BookID = 17 },
            new UserBook { UserID = 16, BookID = 46 },

            // Books assigned to User 17
            new UserBook { UserID = 17, BookID = 17 },

            // Books assigned to User 18
            new UserBook { UserID = 18, BookID = 18 },
            new UserBook { UserID = 18, BookID = 38 },

            // Books assigned to User 19
            new UserBook { UserID = 19, BookID = 19 },
            new UserBook { UserID = 19, BookID = 23 },

            // Books assigned to User 20
            new UserBook { UserID = 20, BookID = 20 },
            new UserBook { UserID = 20, BookID = 22 },
            new UserBook { UserID = 20, BookID = 34 },

            // Books assigned to User 21
            new UserBook { UserID = 21, BookID = 21 },

            // Books assigned to User 22
            new UserBook { UserID = 22, BookID = 22 },
            new UserBook { UserID = 22, BookID = 50 },

            // Books assigned to User 23
            new UserBook { UserID = 23, BookID = 23 },
            new UserBook { UserID = 23, BookID = 43 },

            // Books assigned to User 24
            new UserBook { UserID = 24, BookID = 24 },
            new UserBook { UserID = 24, BookID = 31 },

            // Books assigned to User 25
            new UserBook { UserID = 25, BookID = 25 },
            new UserBook { UserID = 25, BookID = 28 },
            new UserBook { UserID = 25, BookID = 42 },

        };
        context.AddRange(userBooks);
        context.SaveChanges();
    }
}