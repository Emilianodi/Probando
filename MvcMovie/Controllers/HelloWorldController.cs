using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    //
    //Get: /HelloWorld/
    /*public string Index()
    {
        return "Hola, voy a devolver una cadena de texto";
    }*/
    public IActionResult Index()
    { 
        return View();
    }
    //
    //Get:/HelloWorld/Welcome/

    /*public string Welcome()
    {
        return "This is the Welcome action method...";
    }*/

    //Requires using System.Text.Encodings.Web;

    /*public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is {numTimes}");
    }*/

    /*public string Welcome(string name, int ID =1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }*/

    public IActionResult Welcome(string name, int numTimes=1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

}