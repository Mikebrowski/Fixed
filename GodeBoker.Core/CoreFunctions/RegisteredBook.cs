using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodeBoker.Core
{
    class RegisteredBook
    {
        [BsonId]// REQUIRES the install of MongoDB with Bson to serialze the data.
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public int Id { get; set; }
        public string Tittle { get; set; }
        public int ISBN { get; set; }
        public int Pris { get; set; }
        public string Antall { get; set; }

        //*oppgave 2 TWO OPTIONS 1-6 1=monday 7=sunday then use max.math OR SELECT antall,dager FROM GodeBoker INNER JOIN on Antall.a Antall.B */
        public string dager { get; set; }
        public int dag { get; set; }




    }
}
