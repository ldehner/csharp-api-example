using csharp_api.Models;

namespace csharp_api;

public class Converter
{
    public Converter()
    {
    }

    public ResponseUser RequestUserToResponseUser(RequestUser user)
    {
        return new ResponseUser()
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Phone = user.Phone,
            Mail = user.Mail,
            Country = user.Country,
            City = user.City,
            Street = user.Street,
            Housenumber = user.Housenumber,
            Apartment = user.Apartment
        };
    }
}