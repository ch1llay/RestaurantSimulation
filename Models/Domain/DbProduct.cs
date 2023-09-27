namespace Models.Domain;

public class DbProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Amount { get; set; }
    public bool IsByWeight { get; set; }
}