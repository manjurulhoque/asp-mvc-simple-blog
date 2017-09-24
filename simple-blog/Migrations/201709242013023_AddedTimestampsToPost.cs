namespace simple_blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTimestampsToPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "created_at", c => c.DateTime());
            AddColumn("dbo.Posts", "updated_at", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "updated_at");
            DropColumn("dbo.Posts", "created_at");
        }
    }
}
