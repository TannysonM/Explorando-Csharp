using DIO_Explorando.Models;
using System.Globalization;

string dataString = "2024-14-03 04:38";

//Validando TryParse com valores validos
bool validacao = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None,
                        out DateTime data);
//Comando que formatar a data - variavel; formato; cultura; estilo e parametro de saida

if(validacao)
{
    Console.WriteLine($"Conversão valida! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data valida");
}

//Console.WriteLine(data);

 
 
 
 
 
 
 
 /*
// formatação do tipo DATETIME - Trabalhando com data e horas
//DateTime data = DateTime.Now;

//Determinando uma data especifica(Bom para organizar um arquivo)
DateTime data = DateTime.Parse("31-08-2024 21:37");

//Console.WriteLine(data);
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(data.ToString("dd/MM/yyyy"));
//Console.WriteLine(data.ToString("dd/MM HH:mm"));
//Console.WriteLine(data.ToString("dd-MM-yyyy"));
Console.WriteLine(data);
Console.WriteLine(data.ToShortDateString());//Só data
Console.WriteLine(data.ToShortTimeString());//Só a hora

 ------------------------------------------------------------------------------------------
 CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); 
// Formata o sistema conforme a cultura que deseja programa

decimal valorMonetario = 1548.40M;

//Console.WriteLine($"{valorMonetario:C}");
//Especificando diretamente na leitura e apresentação na tela
Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

//Declaração de porcentagem
double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

//# - Separador
int number = 123456;

Console.WriteLine(number.ToString("##-##-##"));


 ---------------------------------------------------------------------------
Pessoa p1 = new Pessoa("Maria", "Cleide");
 
 //p1.Name = "Maria";
 //p1.Sobrenome = "Cleide";

 Pessoa p2 = new Pessoa("Leonardo", "Rodrigues");
 //p2.Name = "Leonardo";
 //p2.Sobrenome = "Rodrigues";

 Pessoa p3 = new Pessoa("Tays", "Pereira");
 //p3.Name = "Tays";
 //p3.Sobrenome = "Pereira";

 Curso cursoIngles = new Curso();
 cursoIngles.Nome = "Curso de Ingles";
 cursoIngles.Alunos = new List<Pessoa>();

 cursoIngles.AdicionarAluno(p1);
 cursoIngles.AdicionarAluno(p2);
 cursoIngles.AdicionarAluno(p3);
 cursoIngles.ListarAluno();

 

 ---------------------------------------------------------------------------------------
 Pessoa p1 = new Pessoa();
 
 p1.Name = "Maria Cleide";
 p1.Idade = 53;
 p1.Apresentacao();
 */