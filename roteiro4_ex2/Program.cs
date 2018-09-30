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

            int i, qntM=0, qntH=0, somaiH=0 ,somaTidade=0, somaiM=0, exp=0, Mexp=0, H35a45=0, menoriM=0, idade;
            char sexo = ' ', experiencia = ' ';
            bool check=false;
            for (i = 0; i < 30; i++)
            {

                do
                {
                    Console.Write("\nDigite o sexo do candidato [M] para Masculino ou [F] para Feminino: ");
                    sexo = char.Parse(Console.ReadLine().ToUpper());

                    if(!(sexo.Equals('M') || sexo.Equals('F')))
                    {
                        Console.WriteLine("\nO valor digitado é inválido digite novamente");
                        check = true;
                    }
                    else
                    {
                        if (sexo.Equals('M'))
                        {
                            qntH++;
                        }
                        else if (sexo.Equals('F'))
                        {
                            qntM++;
                        }

                        Console.WriteLine("\nO candidato possui experiencia? [S] para Sim ou [N] para Não");
                        experiencia = char.Parse(Console.ReadLine().ToUpper());

                        if (!(experiencia.Equals('S') || experiencia.Equals('N')))
                        {
                            Console.WriteLine("\nO valor digitado é inválido digite novamente");
                            check = true;
                        }
                        else
                        {
                            if (experiencia.Equals('S'))
                            {
                                exp++;
                            }
                            if(experiencia.Equals('S') && sexo.Equals('F'))
                            {
                                Mexp++;
                            }
                            Console.Write("\nDigite a idade do candidato: ");
                            idade = int.Parse(Console.ReadLine());

                            if (idade <= 0)
                            {
                                Console.WriteLine("\nO valor digitado é inválido digite novamente");
                                check = true;
                            }
                            else
                            {
                                somaTidade += idade;
                                if (sexo.Equals('M'))
                                {
                                    somaiH += idade;
                                    if (idade >= 35 && idade <= 45)
                                    {
                                        H35a45++;
                                    }
                                }
                                else if (sexo.Equals('F'))
                                {
                                    if (experiencia.Equals('S')) { }
                                    somaiM += idade;
                                }
                                    if (i == 0) {
                                        menoriM = idade;
                                    }
                                    else
                                    {
                                        if (menoriM < idade)
                                        {
                                            menoriM = idade;
                                        }
                                    }
                                }
                            }
                            
                        }


                        
                        
                    }

                } while (check==true);

               

                i++;
            }
            Console.WriteLine("A quantidade de candidatos do sexo feminino é: "+qntM+" candidatas.");
            Console.WriteLine("A quantidade de candidatos do sexo masculino é:"+qntH+" candidatos.");
            Console.WriteLine("A idade média dos homens é:"+somaiH/qntH+" anos.");
            Console.WriteLine("A idade média dos homens é:" + somaiH / qntH + " anos.");




        }
    }
}
