# Verificação de Subsequência em Strings

## Objetivo
Determinar se uma string `s` é uma subsequência de outra string `t`.

## Definição de Subsequência
Uma **subsequência** é uma nova string criada a partir da original pela remoção de alguns caracteres (podendo ser nenhum), sem mudar a ordem relativa dos caracteres restantes.

- **Exemplo:** "ace" é uma subsequência de "abcde"
- **Contraexemplo:** "aec" não é uma subsequência de "abcde"

## Função de Verificação
A função deve retornar `true` se `s` for uma subsequência de `t`, e `false` caso contrário.

## Exemplos

1. **Entrada:** `s = "abc"`, `t = "ahbgdc"`
   **Resultado:** `true`
   - "abc" é formado por "a", "b" e "c" na mesma ordem em "ahbgdc".

2. **Entrada:** `s = "axc"`, `t = "ahbgdc"`
   **Resultado:** `false`
   - Não é possível formar "axc" mantendo a ordem original dos caracteres em "ahbgdc".

## Código de Solução

```csharp
string s1 = "adge";
string s2 = "abcdefgh";

int i = 0; // Índice para s1
int t = 0; // Índice para s2
int c = 0; // Contador de caracteres coincidentes

while (i < s1.Length && t < s2.Length)
{
    if (s1[i] == s2[t])
    {
        i++; // Avança em s1 se um caractere correspondente for encontrado
        c++; // Incrementa o contador de coincidências
    }
    t++; // Sempre avança em s2
}

Console.WriteLine(c == s1.Length); // Verifica se todos caracteres de s1 foram encontrados
