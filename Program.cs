using DIO_Explorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();
//Primeiro a gente atribui a chave, e depois o valor... Se fizer errado, o comando nao funciona.

estados.Add("DF", "Brasília");
estados.Add("GO", "Goias");
estados.Add("TO", "Tocantins");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach(KeyValuePair<string, string> siglas in estados)
{       /*OU pode usar "var"*/
    Console.WriteLine($"Siglas e estados cadastrados: {siglas.Key} - {siglas.Value}");
}

estados.Remove("DF");
estados.Add("MS", "Mato Grosso do Sul");

foreach(KeyValuePair<string, string> siglas in estados)
{       /*OU pode usar "var"*/
    Console.WriteLine($"Siglas e estados cadastrados: {siglas.Key} - {siglas.Value}");
}
string chave = "DF";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))//Comando para verificar se uma chave existe no sistema
{
  Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor inexistente. É seguro acrescentar a chave: {chave}");
}








































































 /*
 PILHA
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int caixa in pilha)
{
    Console.WriteLine($"Quantidade de caixas na pilha: {caixa}");
}

Console.WriteLine($"Removendo a caixa {pilha.Pop()} da pilha");//Não passa paramentro, porque não vai adiantar

pilha.Push(12);
foreach(int caixa in pilha)
{
    Console.WriteLine($"Quantidade de caixas na pilha: {caixa}");
}

-----------------------------------------------------------------------
FILA
Queue<int> fila = new Queue<int>();//Criando uma fila

//Adicionando uma fila
fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);

foreach(int percorre in fila)
{
  Console.WriteLine($"Valores na fila: {percorre}");
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()} da fila");

foreach(int percorre in fila)
{
  Console.WriteLine($"Valores na fila: {percorre}");
}

---------------------------------------------------------------------------------------------
  //new ExemplosExceptions().Metodo1();

 --------------------------------------------------------------------------------------------
 Exceptions
try{
                                   //caminho da leitura     
    string[] linhas = File.ReadAllLines("Arquivo/arquivo_Leitura.txt"); //comando para ele arquivos

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
 
 } catch (FileNotFoundException ex)
 {
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
 } 
 catch(DirectoryNotFoundException ex)
 {
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontado" + ex.Message);
 }
 catch(Exception ex)
 {
  Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");  
 }
 finally{
 Console.WriteLine("Chegou ate aqui");
 }
 
 


 ----------------------------------------------------------------------------------------------
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

 

 ---------------------------------------------------------------------------------------------------
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