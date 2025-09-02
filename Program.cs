using System;

class Program
{
    static void Main()
    {
        // Entrada
        Console.Write("Hora de início (hh mm): ");
        string[] inicio = Console.ReadLine().Split(' ');
        int horaInicio = int.Parse(inicio[0]);
        int minutoInicio = int.Parse(inicio[1]);

        Console.Write("Hora atual (hh mm): ");
        string[] atual = Console.ReadLine().Split(' ');
        int horaAtual = int.Parse(atual[0]);
        int minutoAtual = int.Parse(atual[1]);

        // Converte tudo para minutos
        int inicioTotal = horaInicio * 60 + minutoInicio;
        int atualTotal = horaAtual * 60 + minutoAtual;

        // Calcula a duração
        int duracao = atualTotal - inicioTotal;
        int horas = duracao / 60;
        int minutos = duracao % 60;

        // Saída
        Console.WriteLine($"Tempo total: {horas}h{minutos}min");
    }
}

