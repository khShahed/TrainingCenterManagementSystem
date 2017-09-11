namespace TCMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoomUpdatedV11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "RoomNo");
        }
    }
}
