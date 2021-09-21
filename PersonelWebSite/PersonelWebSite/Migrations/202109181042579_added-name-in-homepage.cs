namespace PersonelWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednameinhomepage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HomePages", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HomePages", "Name");
        }
    }
}
