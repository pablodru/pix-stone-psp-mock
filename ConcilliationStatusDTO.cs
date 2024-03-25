using System.Text.Json.Serialization;

public class ConcilliationStatusDTO
{
    public required List<Transaction?> databaseToFile { get; set; }
    public required List<Transaction?> fileToDatabase { get; set; }
    public required List<DifferentStatusIds?> differentStatus { get; set; }
}


public class Transaction
{
    public required int Id { get; set; }
    public required string Status { get; set; }
}

public class DifferentStatusIds
{
    public required int Id { get; set; }
}