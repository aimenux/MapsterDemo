namespace App.Example03;

public sealed record PersonDto
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime BirthDate { get; init; }
    public AddressDto Address { get; init; }
}

public sealed record AddressDto
{
    public string Street { get; init; }
    public string City { get; init; }
    public string Country { get; init; }
}