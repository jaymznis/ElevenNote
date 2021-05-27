namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedSpelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
            DropColumn("dbo.Note", "ModifitedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "ModifitedUtc", c => c.DateTimeOffset(precision: 7));
            DropColumn("dbo.Note", "ModifiedUtc");
        }
    }
}
