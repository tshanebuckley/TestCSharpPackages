using Newtonsoft.Json;
using TestService.DataObjects;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    var dog = new Dog();
    dog.Name = "Spot";
    dog.Friend = new Dog() { Name = "Buddy" };
    dog.GoodDog = true;
    dog.Properties.Add("age", 4);
    dog.Properties.Add("owner", "Jim");
    dog.Properties.Add("toys", new string[] { "ball", "bone", "monkey" });
    dog.Properties.Add("brother", new Dog() { Name = "Baxter" });
    string json = JsonConvert.SerializeObject(dog, Formatting.Indented);

    var copyOfDog = JsonConvert.DeserializeObject<Dog>(json);
    var copyJson = JsonConvert.SerializeObject(copyOfDog, Formatting.Indented);

    return $"Original:\n{json}\nCopy:\n{copyOfDog}";
});

app.Run();
