namespace Video_Rentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateInMembership : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values(1,'omar',0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values(2,'faruk',30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values(3,'farid',90,3,15)");
            Sql("INSERT INTO MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values(4,'Hossain',300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
