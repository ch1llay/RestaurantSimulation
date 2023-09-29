using FluentMigrator;
using FluentMigrator.Expressions;

namespace DataAccess.Migrations;

[Migration(1, "Initial")]
public class M_00001_InitialMigrations : Migration
{
    public override void Up()
    {
        Create.Table("Employees")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("EmployeeType").AsInt32();
        
        Create.Table("Drinks")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("DrinkType").AsInt32()
            .WithColumn("Cost").AsDecimal();

        
        Create.Table("Dishes")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("DishType").AsInt32()
            .WithColumn("Cost").AsDecimal();
        
    }

    public override void Down()
    {
        Delete.Table("ProductCookingDish");
        Delete.Table("CookingDishes");
        Delete.Table("Orders");
        Delete.Table("ProductDish");
        Delete.Table("Dishes");
        Delete.Table("Products");
        Delete.Table("Tables");
        Delete.Table("Employees");
    }
}