open ProdutoHandler

[<EntryPoint>]
let main argv =
    
    //Produto.AddProduto <| "garfo" <| 10 <| "Caixas" <| "Estoque local"
    //Produto.DeleteProduto <| "garfo"
    Produto.ReadProduto <| "colher"
    //Produto.ProdutoUpdate <| "garfo" <| "colher"
    0 // return an integer exit code
