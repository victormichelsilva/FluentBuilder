using System;

namespace BuilderPadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailBuilder = new EmailBuilder()
                                .To("microsoft@email.com")
                                .From("victormichelsilva@gmail.com")
                                .Subject("Microsoft Build")
                                .Body("Microsoft Build 2021\n\t25 a 27 de Maio 2021" +
                                        "\n\tNovidades Windows, Azure, Office e mais.")
                                .CriaEmail();

            Console.WriteLine(emailBuilder.ToString());
            Console.ReadLine();
        }
    }
}
