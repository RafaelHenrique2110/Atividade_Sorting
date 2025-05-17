namespace Sorting.basic_class.dynamic
{
    public class ListaDynamic
    {
        public Celula? primeiro;
        public Celula? ultimo;
        public int tamanho;

        public ListaDynamic()
        {
            primeiro = null;
            ultimo = null;
            tamanho = 0;
        }
        public int Tamanho()
        {
            return tamanho;
        }
        public void Inserirprimeiro(int x)
        {
            Celula nova = new Celula(x);
            if (primeiro == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                nova.prox = primeiro;
                primeiro = nova;
            }
            tamanho++;
        }
        public void InserirUltimo(int x)
        {
            Celula nova = new Celula(x);
            if (primeiro == null)
            {
                primeiro = ultimo = nova;
            }
            else
            {
                ultimo.prox = nova;
                ultimo = nova;
            }
            tamanho++;
        }
        public Celula GetItem(int v)
        {
            Celula celula = primeiro;
            for (int i = 0; i <= v; i++)
            {

                Celula proxCelula;
                if (i < v)
                {
                    if (celula.prox != null)
                    {
                        proxCelula = celula.prox;
                        celula = proxCelula;
                    }

                }
                else return celula;
            }
            return null;
        }
        public void InserirPosicao(int x, int pos)
        {
            if (pos < 0 || pos > tamanho)
            {
                Console.WriteLine("Posição inválida!");
            }

            if (pos == 0)
            {
                Inserirprimeiro(x);
            }
            else if (pos == tamanho)
            {
                InserirUltimo(x);
            }
            else
            {
                Celula nova = new Celula(x);
                Celula i = primeiro;
                for (int j = 0; j < pos - 1; j++)
                {
                    i = i.prox;
                }
                nova.prox = i.prox;
                i.prox = nova;
                tamanho++;
            }
        }
        public int RemoverPrimeiro()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Lista vazia!");
            }
            int valor = primeiro.valor;
            primeiro = primeiro.prox;
            if (primeiro == null)
            {
                ultimo = null;
            }
            tamanho--;
            return valor;
        }
        public int Removerultimo()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Lista vazia!");
            }

            if (primeiro == ultimo)
            {
                int valor = primeiro.valor;
                primeiro = ultimo = null;
                tamanho--;
                return valor;
            }

            Celula i = primeiro;
            while (i.prox != ultimo)
            {
                i = i.prox;
            }

            int valorRemovido = ultimo.valor;
            i.prox = null;
            ultimo = i;
            tamanho--;
            return valorRemovido;
        }
        public int RemoverPosicao(int pos)
        {
            if (pos < 0 || pos >= tamanho)
            {
                Console.WriteLine("Posição inválida!");
            }

            if (pos == 0)
            {
                return RemoverPrimeiro();
            }
            else if (pos == tamanho - 1)
            {
                return Removerultimo();
            }
            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos - 1; j++)
                {
                    i = i.prox;
                }
                int valorRemovido = i.prox.valor;
                i.prox = i.prox.prox;
                tamanho--;
                return valorRemovido;
            }
        }
        public void Mostrar()
        {
            Console.WriteLine(" Lista ");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(GetItem(i).valor + " ");
            }

            Console.WriteLine(" ");

        }
    }
     
    
}
