class NoLista
{
    public int chave;
    public string nome;
    public NoLista? prox;
    public NoLista(int c, string n)
    {
        nome = n;
        chave = c;
        prox = null;
    }
}

class Lista
{
    private NoLista? prim, ult;

    public Lista()
    {
        prim = ult = null;
    }

    public void Inserir(NoLista item)
    {
        if (prim == null)
            prim = item;
        else if (ult != null)
            ult.prox = item;
        ult = item;
    }

    public void Imprimir()
    {
        NoLista? aux = prim;
        while (aux != null)
        {
            Console.WriteLine("{0} - {1}", aux.chave, aux.nome);
            aux = aux.prox;
        }
    }

    public NoLista? Pesquisar(int c)
    {
        NoLista? aux = prim;
        while (aux != null && aux.chave != c)
        {
            aux = aux.prox;
        }
        return aux;
    }

    public bool Remover(int c)
    {
        NoLista? aux = prim, ant = null;
        while (aux != null && aux.chave != c)
        {
            ant = aux;
            aux = aux.prox;
        }
        if (aux != null)
        {
            if (ant != null) // não é o primeiro 
                ant.prox = aux.prox;
            else // é o primeiro
                prim = aux.prox;
            if (aux == ult) // é o último
                ult = ant;
            aux.prox = null; // desconecta o nó da lista
            return true;
        }
        return false;
    }
}
