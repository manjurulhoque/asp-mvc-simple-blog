namespace simple_blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategoryToPost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Posts", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "CategoryId");
            AddForeignKey("dbo.Posts", "CategoryId", "dbo.Categories", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "CategoryId" });
            DropColumn("dbo.Posts", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
