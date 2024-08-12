void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtração(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicação(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisão(float a, float b){
    if (b == 0){
        Console.WriteLine("Erro de divisão");
        return;
    }

    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}

//MENU
Console.WriteLine("--- Calculadora ---");
Console.WriteLine("1 - SOMA");
Console.WriteLine("2 - SUBTRAÇÃO");
Console.WriteLine("3 - MULTIPLICAÇÃO");
Console.WriteLine("4 - DIVISÃO");
Console.WriteLine("5 - SAIR");
Console.WriteLine("-------------------");
Console.WriteLine("Escolha uma opção desejada:");

int opção = int.Parse(Console.ReadLine());

float a;
float b;


void Digitar(){
    Console.WriteLine("Digite o valor de a");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de b");
    b = float.Parse(Console.ReadLine());
}



if(opção == 1){
    Digitar();
    Soma(a, b);
}

else if(opção == 2){
    Digitar();
    Subtração(a, b);
}

else if(opção == 3){
    Digitar();
    Multiplicação(a, b);
}

else if(opção == 4){
    Digitar();
    Divisão(a, b);
}

else if(opção == 5){
    Console.WriteLine("Saindo...");
}

else{
    Console.WriteLine("Opção invalida");
}