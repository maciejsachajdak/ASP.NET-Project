using Microsoft.EntityFrameworkCore;
using Project.Areas.Identity.Data;

namespace Project.Models
{
    public class ModelBuilderExtensions
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasData(
                new Club
                {
                    ID = 1,
                    name = "Crossfit Box",
                    city = "Kraków",
                    street = "Długa 12"
                },
                new Club
                {
                    ID = 2,
                    name = "Hells gym",
                    city = "Kraków",
                    street = "Krótka 65C"
                },
                new Club
                {
                    ID = 3,
                    name = "Poland Mountain",
                    city = "Warszawa",
                    street = "Pokątna 12"
                },
                new Club
                {
                    ID = 4,
                    name = "Rainbow Park",
                    city = "Sosnowiec",
                    street = "Sezamkowa 2137"
                }
            );

            modelBuilder.Entity<Opinion>().HasData(
                new Opinion
                {
                    ID = 1,
                    text = "The gym's extensive and modern equipment receives a top rating for providing a well-rounded fitness experience, suitable for all levels.",
                    rateNumber = 5,
                    clubID = 1
                },
                new Opinion
                {
                    ID = 2,
                    text = "The energetic atmosphere and motivational decor contribute positively to the workout environment, though there is always room for enhancement.",
                    rateNumber = 4,
                    clubID = 1
                },
                new Opinion
                {
                    ID = 3,
                    text = "The staff's friendliness and expertise in guiding members through workouts earn a high rating, ensuring a safe and effective exercise routine.",
                    rateNumber = 5,
                    clubID = 2
                },
                new Opinion
                {
                    ID = 4,
                    text = "The gym's commitment to cleanliness is commendable, but there might be occasional improvements needed to maintain a consistently spotless environment.",
                    rateNumber = 4,
                    clubID = 2
                },
                new Opinion
                {
                    ID = 5,
                    text = "Offering diverse fitness classes and programs for all interests and skill levels earns top marks for keeping workouts engaging and challenging.",
                    rateNumber = 5,
                    clubID = 3
                },
                new Opinion
                {
                    ID = 6,
                    text = "The gym's extended hours receive high praise for accommodating a variety of schedules, ensuring members can conveniently fit in their workouts.",
                    rateNumber = 5,
                    clubID = 3
                },
                new Opinion
                {
                    ID = 7,
                    text = "The gym's efforts to build a sense of community among members are appreciated, though there is some room for additional engagement and connection opportunities.",
                    rateNumber = 4,
                    clubID = 4
                },
                new Opinion
                {
                    ID = 8,
                    text = "Considering the facilities, services, and overall experience, the gym offers excellent value for money, justifying the membership fees with its high-quality offerings.",
                    rateNumber = 5,
                    clubID = 4
                }
            );
        }
    }
}
