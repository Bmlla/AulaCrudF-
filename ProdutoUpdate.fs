module ProdutoUpdate

open DBConfig
open MongoDB.Driver

let update ( nameToUpdateFrom : string ) ( nameToUpdateTo : string ) = 
    let filter           = 
        Builders<ProdutoData>.Filter.Eq((fun x -> x.Name), nameToUpdateFrom)
    let updateDefinition = 
        Builders<ProdutoData>.Update.Set((fun x -> x.Name), nameToUpdateTo)
        
    testCollection.UpdateOne(filter, updateDefinition)