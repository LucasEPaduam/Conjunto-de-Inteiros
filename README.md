
# Exercício Conjunto de Inteiros

Crie uma classe em C# chamada ConjuntoDeInteiros.

Cada objeto ConjuntoDeInteiros pode armazenar inteiros no intervalo de 0 a N,
sendo os números representados por uma coleção de booleans: o elemento da
coleção na posição i é true se o inteiro i estiver no conjunto. O elemento da
coleção na posição i é false se o inteiro não estiver no conjunto.

Exemplos, com N = 10 :
{1,3,5,7,9} → {FALSE, TRUE, FALSE, TRUE, FALSE, TRUE, FALSE, TRUE, FALSE,
TRUE, FALSE}
{0,1,9,10} → {TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE,
TRUE, TRUE}

O construtor sem argumento inicializa a coleção como 'conjunto vazio' (todos
os valores false). Assuma que N é o mesmo para todos os conjuntos
representados.
Escolha qualquer coleção para representar seus conjuntos.

A classe deve fornecer os seguintes métodos:

 - `Método uniao retorna um terceiro conjunto que é a união teórica de
dois conjuntos existentes (isto é, aplicação da função lógica OU sobre os
conjuntos e retorna o valor lógico true ou false).`

 - `Método intersecao retorna um terceiro conjunto que é a interseção
teórica de dois conjuntos existentes (isto é, aplicação da função lógica
AND sobre os conjuntos e retorna o valor lógico true ou false).`

 - `Método insereElemento insere um novo elemento inteiro k em um
conjunto (atribuindo true para a[k]) e o retorna.`

- `Método deletaElemento exclui o inteiro m (a[m] recebe false) e retorna
o novo conjunto.`

- `Método toSetString retorna uma string contendo um conjunto expresso
como uma lista de números separados por espaço. Inclua somente os
elementos que estão presentes no conjunto. Utilize “-“ para representar
um conjunto vazio.`

- `Método eIgualA determina se dois conjuntos são iguais.`

