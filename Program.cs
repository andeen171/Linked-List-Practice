Lista l = new Lista();
string input, value = "", nome = "";
bool run = true;
NoLista? aux;
while (run)
{
    Console.WriteLine(" 1) Inserir\n 2) Pesquisar\n 3) Imprimir Lista\n 4) Sair");
    input = Console.ReadLine() ?? "";

    switch (input)
    {
        case ("1"):
            while (true)
            {
                Console.WriteLine("Digite o chave do usuario!(-1 para sair):");
                value = Console.ReadLine() ?? "-1";
                if (value == "-1")
                    break;
                Console.WriteLine("Digite o nome:");
                nome = Console.ReadLine() ?? "Jorgin da doze";
                l.Inserir(new NoLista(int.Parse(value), nome));
            }
            break;
        case ("2"):
            Console.WriteLine("Digite o valor que deseja pesquisar!");
            value = Console.ReadLine() ?? "0";
            aux = l.Pesquisar(int.Parse(value));
            if (aux != null)
            {
                Console.WriteLine($"{aux.chave} - {aux.nome}");
                Console.WriteLine("Deseja remover o usuario?:");
                input = Console.ReadLine() ?? "";
                if (input == "s" | input == "sim") {
                    l.Remover(aux.chave);
                    Console.WriteLine("Chave apagada com sucesso");
                }
            }
            else
                Console.WriteLine("Não encontrado!");
            break;
        case ("3"):
            l.Imprimir();
            break;
        case ("4"):
            Console.WriteLine("Tchau!!");
            run = false;
            break;
        default:
            break;
    }
}