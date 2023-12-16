using App.Example01;
using App.Example02;
using App.Example03;

var personV1 = new App.Example01.Person
{
    FirstName = "Walter",
    LastName = "White",
    BirthDate = new DateTime(1958, 09, 07),
    Address = new App.Example01.Address
    {
        Street = "3828 Piermont Dr",
        City = "Albuquerque",
        Country = "USA"
    }
};
var personDtoV1 = personV1.ToPersonDto();
Console.WriteLine(personDtoV1.Dump());

var personV2 = new App.Example02.Person
{
    FirstName = "Walter",
    LastName = "White",
    BirthDate = new DateTime(1958, 09, 07),
    Address = new App.Example02.Address
    {
        Street = "3828 Piermont Dr",
        City = "Albuquerque",
        Country = "USA"
    }
};
var personDtoV2 = personV2.ToPersonDto();
Console.WriteLine(personDtoV2.Dump());

var personV3 = new App.Example03.Person
{
    FirstName = "Walter",
    LastName = "White",
    BirthDate = new DateTime(1958, 09, 07),
    Address = new App.Example03.Address
    {
        Street = "3828 Piermont Dr",
        City = "Albuquerque",
        Country = "USA"
    }
};
var personDtoV3 = personV3.ToPersonDto();
Console.WriteLine(personDtoV3.Dump());

