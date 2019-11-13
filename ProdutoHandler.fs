module ProdutoHandler

open ProdutoCreate
open ProdutoDelete
open ProdutoRead
open ProdutoUpdate
open DBConfig
open MongoDB.Bson

module Produto =
    let AddProduto nome =
        let addQtdEstoque qtdEstoque =
            let addUnidade unidade =
                let addLocalEstoque localEstoque =
                    let produto = {Id = BsonObjectId.Create(ObjectId.GenerateNewId()); 
                                    Name = nome; 
                                    QtdEstoque = qtdEstoque; 
                                    Unidade = unidade; 
                                    LocalEstoque = localEstoque}
                    create(produto)
                addLocalEstoque
            addUnidade
        addQtdEstoque
    
    let DeleteProduto nome =
        delete(nome)

    let ReadProduto nome =
        read(nome)

    let ProdutoUpdate nomeInicio nomeFim =
        update <| nomeInicio <| nomeFim