using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        [BsonId] 
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] //Bunun benzersiz olduğunu belirtmek için kullanılır
        public string CategoryID { get; set; }

        public  string CategoryName { get; set; }
    }
}
