namespace Makale.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "SenderId", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "SenderId" });
            CreateTable(
                "dbo.Makaleler",
                c => new
                    {
                        MakaleId = c.Int(nullable: false, identity: true),
                        Onay = c.Int(nullable: false),
                        Baslik = c.String(nullable: false, maxLength: 200),
                        Icerik = c.String(nullable: false),
                        Okunma = c.Int(),
                        Begenme = c.Int(),
                        Tarih = c.DateTime(nullable: false),
                        FotoUrl = c.String(maxLength: 500),
                        KategoriId = c.Int(),
                        UyeId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MakaleId)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId)
                .ForeignKey("dbo.AspNetUsers", t => t.UyeId)
                .Index(t => t.KategoriId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Yorum",
                c => new
                    {
                        YorumId = c.Int(nullable: false, identity: true),
                        YorumMetni = c.String(storeType: "ntext"),
                        AdSoyad = c.String(),
                        Email = c.String(),
                        YorumTarihi = c.DateTime(nullable: false),
                        MakaleId = c.Int(),
                        UyeId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.YorumId)
                .ForeignKey("dbo.Makaleler", t => t.MakaleId)
                .ForeignKey("dbo.AspNetUsers", t => t.UyeId)
                .Index(t => t.MakaleId)
                .Index(t => t.UyeId);
            
            DropTable("dbo.Messages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageDate = c.DateTime(nullable: false),
                        Content = c.String(nullable: false),
                        SenderId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Yorum", "UyeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Yorum", "MakaleId", "dbo.Makaleler");
            DropForeignKey("dbo.Makaleler", "UyeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Makaleler", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Yorum", new[] { "UyeId" });
            DropIndex("dbo.Yorum", new[] { "MakaleId" });
            DropIndex("dbo.Makaleler", new[] { "UyeId" });
            DropIndex("dbo.Makaleler", new[] { "KategoriId" });
            DropTable("dbo.Yorum");
            DropTable("dbo.Kategoris");
            DropTable("dbo.Makaleler");
            CreateIndex("dbo.Messages", "SenderId");
            AddForeignKey("dbo.Messages", "SenderId", "dbo.AspNetUsers", "Id");
        }
    }
}
