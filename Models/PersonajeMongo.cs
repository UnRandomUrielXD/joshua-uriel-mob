using MongoDB.Bson.Serialization.Attributes;

public class PersonajeMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    public string? Id { get; set; }
    public string Nombre { get; set; }
    public string Rol { get; set; }
    public string Genero { get; set; }
    public int? Edad { get; set; }
    public decimal Estatura { get; set; }
    public string TipoDeSer { get; set; }
    public string? HabilidadEspecial { get; set; }
    public bool HabilidadesPsiquicas { get; set; }
}
