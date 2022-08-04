using Microsoft.AspNetCore.Mvc;

public class Porfolio : Controller{
    [HttpGet("")]
    public string index(){
        return "this is my index";
    }

    [HttpGet("projects")]
    public string projects(){
        return "These are my projects";
    }
    [HttpGet("contact")]
    public string contact(){
        return "this is my contact";
    }

    [HttpGet("name/{name}/{age}")]
    public string name(string name,int age){
        return $"hello {name} {age} how are you";
    }
}