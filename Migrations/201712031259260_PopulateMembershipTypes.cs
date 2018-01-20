namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, DurationInMonths, DiscountRate, SignUpFee) VALUES(1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Id, DurationInMonths, DiscountRate, SignUpFee) VALUES(2, 1, 10, 30)");
            Sql("INSERT INTO MembershipTypes(Id, DurationInMonths, DiscountRate, SignUpFee) VALUES(3, 3, 15, 90)");
            Sql("INSERT INTO MembershipTypes(Id, DurationInMonths, DiscountRate, SignUpFee) VALUES(4, 12, 20, 300)");
            
        }

        public override void Down()
        {
        }
    }
}
