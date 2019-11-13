module DBConfig

open MongoDB.Bson
open MongoDB.Driver
open MongoDB.Driver.Builders
open MongoDB.FSharp

[<Literal>]
let ConnectionString = "mongodb://Admin:1234@clusteraula-shard-00-00-y5qmw.mongodb.net:27017,clusteraula-shard-00-01-y5qmw.mongodb.net:27017,clusteraula-shard-00-02-y5qmw.mongodb.net:27017/test?ssl=true&replicaSet=ClusterAula-shard-0&authSource=admin&retryWrites=true"

[<Literal>]
let DbName = "CadastroProduto"

[<Literal>]
let CollectionName = "Produto"

type ProdutoData = { Id : BsonObjectId; Name : string; QtdEstoque : int; Unidade : string; LocalEstoque : string} 

let client         = MongoClient(ConnectionString)
let db             = client.GetDatabase(DbName)
let testCollection = db.GetCollection<ProdutoData>(CollectionName)