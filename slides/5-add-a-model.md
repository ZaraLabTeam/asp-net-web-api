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
namespace ProductsApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
```


### JSON
```json
{
    "id": 1,
    "name": "Generic Washing Machine",
    "category": "Feng Shui",
    "price": 50
}
```


### Todo: XML