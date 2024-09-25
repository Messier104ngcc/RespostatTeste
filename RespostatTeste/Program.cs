
//1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número,
//ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
int numero = int.Parse(Console.ReadLine());

if (PertenceFibonacci(numero))
{
    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
}


static bool PertenceFibonacci(int numero)
{
    int anterior = 0;
    int atual = 1;

    if (numero == 0 || numero == 1)
    {
        return true;
    }
    while (atual < numero)
    {
        int proximo = anterior + atual;
        anterior = atual;
        atual = proximo;
    }
    return atual == numero;
}





//2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula,
//além de informar a quantidade de vezes em que ela ocorre.



Console.WriteLine("Digite uma string:");
string input = Console.ReadLine();

int count = ContarLetraA(input);

if (count > 0)
{
    Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) aparece {count} vezes.");
}
else
{
    Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não foi encontrada.");
}

static int ContarLetraA(string texto)
{
    int contador = 0;

    foreach (char c in texto)
    {
        if (c == 'a' || c == 'A')
        {
            contador++;
        }
    }

    return contador;
}


//3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
//imprimir(SOMA);

//Ao final do processamento, qual será o valor da variável SOMA?

//Resp. 77

int INDICE = 12;
int SOMA = 0;
int K = 1;

while (K < INDICE)
{
    K = K + 1;
    SOMA = SOMA + K;
}

Console.WriteLine(SOMA);


//4) Descubra a lógica e complete o próximo elemento:
//a) 1, 3, 5, 7, > 9
//b) 2, 4, 8, 16, 32, 64, > 128
//c) 0, 1, 4, 9, 16, 25, 36, > 49
//d) 4, 16, 36, 64, > 100
//e) 1, 1, 2, 3, 5, 8, > 13
//f) 2,10, 12, 16, 17, 18, 19, > 20

//5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes.
//Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser.
//Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir,
//usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

//Resp. Usaria o metodo de temperatura das lampadas , pois quando uma lampada está ligada ela gera calor assim almentando  sua temperatura ,
// primeiramente ligaria o primeiro interruptor por alguns minutos , depois desligaria e ligaria o segundo interruptor e deixaria ligado, já o terceiro eu 
// deixava sempre desligado, depois iria na primeira sala e verificaria o estado da primeira lampada, se tivesse apagada , mais se estivesse quente, 
// concluiria que era o primeiro interruptor, que deixei ligado por alguns minutos e depois desliquei, depois iria na segunda sala, se a lampada estisse acesa, concluiria que era 
// o segundo interruptor, pois deixei ele ligado quando sai da sala de interruptores, e no final o utimo interruptor, já tinha a resposta
// pois o utimo interruptor deixei desligado o tempo todo, fim.