## Desafio: Verificar se uma String é Subsequência de Outra

### Objetivo
Dado duas strings, `s` e `t`, determine se `s` é uma subsequência de `t`. Uma string é considerada subsequência de outra se for possível obter a primeira removendo alguns caracteres (podendo ser nenhum) da segunda, sem alterar a ordem dos caracteres restantes.

### Descrição
Uma subsequência é formada ao se retirar zero ou mais caracteres de uma string, mantendo a ordem dos demais caracteres. Por exemplo, a string "ace" é uma subsequência de "abcde" porque é possível formar "ace" removendo os caracteres "b" e "d" de "abcde" sem alterar a ordem dos caracteres restantes. Contudo, "aec" não é uma subsequência de "abcde" porque a ordem dos caracteres em "aec" não é a mesma que aparece em "abcde".

### Retorno
A função deve retornar verdadeiro (`true`) se `s` é uma subsequência de `t`, e falso (`false`) caso contrário.

### Exemplos de Uso

1. **Entrada:** `s = "abc"`, `t = "ahbgdc"`
   **Saída:** `true`
   **Explicação:** É possível obter "abc" de "ahbgdc" removendo os caracteres "h", "b", "g", "d", mantendo "a", "b", "c" em sua ordem original.

2. **Entrada:** `s = "axc"`, `t = "ahbgdc"`
   **Saída:** `false`
   **Explicação:** Não é possível formar "axc" sem alterar a ordem original dos caracteres em "ahbgdc", pois "x" não aparece depois de "a" e antes de "c".

### Como Implementar
Você pode verificar se `s` é uma subsequência de `t` usando um algoritmo eficiente que percorre as duas strings sequencialmente. Mantenha um índice para cada string, aumentando o índice de `t` sempre e o de `s` apenas quando encontrar um caractere em `t` que corresponda ao caractere atual em `s`. Se ao final do processo todos os caracteres de `s` foram encontrados em `t` na ordem correta, então `s` é uma subsequência de `t`.

```csharp
string s1 = "adge";
string s2 = "abcdefgh";

int i = 0;
int t = 0;
int c = 0;

while (i < s1.Length && t < s2.Length)
{
    if (s1[i] == s2[t])
    {
        i++;
        c++;
    }
    t++;
}

Console.WriteLine(c == s1.Length);
