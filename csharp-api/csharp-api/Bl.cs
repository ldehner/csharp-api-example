using csharp_api.Models;

namespace csharp_api;

public class Bl
{
    public Bl()
    {
    }

    public ResponseUser UserGetBl(RequestUser req)
    {
        // do something
        return new Converter().RequestUserToResponseUser(req);
    }
    
    public ResponseUser UserPostBl(RequestUser req)
    {
        // do something
        return new Converter().RequestUserToResponseUser(req);
    }
    
    public ResponseUser UserPutBl(RequestUser req)
    {
        // do something
        return new Converter().RequestUserToResponseUser(req);
    }
}