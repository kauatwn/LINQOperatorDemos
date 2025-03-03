# LINQ Operator Demos

Este repositório contém diversos exemplos práticos de operadores LINQ (Language Integrated Query) feitos em .NET 9. Cada operador está organizado em sua respectiva pasta e implementado como uma aplicação Console App.

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

1. Operadores de Projeção
    - `Select`
    - `SelectMany`

2. Operadores de Filtragem
    - `OfType`
    - `Where`

3. Operadores de Ordenação
    - `OrderBy`
    - `OrderByDescending`
    - `ThenBy`
    - `ThenByDescending`
    - `Reverse`

4. Operadores de Quantificação
    - `All`
    - `Any`
    - `Contains`

5. Operadores de Agregação
    - `Aggregate`
    - `AggregateBy`
    - `Average`
    - `Count`
    - `CountBy`
    - `Sum`
    - `Min`
    - `Max`

6. Operadores de Conjunto
    - `Concat`
    - `Distinct`
    - `Union`
    - `Intersect`
    - `Except`

7. Operadores de Elemento
    - `First`
    - `FirstOrDefault`
    - `Last`
    - `LastOrDefault`
    - `Single`
    - `SingleOrDefault`
    - `ElementAt`
    - `ElementAtOrDefault`

8. Operadores de Agrupamento
    - `GroupBy`
    - `ToLookup`

9. Operadores de Junção
    - `Join`
    - `GroupJoin`

10. Operadores de Particionamento
    - `Skip`
    - `SkipWhile`
    - `Take`
    - `TakeWhile`

11. Operadores de Conversão
    - `AsEnumerable`
    - `AsQueryable`
    - `Cast`
    - `OfType`
    - `ToArray`
    - `ToList`
    - `ToDictionary`
    - `ToLookup`

12. Operadores de Geração
    - `Empty`
    - `Range`
    - `Repeat`
