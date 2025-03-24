using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using MongoDB.Driver;

[ApiController]
[Route("conexion")]
public class Conexion : Controller
{
    [HttpGet("sql")]
    public IActionResult PersonajesSql()
    {
        return Ok("Mob Psycho a SQL Server");
    }

    [HttpGet("mongo")]
    public IActionResult PersonajesMongoDb(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Joshua_Uriel_Mob");
        var collection = db.GetCollection<PersonajeMongo>("Personajes");

        var lista = collection.Find(FilterDefinition<PersonajeMongo>.Empty).ToList();

        return Ok(lista);
    }
}