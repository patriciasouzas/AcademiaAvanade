using System;

namespace Empresa.Setor.Projeto.Adicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### ADICAO ###");

            Console.Write("Informe o primeiro numero: ");

            string numero1 = Console.ReadLine();

            Console.Write("Informe o segundo numero: ");

            string numero2 = Console.ReadLine();

            Console.Write("");

            try
            {
                Convert.ToInt32(numero1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Primeiro dígito não foi possível ser convertido para inteiro");
            }

            //testar conversao do numero 2

            try
            {
                Convert.ToInt32(numero2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Segundo dígito não foi possível ser convertido para inteiro");
            }

            //exibir mensagem da operacao de adicao

            Console.WriteLine("A soma dos números digitados é: " + (Convert.ToInt32(numero1) + Convert.ToInt32(numero2)));

            Console.ReadKey();
        }
    }
}

