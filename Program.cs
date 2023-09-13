using System;

namespace TextEditor {
    class Program {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("  LUCKZIN STUDIO CODE  ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("[1] - Abrir arquivo");
            Console.WriteLine("[2] - Criar novo arquivo");
            Console.WriteLine("[0] - Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option) {
                case 0: Valeu(); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir() {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path)) {
                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("  LUCKZIN STUDIO CODE  ");
                Console.WriteLine("-----------------------");
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.WriteLine("Pressione ENTER para voltar ao menu.");
            Console.ReadLine();
            Menu();
        }

        static void Editar() {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("  Digite seu texto abaixo.");
            Console.WriteLine("  Pressione ESC para sair.");
            Console.WriteLine("----------------------------");

            string text = "";

            do {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text) {
            Console.Clear();
            Console.WriteLine("Digite o caminho para salvar o arquivo: ");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path)) {
                file.Write(text);
            }

            Console.WriteLine($"O arquivo foi salvo em {path} com sucesso!");
            Console.ReadLine();
            Menu();
        }

        static void Valeu() {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Muito obrigado por utilizar meu sistema. Espero que tenha gostado e volte a usar!");
            Console.WriteLine("Abraço do Luckzin :)");
            Console.WriteLine("---------------------------------------------------------------------------------");
            System.Environment.Exit(0);            
        }
    }
}