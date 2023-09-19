namespace Models.DTO;

public class DbOrder
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int TableNumber { get; set; }
    public int PeopleAmount { get; set; }
    public decimal Amount { get; set; }
}