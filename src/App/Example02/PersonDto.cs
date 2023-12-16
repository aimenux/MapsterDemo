﻿namespace App.Example02;

public sealed record PersonDto
{
    public string FullName { get; init; }
    public DateTime BirthDate { get; init; }
    public AddressDto Address { get; init; }
}

public sealed record AddressDto
{
    public string Street { get; init; }
    public string City { get; init; }
    public string Country { get; init; }
}