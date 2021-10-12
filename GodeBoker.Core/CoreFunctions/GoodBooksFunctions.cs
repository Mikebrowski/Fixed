using DocumentFormat.OpenXml.Office2010.Excel;
using GodeBoker.Core.Database;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

/* Example Data since no time to make a database*/
/* altenativly
 * //The ID will be PK
 * CREATE TABLE table_name (            
                Id int NOT NULL AUTO_INCREMENT,  
                Tittle VARCHAR(250),
                ISBN int(200),
                column3 datatype );*/

namespace GodeBoker.Core
{
    public class GoodBooksFunctions : InterfaceGoodBookFunctions
    /*Interface to mange the mongoDB*/

    {
        public GoodBooksFunctions(IDbClient dbClient)
        {
            _RegisteredBook = dbClient.GetRegisteredBook();
        }

        public RegisteredBook AddRegisteredBook(RegisteredBook registeredBook)
        {
            _RegisteredBook.InsertOne(registeredBook);
            return registeredBook;
        }
        
        /*
        
        public RegisteredBook AddMutipleRegisteredBook(RegisteredBook registeredBook)
        {
            _RegisteredBook.InsertOne(registeredBook);
            return registeredBook;
        }
        */
        public void DeleteRegisteredBook(string id)
        {
            _RegisteredBook.DeleteOne(registeredBook => registeredBook.Id == id);
        }
        /*OPPGAVE 2 
        dager int[]
        antallSale int  
        if(monday)
        {
        
        }
        */
        public GetRegisteredBook(string dager) => _RegisteredBook.Find(registeredBook => true).ToList();

        

        public RegisteredBook UpdateRegisteredBook(RegisteredBook registeredBook)
        {
            GetRegisteredBook(RegisteredBook.Id);
            _RegisteredBook.ReplaceOne(rb => rb.Id == registeredBook.Id, registeredBook);
            return registeredBook;
        }
    }
}




