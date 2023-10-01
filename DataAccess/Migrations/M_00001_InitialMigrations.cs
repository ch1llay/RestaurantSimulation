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

        Insert.IntoTable("Employees").Row(new { Name="Повар", EmployeeType=0});
        Insert.IntoTable("Employees").Row(new { Name="Бармен", EmployeeType=1});
        
        Insert.IntoTable("Drinks").Row(new { Name="Изобелла", DrinkType=0, Cost=400});
        Insert.IntoTable("Drinks").Row(new { Name="Мультифрукт", DrinkType=1, Cost=100});
        Insert.IntoTable("Drinks").Row(new { Name="Латте", DrinkType=1, Cost=200});
        
        Insert.IntoTable("Dishes").Row(new { Name="Борщ", DishType=0, Cost=150});
        Insert.IntoTable("Dishes").Row(new { Name="Цезарь", DishType=1, Cost=100});
        Insert.IntoTable("Dishes").Row(new { Name="Наполеон", DishType=2, Cost=120});
       }

    public override void Down()
    {
        Delete.Table("Dishes");
        Delete.Table("Drinks");
        Delete.Table("Employees");
    }
}