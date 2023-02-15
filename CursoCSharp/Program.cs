using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Métodos 
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Get Set - Classes e Métodos", GetSet.Executar},
                { "Props - Classes e Métodos", Props.Executar},
                { "Readonly - Classes e Métodos", Readonly.Executar},
                { "Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Struct - Classes e Métodos", ExemploStruct.Executar},
                { "StructVsClasse - Classes e Métodos", StructVsClasse.Executar},
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetros com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                { "Array - Coleções", Colecoes.Array.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "Array List - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar},
                { "Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                { "Herança - OO", Heranca.Executar},
                { "Construtor This - OO", ConstrutorThis.Executar},
                { "Encapsulamento - OO", OO.Encapsulamento.Executar},
                { "Polimorfismo - OO", Polimorfismo.Executar},
                { "Interface - OO", Interface.Executar},
                { "Sealed - OO", Sealed.Executar},

                // Métodos & Funções
                { "Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                { "Lambdas Como Delegate - Métodos & Funções", LambdasDelegate.Executar},
                { "Usando Delegates - Métodos & Funções", UsandoDelegates.Executar},
                { "Delegates Como Função Anonima - Métodos & Funções", DelegateFunAnonima.Executar},
                { "Delegates Como Parâmetros - Métodos & Funções", DelegatesComoParametros.Executar},
                { "Métodos De Extensão - Métodos & Funções", MetodosDeExtensao.Executar},

                // Exceções
                { "Primeira exceção - Exceções", PrimeiraExcecao.Executar},
                { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // Api
                { "Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar},
                { "Lendo Arquivos - Usando Api", LendoArquivos.Executar},
                { "Exemplo File Info - Usando Api", ExemploFileInfo.Executar},
                { "Diretórios - Usando Api", Diretorios.Executar},
                { "Exemplo Directory Info - Usando Api", ExemploDirectoryInfo.Executar},
                { "Exemplo Path - Usando Api", ExemploPath.Executar},
                { "Exemplo DateTime - Usando Api", ExemploDateTime.Executar},
                { "Exemplo TimeSpan - Usando Api", ExemploTimeSpan.Executar},

                // Api
                { "LINQ #01 - Tópicos Avançados", LINQ1.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}