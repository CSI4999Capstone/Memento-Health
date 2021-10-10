namespace MementoHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestionNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormQuestions", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FormQuestions", "Number");
        }
    }
}
