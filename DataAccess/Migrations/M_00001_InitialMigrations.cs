using FluentMigrator;
using FluentMigrator.Expressions;
using Models.Application;
using Models.Domain;

namespace DataAccess.Migrations;

[Migration(1, "Initial")]
public class M_00001_InitialMigrations : Migration
{
    public override void Up()
    {
        Create.Table("Employees")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("EmployeeType").AsInt32()
            .WithColumn("EmployeeRang").AsInt32();

        Create.Table("Tables")
            .WithColumn("Number").AsInt32().PrimaryKey().Identity()
            .WithColumn("PeopleCapacity").AsInt32()
            .WithColumn("Available").AsBoolean();

        Create.Table("Products")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("IsByWeight").AsBoolean()
            .WithColumn("Amount").AsInt32();
        
        Create.Table("Dishes")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("DrinkType").AsInt32()
            .WithColumn("Cost").AsDecimal();

        
        Create.Table("Dishes")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString()
            .WithColumn("DishType").AsInt32()
            .WithColumn("Cost").AsDecimal();
        
        Create.Table("ProductDish")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("DishId").AsInt32().ForeignKey("Dishes", "Id")
            .WithColumn("ProductId").AsInt32().ForeignKey("Products", "Id");
        
       
        Create.Table("Orders")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("StartTime").AsDateTime()
            .WithColumn("EndTime").AsDateTime()
            .WithColumn("TableNumber").AsInt32().ForeignKey("Tables", "Number")
            .WithColumn("PeopleAmount").AsInt32()
            .WithColumn("Amount").AsDecimal();

        Create.Table("CookingDishes")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("DishId").AsInt32().ForeignKey("Dishes", "Id")
            .WithColumn("OrderId").AsInt32().ForeignKey("Orders", "Id")
            .WithColumn("StartTime").AsDateTime()
            .WithColumn("EndTime").AsDateTime();
        
        Create.Table("ProductCookingDish")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("WithColumn").AsInt32().ForeignKey("CookingDishId", "CookingDishes", "Id")
            .WithColumn("ProductId").AsInt32().ForeignKey("Products", "Id")
            .WithColumn("StartTime").AsDateTime()
            .WithColumn("EndTime").AsDateTime();

        var r = new Random();
        for (var i = 1; i < 10; i++)
        {
            Insert.IntoTable("Tables")
                .InSchema("public")
                .Row(new Table {Number = i, PeopleCapacity = r.Next(1, 5), Available = true});
        }
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