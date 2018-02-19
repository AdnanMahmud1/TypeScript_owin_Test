namespace Lbl.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Address", c => c.String());
            AddColumn("dbo.Teachers", "Designation", c => c.String());
            AddColumn("dbo.Teachers", "Email", c => c.String());
            AddColumn("dbo.Teachers", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Phone");
            DropColumn("dbo.Teachers", "Email");
            DropColumn("dbo.Teachers", "Designation");
            DropColumn("dbo.Teachers", "Address");
        }
    }
}
