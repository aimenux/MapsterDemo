namespace App.Example03;

public sealed record Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime BirthDate { get; init; }
    public Address Address { get; init; }
}

public sealed record Address
{
    public string Street { get; init; }
    public string City { get; init; }
    public string Country { get; init; }
}