﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoque
{
    [System.Serializable]
    internal class Curso: Produto, IEstoque
    {
        public string autor;
        private int vagas;
        public Curso(string nome, double preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar no curso: {nome}");
            Console.WriteLine("Digite a Qtd. de vagas você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Consumir vagas no curso: {nome}");
            Console.WriteLine("Digite a Qtd. que você quer consumir: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas -= entrada;
            Console.WriteLine("Saida registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("===================");
        }
    }
}