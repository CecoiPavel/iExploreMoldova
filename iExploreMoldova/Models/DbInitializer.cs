using Microsoft.EntityFrameworkCore;

namespace iExploreMoldova.Models
{
    public class DbInitializer
    {
        //public static void ClearDatabase(iExploreMoldovaDbContext context)
        //{
        //    foreach (var entityType in context.Model.GetEntityTypes())
        //    {
        //        var tableName = entityType.GetTableName();
        //        var sqlCommand = $"DELETE FROM {tableName}";

        //        context.Database.ExecuteSqlRaw(sqlCommand);
        //    }
        //}

        public static void SeedData(IApplicationBuilder applicationBuilder)
        {


            iExploreMoldovaDbContext context =
                applicationBuilder.ApplicationServices.CreateScope()
                    .ServiceProvider.GetRequiredService<iExploreMoldovaDbContext>();

            //ClearDatabase(context);

            if (!context.Categories.Any())
            {
                var wineryCategory = new Category
                    { CategoryName = "Winery", CategoryDescription = "Explore the world of Moldovan wines" };
                var historicalCategory = new Category
                    { CategoryName = "Historical", CategoryDescription = "Discover ancient sites" };
                var spiritualCategory = new Category
                    { CategoryName = "Spiritual", CategoryDescription = "Visit peaceful monastic sites" };
                var urbanCategory = new Category
                    { CategoryName = "Urban", CategoryDescription = "Discover historical sites in the city" };

                context.Categories.AddRange(wineryCategory, historicalCategory, spiritualCategory, urbanCategory);

                context.SaveChanges();

                


                            if (!context.Locations.Any())
                            {
                    if (!context.Reviews.Any())
                    {

                        var wineLoverReview = new Review
                        {
                            ReviewUserName = "WineLover1",
                            ReviewRating = 5,
                            ReviewComment = "Excellent wine tasting experience"
                        };
                        var travelerReview = new Review
                        {
                            ReviewUserName = "Traveler123",
                            ReviewRating = 4,
                            ReviewComment = "Enjoyed the visit and atmosphere"
                        };

                        var historyBuffReview = new Review
                        { ReviewUserName = "HistoryBuff", ReviewRating = 5, ReviewComment = "Great historical site" };
                        var explorerReview = new Review
                        {
                            ReviewUserName = "Explorer99",
                            ReviewRating = 4,
                            ReviewComment = "Fascinating caves and monasteries"
                        };

                        var wineConnoisseurReview = new Review
                        {
                            ReviewUserName = "WineConnoisseur",
                            ReviewRating = 5,
                            ReviewComment = "A must-visit for wine lovers"
                        };
                        var traveler567Review = new Review
                        { ReviewUserName = "Traveler567", ReviewRating = 4, ReviewComment = "Impressive wine cellars" };

                        var historyEnthusiastReview = new Review
                        {
                            ReviewUserName = "HistoryEnthusiast",
                            ReviewRating = 4,
                            ReviewComment = "Impressive fortress walls"
                        };
                        var traveler789Review = new Review
                        {
                            ReviewUserName = "Traveler789",
                            ReviewRating = 3,
                            ReviewComment = "Nice views from the fortress"
                        };

                        var spiritualSeekerReview = new Review
                        {
                            ReviewUserName = "SpiritualSeeker",
                            ReviewRating = 5,
                            ReviewComment = "Serene atmosphere and lovely gardens"
                        };
                        var natureSpiritReview = new Review
                        { ReviewUserName = "NatureSpirit", ReviewRating = 4, ReviewComment = "A peaceful retreat" };

                        var cityExplorerReview = new Review
                        {
                            ReviewUserName = "CityExplorer",
                            ReviewRating = 4,
                            ReviewComment = "An unexpected gem in the city"
                        };
                        var localResidentReview = new Review
                        {
                            ReviewUserName = "LocalResident",
                            ReviewRating = 5,
                            ReviewComment = "A place with a rich history"
                        };

                        context.Reviews.AddRange(
                            wineLoverReview, travelerReview,
                            historyBuffReview, explorerReview,
                            wineConnoisseurReview, traveler567Review,
                            historyEnthusiastReview, traveler789Review,
                            spiritualSeekerReview, natureSpiritReview,
                            cityExplorerReview, localResidentReview
                        );


                        context.AddRange(
                                    new Location
                                    {
                                        LocationName = "Cricova Winery",
                                        LocationDescription = "Famous underground winery with an extensive wine collection.",
                                        LocationAddress = "1 Cricova Street, Cricova, Moldova",
                                        LocationImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1a/63/47/c9/caption.jpg?w=1200&h=-1&s=1",
                                        PriceToVisit = 30.00m,
                                        TopLocation = true,
                                        AvailableToVisit = true,
                                        CategoryId = wineryCategory.CategoryId, // Set the CategoryId
                                        Reviews = new List<Review> { wineLoverReview, travelerReview }
                                    },
                                    new Location
                                    {
                                        LocationName = "Orheiul Vechi",
                                        LocationDescription = "Historical and archaeological complex with cave monasteries.",
                                        LocationAddress = "Orhei, Moldova",
                                        LocationImageUrl = "https://media1.travelguide.de/media/c/md.jpeg",
                                        PriceToVisit = 20.00m,
                                        TopLocation = true,
                                        AvailableToVisit = true,
                                        CategoryId = historicalCategory.CategoryId,
                                        Reviews = new List<Review> { historyBuffReview, explorerReview }
                                    },
                                    new Location
                                    {
                                        LocationName = "Milestii Mici Winery",
                                        LocationDescription = "One of the largest underground wine cellars in the world.",
                                        LocationAddress = "1 Stefan Voda Street, Milestii Mici, Moldova",
                                        LocationImageUrl =
                                            "https://guidedtours.one/pic/sections/gallery/5123//Day_6_Milestii_Mici_winery__Moldova_4.jpg",
                                        PriceToVisit = 35.00m,
                                        TopLocation = true,
                                        AvailableToVisit = true,
                                        CategoryId = wineryCategory.CategoryId,
                                        Reviews = new List<Review> { wineConnoisseurReview, traveler567Review }
                                    },
                                    new Location
                                    {
                                        LocationName = "Soroca Fortress",
                                        LocationDescription = "Historical fortress overlooking the Dniester River.",
                                        LocationAddress = "Soroca, Moldova",
                                        LocationImageUrl =
                                            "https://img.traveltriangle.com/blog/wp-content/uploads/2019/01/cover-for-things-to-do-in-moldova.jpg",
                                        PriceToVisit = 10.00m,
                                        TopLocation = false,
                                        AvailableToVisit = true,
                                        CategoryId = historicalCategory.CategoryId,
                                        Reviews = new List<Review> { historyEnthusiastReview, traveler789Review }
                                    },
                                    new Location
                                    {
                                        LocationName = "Manastirea Curchi",
                                        LocationDescription = "Beautiful monastery surrounded by greenery.",
                                        LocationAddress = "Orhei, Moldova",
                                        LocationImageUrl =
                                            "https://assets.traveltriangle.com/blog/wp-content/uploads/2019/01/Tipova-Monastery1.jpg",
                                        PriceToVisit = 5.00m,
                                        TopLocation = false,
                                        AvailableToVisit = true,
                                        CategoryId = spiritualCategory.CategoryId,
                                        Reviews = new List<Review> { spiritualSeekerReview, natureSpiritReview }
                                    },
                                    new Location
                                    {
                                        LocationName = "Ciuflea Monastery",
                                        LocationDescription = "Historical monastery in the heart of Chisinau.",
                                        LocationAddress = "Chisinau, Moldova",
                                        LocationImageUrl =
                                            "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/15/8c/d1/8d/ciuflea-monastery.jpg?w=1200&h=1200&s=1",
                                        PriceToVisit = 0.00m,
                                        TopLocation = true,
                                        AvailableToVisit = true,
                                        CategoryId = urbanCategory.CategoryId,
                                        Reviews = new List<Review> { cityExplorerReview, localResidentReview }
                                    });

                                    context.SaveChanges();
                            };
                }
            }


            context.SaveChanges();
            
        }
    }
}
