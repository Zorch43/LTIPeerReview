namespace LTIPeerReview.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LTIPeerReview.DAL.PeerReviewModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "LTIPeerReview.DAL.PeerReviewModel";
        }

        protected override void Seed(LTIPeerReview.DAL.PeerReviewModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}