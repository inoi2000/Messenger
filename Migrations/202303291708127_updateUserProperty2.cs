namespace TopMessenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUserProperty2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Photo", c => c.String());
            DropColumn("dbo.Users", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Phone", c => c.String());
            DropColumn("dbo.Users", "Photo");
        }
    }
}
