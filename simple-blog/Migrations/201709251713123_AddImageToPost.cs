namespace simple_blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageToPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "image");
        }
    }
}
