
using Microsoft.AspNetCore.Mvc;

public class HomeController
{
    [HttpGet("/mvc")]
    public string Index() => "Hello from MVC!";
}