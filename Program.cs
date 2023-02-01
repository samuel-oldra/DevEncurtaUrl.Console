// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Digite um nome.");

// string? nameInput = Console.ReadLine();

// Console.WriteLine("Olá, " + nameInput);

// string name = "LuisDev";
// int numberInt = 1;
// float numberFloat = 4.64f;
// double numberDouble = 3.5;
// decimal numberDecimal = 5.3m;
// char isActive = 'y';
// bool isActiveBool = false;

// // Estruturas de controle de fluxo
// Console.WriteLine("Digite a pontuação de um aluno A (0-1000):");
// var studentAScore = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite a pontuação de um aluno B (0-1000):");
// var studentBScore = int.Parse(Console.ReadLine());

// var scoreDifference = studentAScore - studentBScore;

// Console.WriteLine("Utilizando if-else");

// if (scoreDifference > 0) {
//     Console.WriteLine("Aluno A tem maior nota.");
// } else if (scoreDifference == 0) {
//     Console.WriteLine("Empate.");
// } else {
//     Console.WriteLine("Aluno B tem maior nota.");
// }

// Console.WriteLine("Utilizando switch-case");

// switch (scoreDifference) {
//     case > 0:
//         Console.WriteLine("Aluno A tem maior nota.");
//         break;
//     case 0:
//         Console.WriteLine("Empate.");
//         break;
//     default:
//         Console.WriteLine("Aluno B tem maior nota.");
//         break;
// }

// string[] studentResults = new string[3] { "Aluno A - 1000", "Aluno B - 450", "Aluno C - 750" };

// Console.WriteLine("Utilizando for");

// for (var i = 0; i < studentResults.Length; i++) {
//     Console.WriteLine(studentResults[i]);
// }

// Console.WriteLine("Utilizando while.");

// var count = 0;

// while (count < studentResults.Length) {
//     Console.WriteLine(studentResults[count]);
//     count++;
// }

// count = 0;

// Console.WriteLine("Utilizando do-while.");
// do {
//     Console.WriteLine(studentResults[count]);
//     count++;
// } while (count < studentResults.Length);


// Console.WriteLine("Utilizando o foreach.");

// foreach (var result in studentResults) {
//     Console.WriteLine(result);
// }

// int[] scores = new int[5] { 7, 5, 2, 1, 2 };
// var scoresList = new List<int> { 7, 5, 2, 1, 2 };
// var scoresArrayAsList = scores.ToList();
// var scoresListAsArray = scoresList.ToArray();

// var single = scores.Single(s => s == 5);
// var first = scores.First(s => s == 2);
// var where = scores.Where(s => s >= 6);
// var any = scores.Any(s => s == 0);
// var min = scores.Min();
// var max= scores.Max();
// var average = scores.Average();
// var scoresSize = scores.Length;

// Console.WriteLine(min);
// Console.WriteLine(max);
// Console.WriteLine(scoresSize);
// Console.WriteLine(average);


// string phrase = "ASP.NET Core é um framework web com versão atual .NET 7";

// Console.WriteLine($"Letras maiúsculas: {phrase.ToUpper()}");
// Console.WriteLine($"Letras minúsculas: {phrase.ToLower()}");

// var substring = phrase.Substring(3);
// var contains = phrase.Contains("ASP.NET Core");
// var startsWith = phrase.StartsWith("ASP");
// var endsWith = phrase.EndsWith(".NET 7");
// var indexOf = phrase.IndexOf(".NET");
// var lastIndexOf = phrase.LastIndexOf(".NET");

// Console.WriteLine($"Frase a partir do quarto caractere: {substring}");
// Console.WriteLine($"Frase contém ASP.NET Core? {contains}");
// Console.WriteLine($"Frase começa com ASP: {startsWith}");
// Console.WriteLine($"Frase termina com .NET 7: {endsWith}");
// Console.WriteLine($"Índice do primeiro .NET: {indexOf}");
// Console.WriteLine($"Índice do último .NET: {lastIndexOf}");

List<RedirectionLink> links = new List<RedirectionLink> {
    new RedirectionLink(1, "Artigo Mais Recente", "meu.link.encurtado/1234", "luisdev.com.br/2023-1-1/meu-artigo-mais-recente"),
    new CustomizedRedirectionLink(1, "Artigo Mais Recente", "meu.link.encurtado/1234", "luisdev.com.br/2023-1-1/meu-artigo-mais-recente", "subdominio.dominio.com.br/1234"),
};

foreach (var link in links) {
    link.DisplayInfo();
}

public class RedirectionLink {
    public RedirectionLink(int id, string title, string shortenedLink, string destinationLink)
    {
        Id = id;
        Title = title;
        ShortenedLink = shortenedLink;
        DestinationLink = destinationLink;

        CreatedAt = DateTime.Now.ToShortDateString();
    }

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string ShortenedLink { get; private set; }
    public string DestinationLink { get; private set; }
    public string CreatedAt { get; private set; }  

    public virtual void DisplayInfo() {
        Console.WriteLine($"Title: {Title}, Shortened Link: {ShortenedLink}, DestinationLink: {DestinationLink}");
    }
}

public class CustomizedRedirectionLink : RedirectionLink
{
    public CustomizedRedirectionLink(int id, string title, string shortenedLink, string destinationLink, string customRedirectionLink)
        : base(id, title, shortenedLink, destinationLink)
    {
        CustomRedirectionLink = customRedirectionLink;
    }

    public string CustomRedirectionLink { get; private set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Shortened Link: {ShortenedLink}, DestinationLink: {DestinationLink}, CustomLink: {CustomRedirectionLink}");
    }
}