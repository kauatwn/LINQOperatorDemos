# LINQ Operator Demos

Este repositório contém diversos exemplos práticos de operadores LINQ (Language Integrated Query) feitos em .NET 9. Cada operador está organizado em sua respectiva pasta e implementado como uma aplicação Console App.

## Pré-requisitos

Escolha uma das seguintes opções para executar o projeto:

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)

## Como Executar

Você pode executar o projeto de duas formas:

1. **Com Docker** (recomendado para evitar configurações locais)
2. **Localmente com .NET SDK** (caso já tenha o ambiente .NET configurado)

### Clone o Projeto

Clone este repositório em sua máquina local:

```bash
git clone https://github.com/seu-usuario/LINQ_Operator_Demos.git
```

### Executar com Docker

1. Navegue até a pasta raiz do projeto:

    ```bash
    cd LINQ_Operator_Demos/
    ```

2. Construa a imagem Docker:

    ```bash
    docker compose build
    ```

3. Execute o container desejado com base no operador:

    ```bash
    docker compose run --rm <operator>
    ```

    | Operadores Disponíveis (Docker) |
    | ------------------------------- |
    | `aggregate`                     |
    | `conversion`                    |
    | `element`                       |
    | `filtering`                     |
    | `generation`                    |
    | `grouping`                      |
    | `join`                          |
    | `partitioning`                  |
    | `projection`                    |
    | `quantifier`                    |
    | `set`                           |
    | `sorting`                       |

### Executar Localmente com .NET SDK

1. Navegue até o projeto do operador desejado:

    ```bash
    cd src/<project>/
    ```

    | Projetos Disponíveis (Local) |
    | ---------------------------- |
    | `Aggregate`                  |
    | `Conversion`                 |
    | `Element`                    |
    | `Filtering`                  |
    | `Generation`                 |
    | `Grouping`                   |
    | `Join`                       |
    | `Partitioning`               |
    | `Projection`                 |
    | `Quantifier`                 |
    | `Set`                        |
    | `Sorting`                    |

2. Restaure as dependências do projeto:

    ```bash
    dotnet restore
    ```

3. Inicie a aplicação:

    ```bash
    dotnet run
    ```

## Estrutura do Projeto

A estrutura do projeto está organizada da seguinte maneira:

```plaintext
LINQ_Operator_Demos/
└── src/
    ├── Aggregate/
    ├── Conversion/
    ├── Element/
    ├── Filtering/
    ├── Generation/
    ├── Grouping/
    ├── Join/
    ├── Partitioning/
    ├── Projection/
    ├── Quantifier/
    ├── Set/
    └── Sorting/
```

Cada pasta contém exemplos específicos sobre um conjunto de operadores LINQ.

## Operadores Demonstrados

| Categoria           | Operadores                                                                                                         |
| ------------------- | ------------------------------------------------------------------------------------------------------------------ |
| **Projeção**        | `Select`, `SelectMany`                                                                                             |
| **Filtragem**       | `OfType`, `Where`                                                                                                  |
| **Ordenação**       | `OrderBy`, `OrderByDescending`, `ThenBy`, `ThenByDescending`, `Reverse`                                            |
| **Quantificação**   | `All`, `Any`, `Contains`                                                                                           |
| **Agregação**       | `Aggregate`, `AggregateBy`, `Average`, `Count`, `CountBy`, `Sum`, `Min`, `Max`                                     |
| **Conjunto**        | `Concat`, `Distinct`, `Union`, `Intersect`, `Except`                                                               |
| **Elemento**        | `First`, `FirstOrDefault`, `Last`, `LastOrDefault`, `Single`, `SingleOrDefault`, `ElementAt`, `ElementAtOrDefault` |
| **Agrupamento**     | `GroupBy`, `ToLookup`                                                                                              |
| **Junção**          | `Join`, `GroupJoin`                                                                                                |
| **Particionamento** | `Skip`, `SkipWhile`, `Take`, `TakeWhile`                                                                           |
| **Conversão**       | `AsEnumerable`, `AsQueryable`, `Cast`, `OfType`, `ToArray`, `ToList`, `ToDictionary`, `ToLookup`                   |
| **Geração**         | `Empty`, `Range`, `Repeat`                                                                                         |
