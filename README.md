# MV.Extensions.TextBox

Uma biblioteca de extensões em C# leve e eficiente para manipulação de strings e valores numéricos, ideal para sanitização de inputs em `TextBox` ou tratamento de dados em aplicações .NET.

## 🚀 Funcionalidades

A classe `TextBoxExtension` oferece diversos métodos estáticos para transformar e limpar dados:

* **Tratamento de Texto:** Conversão para maiúsculas/minúsculas e remoção de acentos de forma performática.
* **Sanitização Numérica:** Extração apenas de dígitos (inteiros) ou formatação de decimais permitindo apenas um separador.
* **Regras de Negócio:** Garantia de valores positivos e arredondamentos matemáticos precisos (`Ceiling` e `Floor`).

---

## 🛠️ Como Usar

Abaixo estão exemplos de como utilizar os principais métodos disponíveis na biblioteca:

### Manipulação de Texto

```csharp
using MV.Extensions;

string nome = "João Conceição";
string semAcento = TextBoxExtension.RemoverAcentos(nome); // "Joao Conceicao"
string tudoMaiusculo = TextBoxExtension.SomenteCaixaAlta(nome); // "JOÃO CONCEIÇÃO"

```

### Limpeza de Strings Numéricas

```csharp
// Extrai apenas os números de uma string (útil para CPF/CNPJ)
string documento = "123.456.789-00";
string apenasNumeros = TextBoxExtension.SomenteInteiros(documento); // "12345678900"

// Permite decimais mantendo apenas a primeira vírgula ou ponto
string precoIncorreto = "1.250,50,99";
string precoLimpo = TextBoxExtension.SomenteDecimais(precoIncorreto); // "1.250,50"

```

### Operações Matemáticas

```csharp
decimal valor = 15.45m;

decimal praCima = TextBoxExtension.ArredondaPraCima(valor); // 16
decimal praBaixo = TextBoxExtension.ArredondaPraBaixo(valor); // 15
int positivo = TextBoxExtension.SomentePositivos(-5); // 0

```

---

## 📋 Métodos Disponíveis

| Método | Descrição |
| --- | --- |
| `SomenteCaixaAlta` | Converte o texto para `UPPERCASE`. |
| `SomenteCaixaBaixa` | Converte o texto para `lowercase`. |
| `SomenteInteiros` | Remove qualquer caractere que não seja um dígito. |
| `SomenteDecimais` | Mantém dígitos e o primeiro separador decimal (`.` ou `,`) encontrado. |
| `RemoverAcentos` | Normaliza a string e remove diacríticos (acentuação). |
| `SomentePositivos` | Retorna o número ou 0 caso o valor seja negativo. |
| `ArredondaPraCima` | Utiliza `Math.Ceiling` para arredondar ao próximo inteiro. |
| `ArredondaPraBaixo` | Utiliza `Math.Floor` para truncar para o inteiro anterior. |

---

## 💻 Tecnologias

* C#
* .NET Standard / .NET 6+
* System.Text.RegularExpressions

---

## 📄 Licença

Este projeto está sob a licença MIT. Consulte o arquivo [LICENSE]([License](https://github.com/xX-Mill3r-Xx/MV.Extensions)) para mais detalhes.
