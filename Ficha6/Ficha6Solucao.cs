using System;

namespace Ficha6
{
    public class Ficha6Solucao
    {
        #region Exercicio 1

        public static void Exercicio1()
        {
            Console.WriteLine("Qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }







        /// <summary>
        /// Escrever Olá
        /// </summary>
        /// <param name="nome"> o nome a apresentar</param>

        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
        #endregion


        #region Exercicio 2

        public static void Exercicio2()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            var num1Conv = ConvertStringParaNumero(num1);
            var num2Conv = ConvertStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);

        }

        public static int ConvertStringParaNumero(string num)
        {
            var parseOK = int.TryParse(num, out int parsedNum);
            //return parsedNum? 
            if (parseOK)
            {
                return parsedNum;
            }
            else
            {
                return 0;
            }
        }

        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
        }

        #endregion

        #region Exercicio 3

        public static int LerNumEConverter()
        {
            Console.WriteLine("Número?");
            var num = Console.ReadLine();
            return ConvertStringParaNumero(num);
        }
        public static void Exercicio3()
        {
            var acomulador = LerNumEConverter();
            acomulador += LerNumEConverter();
            acomulador += LerNumEConverter();
            acomulador += LerNumEConverter();
            acomulador += LerNumEConverter();
            acomulador += LerNumEConverter();
            acomulador += LerNumEConverter();
            acomulador += LerNumEConverter();
            acomulador += LerNumEConverter();
            Console.WriteLine(acomulador);

        }

        #endregion

        #region Exercicio 4

        public static void Exercicio4()
        {
            Console.WriteLine("primeiro numero?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo numero?");
            int num2 = int.Parse(Console.ReadLine());
            int c = num1;
            num1 = num2;
            num2 = c;
            Console.WriteLine("Valor nr 1 =" + num2);
            Console.WriteLine("Valor nr 2 =" + num1);


        }


        #endregion

        #region Exercicio 5a

        public static void Exercicio5a()
        {
            Console.WriteLine("Primeiro nr?");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo nr?");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro nr?");
            var num3 = int.Parse(Console.ReadLine());
            CalcNuma(num1, num2, num3);



        }

        private static void CalcNuma(int n1, int n2, int n3)
        {
            var r = n1 + n2 * n3;
            Console.WriteLine("O resultado é " + r);
        }

        #endregion


        #region Exercicio 5b

        public static void Exercicio5b()
        {
            var n1 = LerNumEConverter();
            var n2 = LerNumEConverter();
            var n3 = LerNumEConverter();
            CalcNumB(n1, n2, n3);

        }

        public static void CalcNumB(int n1, int n2, int n3)
        {
            var resultado = (n1 + n2) % n3;
            Console.WriteLine("(" + n1 + "+" + n2 + ")" + "%" + n3 + "=" + resultado);
        }

        #endregion


        #region Exercicio 5c

        public static void Exercicio5c()
        {
            var num1 = LerNumEConverter();
            var num2 = LerNumEConverter();
            var num3 = LerNumEConverter();
            var num4 = LerNumEConverter();

            Calcnumc(num1, num2, num3, num4);

        }

        private static void Calcnumc(int n1, int n2, int n3, int n4)
        {
            Console.WriteLine(n1 + n2 * n3 / n4);
        }

        #endregion

        #region Exercicio 5d

        public static void Exercicio5d()
        {
            var n1 = LerNumEConverter();
            var n2 = LerNumEConverter();
            var n3 = LerNumEConverter();
            var n4 = LerNumEConverter();
            var n5 = LerNumEConverter();
            var n6 = LerNumEConverter();
            CalcNumD(n1, n2, n3, n4, n5, n6);
        }

        public static void CalcNumD(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            var resultado = (n1 + (n2 / n3 * n4) - (n5 % n6));
            Console.WriteLine("O resultado é  " + resultado);
        }

        #endregion

        #region Exercicio 6

        public static void Exercicio6()
        {
            Console.WriteLine("Qual o numero?");
            var nr = int.Parse(Console.ReadLine());
            MultN(nr);


        }
        public static void MultN(int num)
        {
            Console.WriteLine(num + " * 1 = " + num * 1);
            Console.WriteLine(num + " * 2 = " + num * 2);
            Console.WriteLine(num + " * 3 = " + num * 3);
            Console.WriteLine(num + " * 4 = " + num * 4);
            Console.WriteLine(num + " * 5 = " + num * 5);
            Console.WriteLine(num + " * 6 = " + num * 6);
            Console.WriteLine(num + " * 7 = " + num * 7);
            Console.WriteLine(num + " * 8 = " + num * 8);
            Console.WriteLine(num + " * 9 = " + num * 9);
            Console.WriteLine(num + " * 10 = " + num * 10);
        }


        #endregion

        #region Exercicio 7

        public static void Exercicio7()
        {
            Console.WriteLine("Qual o primeiro nr?");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo nr?");
            var n2 = int.Parse(Console.ReadLine());
            var sum = n1 + n2;
            var media = sum / 2;
            Console.WriteLine("Média é " + media);

            

        }

        #endregion

        #region Exercico 8

        public static void Exercicio8()
        {
            Console.WriteLine("Qual o 1º nr?");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 2º nr?");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 3º nr?");
            var n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 4º nr?");
            var n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 5º nr?");
            var n5 = int.Parse(Console.ReadLine());
            var sum = n1 + n2 + n3 + n4 + n5;
            var media = sum / 5;
            Console.WriteLine("Média é " + media);
        }


        #endregion

        #region Exercicio 9

        public static void Exercicio9()
        {
            Console.WriteLine("Qual o 1º nr?");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 2º nr?");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 3º nr?");
            var n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 4º nr?");
            var n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 5º nr?");
            var n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 6º nr?");
            var n6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 7º nr?");
            var n7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 8º nr?");
            var n8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 9º nr?");
            var n9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o 10º nr?");
            var n10 = int.Parse(Console.ReadLine());

            var sum = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
            var media = sum / 10;
            Console.WriteLine("Média é " + media);
        }

        #endregion

        #region Exercicio 10

        public static void Exercicio10()
        {
            Console.WriteLine("Qual o caracter?");
            var car = Console.ReadLine();
            Console.WriteLine(car + car + car);
            Console.WriteLine(car + car + car);
            Console.WriteLine(car + car + car);
        }

        #endregion

        #region Exercicio 11

        public static void Exercicio11()
        {
            Console.WriteLine("Qual o nome do 1º produto?");
            var nomep1 = (Console.ReadLine());
            Console.WriteLine("Qual o preço do 1º produto?");
            var precop1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade do 1º produto?");
            var quantp1 = int.Parse(Console.ReadLine());
            var total1 = precop1 * quantp1;
            

            Console.WriteLine("Qual o nome do 2º produto?");
            var nomep2 = (Console.ReadLine());
            Console.WriteLine("Qual o preço do 2º produto?");
            var precop2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade do 3º produto?");
            var quantp2 = int.Parse(Console.ReadLine());
            var total2 = precop2 * quantp2;
            Console.WriteLine("Valor total " + nomep1 + " = " + (precop1 * quantp1));
            Console.WriteLine("Valor total " + nomep2 + " = " + (precop2 * quantp2));
            Console.WriteLine("Valor total = " + (total1 + total2));
                                           
        }

        #endregion

        #region Exercicio 2_1_1


        public static void Exercicio2_1_1()
        {
            Console.WriteLine("Diz-me algo que eu não saiba!");
            var frase = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + frase);
        }

        #endregion

        #region Exercicio 2_1_2

        public static void Exercicio2_1_2()
        {
            Console.WriteLine("Qual 1º nr?");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual 2º nr?");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O primeiro número é " + n1 + " o segundo número é " + n2);
        }


        #endregion

        #region Exercicio 2_1_3

        public static void Exercicio2_1_3()
        {
            Console.WriteLine("Introduz a temperatura");
            var temp = int.Parse(Console.ReadLine());
            var tempF = temp * 9 / 5 + 32;
            var tempK = temp + 273.15;
            Console.WriteLine("A temperatura " + temp + "ºC é " + tempF + " ºF e " + tempK + "ºK");
        }

        #endregion

        #region Exercicio3_1

        public static void Exercicio3_1()
            
        {
            Console.WriteLine("Quantas horas?");
            var horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos minutos?");
            var minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos segundos?");
            var segundos = int.Parse(Console.ReadLine());
            var total = horas * 3600 + minutos * 60 + segundos;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos + " é equivalente a " + total + " segundos");
        }


        #endregion

        #region Exercicio3_2

        public static void Exercicio3_2() 
        {
            Console.WriteLine("Qual o raio?");
            var raio = int.Parse(Console.ReadLine());
            double perimetro = 2 * 3.14 * raio;
            double area = raio * raio * 3.14;
            Console.WriteLine("A área do circulo é " + area + " e o perimetro é " + perimetro);
        }
        

        #endregion

        public static void Exemplos()
        {
            Console.WriteLine("Introduza o valor");
            var val = Console.ReadLine();
            Console.WriteLine("Introduza o caracter");
            var cha = Console.ReadLine();
            Console.WriteLine("Introduza a tecla");
            var tec = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Valor " + val + "\nCaracter " + cha + "\nTecla " + tec.Key);
            Console.WriteLine($"\nValor {val} \nCaracter {cha} \nTecla {tec.Key}");
            Console.WriteLine(@"Valor {0}, \nCaracter {1}, \nTecla {2}", val, cha, tec);

        }

    }
}