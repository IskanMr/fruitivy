using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.IdGenerators;

namespace fruitivy
{
    public class Information
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        private ObjectId _id;

        private string _title;
        private string _description;
        private string _type;

        public string Id { get { return _id.ToString(); } }

        [BsonElement("Title")]
        public string Title { get{return _title;} set{_title=value;} }
        [BsonElement("Description")]
        public string Description { get{return _description;} set{_description=value;} }
        [BsonElement("Type")]
        public string Type {get{return _type;} set{_type=value;} }

        public Information(string title, string description, string type)
        {
            Title = title;
            Description = description;
            Type = type;
        }


    }
}
