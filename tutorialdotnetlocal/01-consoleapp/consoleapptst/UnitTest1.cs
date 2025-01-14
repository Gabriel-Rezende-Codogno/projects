using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Principal;
namespace consoleapptst;

public class ProgramTest
{
    [Fact]

   public void Test()
    {
     String[] args = {};

     Principal.Program.Main(args);
    }

     [Fact]

    public void MainTest()
    {
     String[] args = {"Hello World"};

     Principal.Program.Main(args);
    }

    [Theory]
    [InlineData("Hello World")]

    public void MainTest2(params string[] args)
    {
        Principal.Program.Main(args);
    }
    [Theory]
    [InlineData("Hello, World!")]
  public void MainArgs3Test(params string[] args)
  {
      using (var sw = new StringWriter())
      {
          Console.SetOut(sw);

          Program.Main(args);

          var result = sw.ToString().Trim();

          Debug.WriteLine(result);
      }
  }


  [Theory]
[InlineData("Hello, World!")]
public void MainArgs4test(params string[] args)
{
    using (var sw = new StringWriter()) // Captura a saída do console
    {
        Console.SetOut(sw); // Redireciona a saída do console para o StringWriter

        Program.Main(args); // Chama o método Main do programa com os argumentos fornecidos

        var result = sw.ToString().Trim(); // Obtém a saída do console e remove espaços extras

       

        // Verifica se result não é nulo
        Assert.NotNull(result); 

        // Verifica se result é do tipo string
        Assert.IsType<string>(result); 

         // Verifica se o resultado é o esperado
        Assert.Equal("Hello, World!", result);
    }
}
}