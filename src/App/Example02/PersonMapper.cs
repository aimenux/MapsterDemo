using Mapster;

namespace App.Example02;

public static class PersonMapper
{
    static PersonMapper()
    {
        TypeAdapterConfig<Person, PersonDto>
            .NewConfig()
            .Map(dest => dest.FullName,
                src => $"{src.FirstName} {src.LastName}");
    }
    
    public static PersonDto ToPersonDto(this Person person)
    {
        return person.Adapt<PersonDto>();
    }
}