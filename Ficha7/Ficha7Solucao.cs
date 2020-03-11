using System;

namespace Ficha7
{

    public class Ficha7Solucao
    {

        #region Exercicio1_1

        public static void Exercicio1_1()
        {
            Console.WriteLine("Qual a nota?");
            var nr = double.Parse(Console.ReadLine());

            if (nr > 9.44)
            {
                Console.WriteLine("Passou");
            }
            else
            {
                Console.WriteLine("Chumbou");
            }




        }


        #endregion


        #region Exercicio1_2

        public static void Exercicio1_2()
        {
            Console.WriteLine("Qual a altura?");
            var altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso?");
            var peso = double.Parse(Console.ReadLine());
            var calbmi = CalcBmi(altura, peso);

            if (calbmi < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if (calbmi > 18.5 && calbmi < 24.9)
            {
                Console.WriteLine("Normal...");
            }
            else if (calbmi >= 25 && calbmi < 29.9)
            {
                Console.WriteLine("Acima do peso!");
            }
            else
            {
                Console.WriteLine("Obeso!!!");
            }



        }

        public static double CalcBmi(double altura, double peso)
        {
            var bmi = peso / (altura * altura);
            return bmi;
        }


        #endregion

        #region Exercicio1_3

        public static void Exercicio1_3()
        {
            Console.WriteLine("Qual o nr?");
            var nr = int.Parse(Console.ReadLine());
            
            if (nr % 3== 0 && nr % 7 == 0)
            {
                Console.WriteLine("O numero " + nr + " é multiplo de 3 e 7");
            } 
            else if (nr % 3 == 0)
            {
                Console.WriteLine("O numero " + nr + " é multiplo apenas multiplo de 3");

            }
            else if (nr % 7 == 0)
            {
                Console.WriteLine("O numero " + nr + " é multiplo de 7");

            }
            else
            {
                Console.WriteLine("O nr " + nr + " não é multiplo de 3 nem 7");
            }
        }

        #endregion

        #region Exercicio1_4

        public static void Exercicio1_4()
        {
            Console.WriteLine(" Qual o nr?");
            var nr = int.Parse(Console.ReadLine());

            if (nr >= 30 && nr <= 50)
            {
                Console.WriteLine("O nr " + nr + " encontra-se entre 30 e 50");
            }
            else
            {
                Console.WriteLine("O nr " + nr + " não se encontra entre 30 e 50");
            }
        }

        #endregion

        #region Exercicio1_5

        public static void Exercicio1_5()
        {
            Console.WriteLine(" Qual o nr?");
            var nr = int.Parse(Console.ReadLine());

            if (nr > 10 && nr < 30)
            {
                Console.WriteLine("O nr " + nr + " encontra-se entre 10 e 30");
            }
            else
            {
                Console.WriteLine("O nr " + nr + " não se encontra entre 10 e 30");
            }
        }


        #endregion

        #region Exercicio1_6

        public static void Exercicio1_6()
        {
            Console.WriteLine("Escolha o nr do andar que pretende ir");
            var andar = int.Parse(Console.ReadLine());

            if (andar == 3 || andar == 5)
                {
                Console.WriteLine("Andar indisponivel");
                }
            else if (andar >= -2 && andar <= 6)
            {
                Console.WriteLine("Entre no elevador e aguarde");
            }
            else
            {
                Console.WriteLine("andar não existe!");
            }

        }

        #endregion

        #region Exercicio1_7

        public static void Exercicio1_7()
        {


            Solicitar10NumerosESomar1();
            Solicitar10NumerosESomar2();
        }

        public static void Solicitar10NumerosESomar1()
        {
            var total = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Qual o nr?");
                var nr = int.Parse(Console.ReadLine());
                var temp = total;
                total = total + nr;
                Console.WriteLine(temp + " + "+ nr + " = " + total);
            }
            Console.WriteLine("Total = " + total);
        }

        public static void Solicitar10NumerosESomar2()
        {
            var total = 0;
            var i = 0;
            while (i < 10) 
            {
                Console.WriteLine("Qual o nr?");
                var nr = int.Parse(Console.ReadLine());
                total = total + nr;
                i++;
            }
            Console.WriteLine("Total = " + total);
        }
        #endregion

        #region Exercicio1_8

        public static void Exercicio1_8()
        {
            var count = 0;
            double total = 0;
            while (count < 5)
            {
               total = total + PedirProduto();
                count++;
            }
            Console.WriteLine("Total dos produtos é " + total+ " EUR");
        }

        public static double PedirProduto() 
        {
            Console.WriteLine("Qual o nome do produto?");
            string nump = Console.ReadLine();
            Console.WriteLine("Qual o preço do produto?");
            double precp = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade do produto?");
            double quantp = double.Parse(Console.ReadLine());
            var totalP = precp * quantp;
            Console.WriteLine("Valor total " + nump +" = "+ totalP+" EUR ");
            return totalP;

        }


        #endregion

        #region Exercicio1_9

        public static void Exercicio1_9()
        {
            int nr = 0;
            int total = 0;
            int quantnr = 0;
            Console.WriteLine("Qual o nr?");
            nr = int.Parse(Console.ReadLine());
            total = total + nr;
            while (nr > 0)
            {
                
                Console.WriteLine("Qual o nr?");
                nr = int.Parse(Console.ReadLine());
                total = total + nr;
                quantnr++;
            }
            int media = total / quantnr;
            Console.WriteLine("A media é " + media);

        }

        #endregion

        #region Exercicio1_10

        public static void Exercicio1_10()
        {

            mm
        }

        #endregion
    }
}
