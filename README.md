# Tutoriais para introdução a programação com C#

Os projetos estão separados por tópico, tendo cada um sua pasta, foi feito assim para não confundir o aluno com varios assuntos ao mesmo tempo e termos como referência um projeto anterior e o posterior, vendo assim, a evolução no processo.

# Comandos utilizados

- mkdir = Cria uma pasta (Ex.: mkdir nome_pasta)
- cd = Acessa alguma pasta (Ex.: cd nome_pasta, cd ..). <br> Vale lembrar que o "cd .." volta para a pasta anterior.
- clear = limpa o texto do terminal / cls (também possível para pessoas que usam o linux)

- dotnet new (cria um novo projeto em dotnet, porém é necessário especificar qual tipo você quer)
- dotnet new --help (ajuda para utilizar o comando dotnet new)

# Tipos primitivos:
- string = representa um texto
- short (Int16), int (Int32), long (Int64) = representa um número INTEIRO
- ushort (UInt16), uint (UInt32), ulong (UInt64) = representa um número INTEIRO, positivo
- float (7 digitos), double (15 a 16 digitos) e decimal (28 a 29) = representa um número INTEIRO/Decimal
- bool = representa true or false
- char = representa um pedaço de uma string
- byte = representa um byte

# Tipos complexos:
- classes = representa uma definição de um tipo de refência, podendo conter propriedades e métodos

# Tipos de visibilidade:
- public = todos podem acessar
- internal = apenas o projeto pode acessar
- protected = apenas o projeto e as classes que herdaram da classe podem acessar
- private = apenas a classe pode acessar

# Operadores matemáticos:
- + = para somar um número
- - = para subtrair um número
- * = para multiplicar um número
- / = para dividr um número

Também é possível usarmos a biblioteca Math para realizar operações matemáticas, como o caso do Math.Pow, utilizado para operações de exponênciação.

No exemplo abaixo, a variável número recebe o valor 0 e depois soma o valor que ela tem + 10;
int numero = 0;
numero += 10; // numero = numero + 10;

# Operadores lógicos

Os operadores lógicos sempre irão retornar TRUE ou FALSE após sua execução, dentre os principais operadores lógicos podemos citar

- > Maior que
- < Menor que
- >= Maior OU igual que
- <= Menor OU igual que
- == Igual a
- != Diferente de
- && Operador lógico E (ambos os lados devem ser verdadeiros para retornar verdadeiro)
- || Operador lógico OU (ambos os lados devem ser falsos para retornar falso)