Console.WriteLine("Quer jogar um jogo? s/n");


bool Resposta()
{
    iniciapergunta:
    string resposta = Console.ReadLine();

    if (resposta == "s"){
        return true;
    }

    else if (resposta == "n"){
        return false;
    }

    else{
        Console.WriteLine("Deu ruim tente de novo");
        goto iniciapergunta;
    }

}

if (Resposta() == false){
    goto finaldejogo;
}

iniciodejogo:

int menor = 0;
int maior = 100;
int numDeTentativas = 10;
bool JogoRodando = true;

Random rand = new Random();
int sorteado = rand.Next(menor, maior + 1);
Console.WriteLine($"pensei em um numero maior que {menor} e menor que {maior}. tente advinhar");

while(JogoRodando){
    Console.Write($"Voce tem {numDeTentativas} tentativas: ");
    int numDigitado = int.Parse(Console.ReadLine());

    if(numDigitado < sorteado){
        Console.WriteLine("muito baixo, tente de novo");
        numDeTentativas--;
    }
    else if(numDigitado > sorteado){
        Console.WriteLine("muito alto, tente de novo");
        numDeTentativas--;
    }
    else{
        Console.WriteLine("Acertou!!!");
        JogoRodando = false;
    }

    if(numDeTentativas == 0){
        Console.WriteLine("Voce perdeu, o numero era " + sorteado);
        JogoRodando = false;
    }
}

Console.WriteLine("Quer jogar de novo?");
if (Resposta() == true){
    goto iniciodejogo;
}

finaldejogo:

Console.WriteLine("Fechando o jogo...");