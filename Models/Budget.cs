namespace Models;

public class Budget
{
    public int Id { get; set; } = 0;

    public int UserId { get; set; } = 0;

    public DateTime StartDate { get; set; } = DateTime.Today;

    public DateTime EndDate { get; set; } = DateTime.Today + new TimeSpan(14, 0, 0, 0);

    public string Name { get; set; } = "Budget";

    public List<Transaction> Transactions { get; set; } = new();
}