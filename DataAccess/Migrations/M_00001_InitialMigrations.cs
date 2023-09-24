using FluentMigrator;
using FluentMigrator.Expressions;

namespace DataAccess.Migrations;

[Migration(1, "Initial")]
public class M_00001_InitialMigrations : Migration
{
    public override void Up()
    {
        Create.Table("Employees")
            .WithColumn("Id").AsInt64().PrimaryKey().Identity()
            .WithColumn("Name").AsString();
    }

    public override void Down()
    {
        Delete.Table("Employees");
    }
}