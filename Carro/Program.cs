﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c;
            Lista listadealunos = new Lista();
            int menu;
            do
            {
                menu = opcaoMenu();
                switch (menu)
                {
                    case 1:
                        c = novoObjeto();
                        listadealunos.inserirFinal(c);
                        break;
                    case 2:
                        listadealunos.Imprimir();
                        break;
                    case 3:
                        listadealunos.Qtde();
                        break;


                }
            } while (menu != 0);


        }
        static int opcaoMenu()
        {
            int o;
            do
            {
                Console.Write("menu de escolhas: \n1-Inserir\n2-Imprimir\n3-Quantidade de elementos\n4-Sair\n");
                o = int.Parse(Console.ReadLine());
                if (o < 1 || o > 4)
                    Console.WriteLine("opcao invalida Digite novamnte");
            } while (o < 1 || o > 4);
            return o;
        }
        static Carro novoObjeto()
        {
            Carro n = new Carro();
            Console.Write("Digite a cor: ");
            n.cor = Console.ReadLine();
            Console.Write("\nDigite o ano: ");
            n.ano = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o modelo: ");
            n.modelo = Console.ReadLine();
            n.prox = null;
            return n;
        }
    }
}
