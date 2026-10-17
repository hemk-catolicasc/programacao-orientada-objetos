using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tela tela = new Tela(ConsoleColor.Red, ConsoleColor.Black);
            tela.ConfigurarTela();

            LivroController livroController = new LivroController();
            AlunoController alunoController = new AlunoController();
            List<string> opcoes = new List<string>();
            string opcao;
            
            opcoes.Add(" 1 - Livros      ");
            opcoes.Add(" 2 - Alunos      ");
            opcoes.Add(" 3 - Empréstimos ");
            opcoes.Add(" 4 - Relatórios  ");
            opcoes.Add(" 0 - Sair        ");
            

            while (true)
            {
                tela.MontarMoldura(0,0,79,24,"Sistema de Biblioteca");
                opcao = tela.MostrarMenu(opcoes, 31, 2);
                
                if (opcao == "0")
                {
                    tela.Centralizar("Tchau...", 1, 78, 23);
                    Console.Clear();
                    break;
                }
                else if (opcao == "1") livroController.ExecutarCRUD();
                else if (opcao == "2") alunoController.ExecutarCRUD();
                else
                {
                    tela.Centralizar("Opção inválida! Acione uma tecla.",
                        1, 78, 23);
                    Console.ReadKey();
                }
            }
        }
    }
}
