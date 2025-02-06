using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    internal class Program
    {
        //Programa Principal
        static void Main(string[] args)
        {
            //Objeto de pessoa teste
            var daviOBJ = new
            {
                nome = "Davi",
                idade = 19,
                cadastro = true,
                saldo = 1400
            };


            Console.WriteLine("Olá seja Bem vindo ao programa com C# !");

            ValidarNome(daviOBJ.nome);

            ValidarIdade(daviOBJ.nome, daviOBJ.idade);

            ValidarCadastro(daviOBJ.cadastro, daviOBJ.nome);

            ValidarSaldo(daviOBJ.nome, daviOBJ.saldo);
        }

        //Validade de nome
        static void ValidarNome(string nome)
        {
            // Console.WriteLine("Primeiro, Digite seu Nome:");
            //  var entradaNome = Console.ReadLine();

            string NomeOP = "Davi";

            if (nome == NomeOP)
            {
                Console.WriteLine($"Bem vindo {nome}!");
            }
            else
            {
                Console.WriteLine($"Olá {nome}! Você é novo por aqui...");
            }

        }

        //Validador de Idade
        static void ValidarIdade(string nome, int idade)
        {
            //Console.WriteLine($"Digite sua idade {nome}");
            //var entradaIdade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 99)
            {
                Console.WriteLine($"Uau {nome} é de maior ja! com {idade}");
            }
            else if (idade >= 100)
            {
                Console.WriteLine("Você digitou uma idade inválida para nosso sistema! por favor enviar documentos para comprovar sua idade!");
            }
            else if (idade <= 17)
            {
                Console.WriteLine($"Você é de menor!");
            }
            else
            {
                Console.WriteLine("Você digitou uma data inválida");
            }
        }

        static void ValidarCadastro(bool cadastro, string nome)
        {
            if (cadastro == true)
            {
                Console.WriteLine($"{nome} Você possui cadastro ativo.");
            }
            else
            {
                Console.WriteLine($"{nome} Você não possui cadastro ativo.");
            }
        }

        static void ValidarSaldo(string nome, int saldo)
        {
            if (saldo >= 1250 && saldo <= 2000)
            {
                Console.WriteLine($"{nome} Você possui um saldo de R${saldo}! Você a média de um salário mínimo.");
            }
            else if (saldo > 2000 && saldo <= 5000)
            {
                Console.WriteLine($"{nome} Você possui um saldo de R${saldo}! Você recebe o salário de um Junior.");
            }
            
        }

    }
}
