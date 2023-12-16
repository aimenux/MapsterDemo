using App.Example03;

namespace App.Example03
{
    public partial class PersonMapperGenerator : IPersonMapperGenerator
    {
        public PersonDto ToPersonDto(Person p1)
        {
            return p1 == null ? null : new PersonDto()
            {
                FirstName = p1.FirstName,
                LastName = p1.LastName,
                BirthDate = p1.BirthDate,
                Address = p1.Address == null ? null : new AddressDto()
                {
                    Street = p1.Address.Street,
                    City = p1.Address.City,
                    Country = p1.Address.Country
                }
            };
        }
    }
}