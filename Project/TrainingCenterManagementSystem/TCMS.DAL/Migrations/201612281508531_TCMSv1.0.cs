namespace TCMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TCMSv10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Fee = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CourseId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        InstructorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.InstructorId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.RoomId)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        About = c.String(),
                        Objective = c.String(),
                        Duration = c.Double(nullable: false),
                        Prerequisites = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Photo = c.Binary(),
                        Email = c.String(),
                        Phone = c.String(),
                        CurrentAddress = c.String(),
                        PermanentAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TraineeBatches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discount = c.Int(nullable: false),
                        Fee = c.Int(nullable: false),
                        BatchId = c.Int(nullable: false),
                        TraineeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: true)
                .ForeignKey("dbo.Trainees", t => t.TraineeId, cascadeDelete: true)
                .Index(t => t.BatchId)
                .Index(t => t.TraineeId);
            
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Photo = c.Binary(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        CurrentAddress = c.String(),
                        PermanentAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        TraineeId = c.Int(nullable: false),
                        PaymentMethodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethodId, cascadeDelete: true)
                .ForeignKey("dbo.Trainees", t => t.TraineeId, cascadeDelete: true)
                .Index(t => t.TraineeId)
                .Index(t => t.PaymentMethodId);
            
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TraineeBatches", "TraineeId", "dbo.Trainees");
            DropForeignKey("dbo.Payments", "TraineeId", "dbo.Trainees");
            DropForeignKey("dbo.Payments", "PaymentMethodId", "dbo.PaymentMethods");
            DropForeignKey("dbo.TraineeBatches", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.Batches", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Batches", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Batches", "CourseId", "dbo.Courses");
            DropIndex("dbo.Payments", new[] { "PaymentMethodId" });
            DropIndex("dbo.Payments", new[] { "TraineeId" });
            DropIndex("dbo.TraineeBatches", new[] { "TraineeId" });
            DropIndex("dbo.TraineeBatches", new[] { "BatchId" });
            DropIndex("dbo.Batches", new[] { "InstructorId" });
            DropIndex("dbo.Batches", new[] { "RoomId" });
            DropIndex("dbo.Batches", new[] { "CourseId" });
            DropTable("dbo.PaymentMethods");
            DropTable("dbo.Payments");
            DropTable("dbo.Trainees");
            DropTable("dbo.TraineeBatches");
            DropTable("dbo.Rooms");
            DropTable("dbo.Instructors");
            DropTable("dbo.Courses");
            DropTable("dbo.Batches");
        }
    }
}
