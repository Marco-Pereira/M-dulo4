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

            Console.WriteLine("Qual a operação que deseja realizar?" + "\n + \n - \n * \n / \n % ");
            string oper = Console.ReadLine();
            Console.WriteLine("Qual o primeiro nr?");
            var nr1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo nr?");
            var nr2 = double.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    Console.WriteLine("= " + (nr1 + nr2));
                    break;
                case "-":
                    Console.WriteLine("= " + (nr1 - nr2));
                    break;
                case "*":
                    Console.WriteLine("= " + (nr1 * nr2));
                    break;
                case "/":
                    Console.WriteLine("= " + (nr1 / nr2));
                    break;
                case "%":
                    Console.WriteLine(nr1%nr2);
                    break;
                default:
                    Console.WriteLine("Não é um operador");
                    break;
                                                                               
            }




        }

        #endregion

        #region Exercicio1_11

        public static void Exercicio1_11()
        {
            Console.WriteLine("Qual o caracter?");
            string car = Console.ReadLine();
            var i = 0;

            while (i < 3)
            {
                var j = 0;
                while (j < 3)
                {
                    Console.Write(car);
                    j++;
                }
                Console.Write("\n");
                i++;
            }


        }

        #endregion

        #region Exercicio1_12

        public static void Exercicio1_12()
        {
            Console.WriteLine("Qual o caracter?");
            string car = Console.ReadLine();
            Console.WriteLine("Qual o nr?");
            var n = int.Parse(Console.ReadLine());
            var i = 0;
            
            
            while (i < n)
            {
                var j = 0;
                while (j < n)
                {
                    Console.Write(car);
                   
                    j++;
                }
                Console.WriteLine("\n");
                i++;
            }
            for (var k = 0; k < n; k++) 
            {
                for (var l = 0; l < n; l++) 
                {
                    Console.Write(car);
                }
                Console.WriteLine("\n");
            }   


        }


        #endregion

        #region Exercicio1_13

        public static void Exercicio1_13()
        {
            Console.WriteLine("Qual o primeiro caracter?");
            string car1 = Console.ReadLine();
            Console.WriteLine("Qual o segundo caracter?");
            string car2 = Console.ReadLine();
            Console.WriteLine("Qual o primeiro número?");
            var nr1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo número?");
            var nr2 = double.Parse(Console.ReadLine());

            
            for (var l = 0; l < nr1; l++)
            {
                var pos = 2;
                for (var c = 0; c < nr2; c++)
                {
                    if (pos % 2 == 0)
                    {
                        Console.Write(car1);
                    }
                    else
                    {
                        Console.Write(car2);
                    }
                    pos++;
                }
                Console.WriteLine("\n");

            }


        }
        #endregion

        #region ExercicioGII_1_1

        public static void ExercicioGII_1()
        
        
        {
            Console.WriteLine("Introduza a temperatura");
            var temp = double.Parse(Console.ReadLine());
            var escala = "";

            while (escala != "C" && escala != "K" && escala != "F")
            {
                Console.WriteLine("Em que escala? (C, K ou F");
                escala = Console.ReadLine();
            }
            switch (escala)
            {
                case "C":
                    Console.WriteLine(temp + " ºC é equivalente a " + (temp + 273.15) +
                                        "ºK e " + (temp * 9 / 5 + 32) + "ºF");
                break;
                
                case "K":
                    Console.WriteLine(temp + " ºK é equivalente a " + (temp - 273.15) + " ºC e " + 
                                        (temp * 9 / 5 - 459.67) + " ºF ");
                break;

                case "F":
                    Console.WriteLine(temp + " ºF é equivalente a " + ((temp - 32) + 5 / 9) + 
                        "ºC e " + ((temp + 459.67) * 5 / 9) + " ºK ");
                break;

                default: Console.WriteLine("Em que escala? (C, K ou F");
                         escala = Console.ReadLine();
                break;



            }


        }



        #endregion

        #region Calculadora




        #endregion

    }
}
