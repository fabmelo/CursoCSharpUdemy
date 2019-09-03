﻿using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.Colecoes;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},

                // Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF / ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF / ELSE / IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura WHILE - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura DO WHILE - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura FOREACH - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando BREAK - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando CONTINUE - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Parâmetros Variáveis - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GettersSetters.Executar},
                {"Propriedades - Classes e Métodos", Propriedades.Executar},
                {"Atributos Readonly - Classes e Métodos", AtributosReadonly.Executar},
                {"Enumeradores - Classes e Métodos", Enumeradores.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Class - Classes e Métodos", StructVsClass.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrâo - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"Coleções Array List - Coleções", ColecoesArrayList.Executar},
                {"Coleções Dictionary - Coleções", ColecoesDictionary.Executar},
                {"Coleções List - Coleções", ColecoesList.Executar},
                {"Coleções Queue - Coleções", ColecoesQueue.Executar},
                {"Coleções Set - Coleções", ColecoesSet.Executar},
                {"Coleções Stack - Coleções", ColecoesStack.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}