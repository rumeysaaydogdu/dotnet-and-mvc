namespace OgrenciKayit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delimg : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ogrencis", "OgrFoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ogrencis", "OgrFoto", c => c.String(maxLength: 500));
        }
    }
}
