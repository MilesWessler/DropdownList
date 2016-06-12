namespace DropdownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateInstruments : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Instruments (Id, Name) VALUES (1, 'Guitar') ");
            Sql("INSERT INTO Instruments (Id, Name) VALUES (2, 'Bass') ");
            Sql("INSERT INTO Instruments (Id, Name) VALUES (3, 'Piano') ");
            Sql("INSERT INTO Instruments (Id, Name) VALUES (4, 'Saxophone') ");
            Sql("INSERT INTO Instruments (Id, Name) VALUES (5, 'Hammer Dulcimer') ");
        }

        public override void Down()
        {
        }
    }
}
