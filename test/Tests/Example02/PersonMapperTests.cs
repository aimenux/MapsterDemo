using App.Example02;
using AutoFixture;
using FluentAssertions;

namespace Tests.Example02;

public class PersonMapperTests
{
    private static readonly Fixture Fixture = new();
    
    [Fact]
    public void Should_Map_Person_To_PersonDto()
    {
        // arrange
        var person = Fixture.Create<Person>();

        // act
        var personDto = person.ToPersonDto();

        // assert
        personDto
            .Should()
            .BeEquivalentTo(new
            {
                FullName = $"{person.FirstName} {person.LastName}"
            })
            .And
            .BeEquivalentTo(person, options => options.ExcludingMissingMembers());
    }
}