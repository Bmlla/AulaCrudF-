module ProdutoRead

open DBConfig
open MongoDB.Driver

let read ( name : string ) = 
    printfn "%A" <| testCollection.Find( fun x -> x.Name = name ).ToEnumerable() 