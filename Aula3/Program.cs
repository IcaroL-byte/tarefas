/*Console.WriteLine("Digite sua nota1: ");
int nota1 = int.Parse(Console.ReadLine());

if (nota1 > 100 || nota1 < 0 ) {
    Console.WriteLine("Ocorreu um erro no programa");
    return;
}

Console.WriteLine("Digite sua nota2: ");
int nota2 = int.Parse(Console.ReadLine());

if (nota2 > 100 || nota2 < 0){
    Console.WriteLine("Ocorreu um erro no programa");
    return;
}

Console.WriteLine("Digite sua nota3: ");
int nota3 = int.Parse(Console.ReadLine());

if (nota3 > 100 || nota3 < 0){
    Console.WriteLine("Ocorreu um erro no programa");
    return;
}

Console.WriteLine("Digite sua nota4: ");
int nota4 = int.Parse(Console.ReadLine());

if (nota4 > 100 || nota4 < 0){
    Console.WriteLine("Ocorreu um erro no programa");
    return;
}

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
media = (float)Math.Round(media);
Console.WriteLine("média da diciplina: " + media);

if (media >= 60){
    Console.WriteLine("Aprovado");
    return;
}

else if(media < 20){
    Console.WriteLine("Reprovado");
    return;
}

else{
    Console.WriteLine("Recuperação");
    float previsão = 120 - media;
    Console.WriteLine($"É preciso tirar {previsão} para ser aprovado");
}

Console.WriteLine("Digite o valor da prova final: ");
int NotaFinal = int.Parse(Console.ReadLine());

if (NotaFinal > 100 || NotaFinal < 0){
    Console.WriteLine("Ocorreu um erro no programa");
    return;
}

float mediaFinal = (media + NotaFinal) / 2f;
mediaFinal = (float)Math.Round(mediaFinal);
Console.WriteLine("Média final: " + mediaFinal);

if (mediaFinal >= 60){
    Console.WriteLine("Aprovado");
}

else{
    Console.WriteLine("Reprovado");
}
*/


void Escreva(string msg)
{
    Console.WriteLine(msg);
}

Escreva("Olá, mundo");
Escreva("Acho que entendi");
Escreva("Posso escrever qualquer string");

String minhaMensagem = "Até mesmo Variaveis";
Escreva(minhaMensagem);

void MostrarIdade(string nome, int idade)
{
    Escreva($"{nome} tem {idade} anos");
}

MostrarIdade("Fulano", 16);
MostrarIdade("Sicrano", 14);

void CalcularIdade(string nome, int ano){
    int idade = 2024 - ano;
    MostrarIdade(nome, idade);
}

CalcularIdade("Pedro", 2007);

int MaiorEntre(int a, int b){

    if(a >= b){
        return a;
    }

    else{
        return b;
    }


}

int maior = MaiorEntre(230, 298);
Console.WriteLine(maior);