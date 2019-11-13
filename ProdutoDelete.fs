module ProdutoDelete

open DBConfig
open MongoDB.Driver

let delete ( name : string ) = 
    let dataFilter = Builders<ProdutoData>.Filter.Eq((fun x -> x.Name), name)
    testCollection.DeleteOne(dataFilter)