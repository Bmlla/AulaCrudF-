module ProdutoCreate

open DBConfig

let create ( produto : ProdutoData ) = 
    testCollection.InsertOne(produto)