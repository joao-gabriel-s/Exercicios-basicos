﻿using System;

namespace _3notas10alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Nota1dos10alunos = new double[10];
            double[] Nota2dos10alunos = new double[10];
            double[] Nota3dos10alunos = new double[10];
            double[] TRESnotasDoAluno = new double[3];
            double[] mediaAlunos = new double[10];

            double nota1;
            double nota2;
            double nota3;
            double Media;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira a primeira nota do aluno " + i);
                Nota1dos10alunos[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira a segunda nota do aluno " + i);
                Nota2dos10alunos[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira a terceira nota do aluno " + i);
                Nota3dos10alunos[i] = Convert.ToDouble(Console.ReadLine());
            }

            // MENOR NOTA DO ALUNO
            for (int h = 0; h < 10; h++)
            {

                TRESnotasDoAluno[0] = Nota1dos10alunos[h];
                nota1 = TRESnotasDoAluno[0];
                TRESnotasDoAluno[1] = Nota2dos10alunos[h];
                nota2 = TRESnotasDoAluno[1];
                TRESnotasDoAluno[2] = Nota3dos10alunos[h];
                nota3 = TRESnotasDoAluno[2];

                for (int i = 0; i < 3; i++)
                {
                    double auxiliar;
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (TRESnotasDoAluno[i] < TRESnotasDoAluno[j])
                        {
                            auxiliar = TRESnotasDoAluno[i];
                            TRESnotasDoAluno[i] = TRESnotasDoAluno[j];
                            TRESnotasDoAluno[j] = auxiliar;
                        }
                    }
                }

                Media = (nota1 + nota2) / 2;
                Console.WriteLine("Menor nota do aluno " + h + " é " + TRESnotasDoAluno[2] + " e a sua média é: " + Media);
                mediaAlunos[h] = Media;
                TRESnotasDoAluno[2] = 0;
            }

            // MÉDIA DA TURMA
            double soma = 0;
            foreach (var item in mediaAlunos)
            {
                soma += item;
            }
            Console.WriteLine("A média da turma é: " + soma / mediaAlunos.Length);
            Console.WriteLine("");
            Maior(TRESnotasDoAluno, Nota1dos10alunos, Nota2dos10alunos, Nota3dos10alunos);
        }

        // MAIOR NOTA DO ALUNO
        static double[] Maior(double[] tRESnotasDoAluno, double[] Nota1dos10alunos, double[] Nota2dos10alunos, double[] Nota3dos10alunos)
        {
            for (int h = 0; h < 10; h++)
            {

                tRESnotasDoAluno[0] = Nota1dos10alunos[h];
                tRESnotasDoAluno[1] = Nota2dos10alunos[h];
                tRESnotasDoAluno[2] = Nota3dos10alunos[h];

                for (int i = 0; i < 3; i++)
                {
                    double auxiliar;
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (tRESnotasDoAluno[i] > tRESnotasDoAluno[j])
                        {
                            auxiliar = tRESnotasDoAluno[i];
                            tRESnotasDoAluno[i] = tRESnotasDoAluno[j];
                            tRESnotasDoAluno[j] = auxiliar;
                        }
                    }
                }
                Console.WriteLine("Maior nota do aluno " + h + " é " + tRESnotasDoAluno[2]);
            }
            return tRESnotasDoAluno;
        }
    }
}