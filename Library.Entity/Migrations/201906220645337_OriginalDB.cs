namespace Library.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OriginalDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Writers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WriterBooks",
                c => new
                    {
                        Writer_ID = c.Int(nullable: false),
                        Book_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Writer_ID, t.Book_ID })
                .ForeignKey("dbo.Writers", t => t.Writer_ID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .Index(t => t.Writer_ID)
                .Index(t => t.Book_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WriterBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.WriterBooks", "Writer_ID", "dbo.Writers");
            DropIndex("dbo.WriterBooks", new[] { "Book_ID" });
            DropIndex("dbo.WriterBooks", new[] { "Writer_ID" });
            DropTable("dbo.WriterBooks");
            DropTable("dbo.Writers");
            DropTable("dbo.Books");
        }
    }
}
