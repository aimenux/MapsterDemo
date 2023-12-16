using Mapster;

namespace App.Example01;

public static class PersonMapper
{
    public static PersonDto ToPersonDto(this Person person)
    {
        return person.Adapt<PersonDto>();
    }
}