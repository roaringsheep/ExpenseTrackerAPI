namespace Models;

public class Transaction
{
    public int Id { get; set; } = 0;

    public int BudgetId { get; set; } = 0;

    public int UserId { get; set; } = 0;

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    public TransactionType Type { get; set; } = 0;

    public decimal Amount { get; set; } = 0.0m;

    public string? Note { get; set; }

    public Category TransactionCategory { get; set; } = new Category();

}

public enum TransactionType
{
    Expense = 0,
    Deposit = 1
}