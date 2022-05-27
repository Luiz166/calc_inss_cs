using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_inss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto;
            float resultado = 0f;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Informe o seu salário bruto");
            salarioBruto = float.Parse(Console.ReadLine());

            //1° Faixa
            resultado = resultado + 1212 * 0.075f;
            Console.WriteLine("Desconto primeira alíquota: " + resultado);

            //2°Faixa
            if (salarioBruto > 1212 && salarioBruto <= 2427.35f)
            {
                resultado = ((salarioBruto - 1212) * 0.09f) + resultado;
                Console.WriteLine("Desconto segunda alíquota: " + resultado);
            }
            //3° faixa
            else if (salarioBruto > 2427.35f && salarioBruto <= 3641.03f)
            {
                resultado = ((1215.35f) * 0.09f) + resultado;
                Console.WriteLine("Desconto segunda alíquota: " + resultado);
                resultado = ((salarioBruto - 1212.35f - 1212) * 0.12f) + resultado;
                Console.WriteLine("Desconto terceira alíquota: " + resultado);
            }
            //4° faixa
            else if(salarioBruto > 3641.03f && salarioBruto <= 7087.22)
            {
                resultado = ((1212.35f) * 0.09f) + resultado;
                Console.WriteLine("Desconto segunda alíquota: " + resultado);
                resultado = ((1212.68f) * 0.12f) + resultado;
                Console.WriteLine("Desconto terceira alíquota");
                resultado = (salarioBruto - 1213.68f - 1215.35f - 1212) * 0.14f + resultado;
                Console.WriteLine("Desconto quarta alíquota");
            }
            else
            {
                Console.WriteLine("Inválido");
            }
            Console.WriteLine("Total de contribuição    |R$" + resultado);
            Console.WriteLine("------------------------------------------");
            float salarioliq = salarioBruto - resultado;
            Console.WriteLine("Salário Líquido          |R$" + salarioliq);
            Console.ReadLine();
        }
    }
}
