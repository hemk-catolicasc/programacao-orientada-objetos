namespace  SistemaBibliotecaMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela minhatela = new Tela(ConsoleColor.Red, ConsoleColor.Black);
            minhatela.ConfigurarTela();

            string op;
            List<string> opcoesMenu = new List<string>();
            opcoesMenu.Add("1 - Livros      ");
            opcoesMenu.Add("2 - Alunos      ");
            opcoesMenu.Add("3 - Empréstimos ");
            opcoesMenu.Add("4 - Relatórios  ");
            opcoesMenu.Add("5 - Sair        ");

            while (true)
            {
                minhatela.MontarMoldura(0, 0, 79, 24, "Sistema de Biblioteca");
                op = minhatela.MostrarMenu(opcoesMenu, 31, 2);

                if (op == "5")
                {
                    Console.Clear();
                    minhatela.Centralizar("Tchau", 0, 79, 0);
                }
            }
        }
    }
}