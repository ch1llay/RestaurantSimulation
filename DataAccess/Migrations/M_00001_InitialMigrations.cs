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
            .WithColumn("WorkExpirience").AsInt32()
            .WithColumn("EmployeeType").AsInt32()
            .WithColumn("EmployeeRang").AsInt32();

        Create.Table("Tables")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("PeopleCapacity").AsInt32()
            .WithColumn("Availible").AsBoolean();

        Create.Table("Products")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("IsByWeight").AsBoolean()
            .WithColumn("Amount").AsInt32();
        
        Create.Table("Dishes")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("Cost").AsDecimal();
        
        Create.Table("ProductDish")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("DishId").AsInt32().ForeignKey("Dishes", "Id")
            .WithColumn("ProductId").AsInt32().ForeignKey("Products", "Id");
        
       
        Create.Table("Orders")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("StartTime").AsDateTime()
            .WithColumn("EndTime").AsDateTime()
            .WithColumn("TableNumber").AsInt32().ForeignKey("Tables", "Id")
            .WithColumn("PeopleAmount").AsInt32()
            .WithColumn("Amount").AsDecimal();

        Create.Table("CookingDishes")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .ForeignKey("DishId", "Dishes", "Id")
            .ForeignKey("OrderId", "Orders", "Id")
            .WithColumn("StartTime").AsDateTime()
            .WithColumn("EndTime").AsDateTime();
        
        Create.Table("ProductCookingDish")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .ForeignKey("CookingDishId", "CookingDishes", "Id")
            .ForeignKey("ProductId", "Products", "Id")
            .WithColumn("StartTime").AsDateTime()
            .WithColumn("EndTime").AsDateTime();
    }

    public override void Down()
    {
        Delete.Table("Employees");
    }
}