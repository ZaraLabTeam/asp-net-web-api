### Adding a Data Model

A model is an object that represents the data in your application. 
ASP.NET Web API can automatically serialize your model to JSON, XML,
or some other format, and then write the serialized data into the
body of the HTTP response message. As long as a client can read 
the serialization format, it can deserialize the object. 
Most clients can parse either XML or JSON. Moreover, the client 
can indicate which format it wants by setting the Accept header 
in the HTTP request message.


### C# #
```C#
namespace JokesApi.Data.Models
{
    using Common.Models;

    public class Joke : BaseModel<int>
    {
        public string Content { get; set; }

        public int CategoryId { get; set; }

        public virtual JokeCategory Category { get; set; }

        public string CreatedById { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
    }
}
```


### JSON
```json
{
  "Id": 1112,
  "Content": "Падат в една пропаст двама алпинисти - песимист и оптимист.\n\nПесимиста:\n\n- Падам...\n\nОптимиста:\n\n- ЛЕТЯ!!!",
  "Category": "Разни",
  "CreatedById": "6464249d-7702-4d51-adfd-d637fe4522e5",
  "CreatedBy": "admin@admin.com",
  "Url": "/Joke/MTExMi4xMjMxMjMxMzEyMw=="
}
```


### XML
```xml
<JokeViewModel xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/JokesApi.Web.ViewModels.Joke">
    <Category>Разни</Category>
    <Content>
    Падат в една пропаст двама алпинисти - песимист и оптимист.
    Песимиста:
    - Падам...
    Оптимиста:
    - ЛЕТЯ!!!
    <CreatedBy>admin@admin.com</CreatedBy>
    <CreatedById>6464249d-7702-4d51-adfd-d637fe4522e5</CreatedBy
    </Content>
    <Id>1112</Id>
</JokeViewModel>
```