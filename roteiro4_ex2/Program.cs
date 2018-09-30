using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 2 –
• Quantidade de candidatos do sexo feminino
• Quantidade de candidatos do sexo masculino
• Idade média dos homens
• Idade média das mulheres com experiência
• Porcentagem dos homens entre 35 e 45 anos entre o total dos homens
• Menor idade entre as mulheres
• Porcentagem total (homens e mulheres) com experiência no serviço
Faça um programa que calcule as informações para um total de 30 candidatos */

            int i, quntM=0, quntH=0, mediaH=0, mediaMExp=0, exp=0, Mexp=0, H35a45=0, menoriM=0;
            char sexo=' ';
            bool check=false;
            for (i = 0; i < 30; i++)
            {

                do
                {
                    Console.Write("Digite o sexo do candidato [M] para Masculino ou [F] para Feminino: ");
                    sexo = char.Parse(Console.ReadLine().ToUpper());

                    if(!(sexo.Equals('M') || sexo.Equals('F')))
                    {
                        Console.WriteLine("O valor digitado é inválido digite novamente");
                        check = true;
                    }
                    else
                    {

                    }

                } while (check==true);

                i++;
            }
            




        }
    }
}
