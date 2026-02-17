# MV.Extensions

Biblioteca de **extensões utilitárias em C#** para tratamento de texto e sanitização de dados em aplicações .NET — especialmente útil para **inputs de TextBox** em formulários, processamento de strings e valores numéricos em geral. 

📦 **Licença:** MIT 
💻 **Construído com:** C# / .NET Standard (.NET 6+ compatível)

---

## 📌 O que é esta biblioteca?

`MV.Extensions` é uma **DLL leve de métodos estáticos** que facilitam:

✅ Transformações de texto (caixa alta/baixa, remoção de acentos)

✅ Sanitização de strings (somente números, decimais válidos)

✅ Ajustes de valores numéricos (valores positivos e arredondamentos)

A ideia é melhorar a **qualidade dos dados de entrada e saída** em formulários, processamento de dados e validação em APIs ou aplicações desktop/web.

---

## 🚀 Instalação

### Via Pacote DLL

1. Compile o projeto `MV.Extensions` em sua máquina.
2. Adicione a DLL resultante ao seu projeto .NET via *References*.

---

## 📦 Funcionalidades Principais

Todos os métodos estão contidos na classe estática `TextBoxExtension`.

| Método                             | Descrição                                                                     |
| ---------------------------------- | ----------------------------------------------------------------------------- |
| `SomenteCaixaAlta(string input)`   | Converte a string para **letras maiúsculas**.                                 |
| `SomenteCaixaBaixa(string input)`  | Converte a string para **letras minúsculas**.                                 |
| `RemoverAcentos(string input)`     | Remove **diacríticos/acentos** de texto para normalização.                    |
| `SomenteInteiros(string input)`    | Extrai **apenas dígitos inteiros**, removendo todos os outros caracteres.     |
| `SomenteDecimais(string input)`    | Mantém somente dígitos e o **primeiro separador decimal** (ponto ou vírgula). |
| `SomentePositivos(int value)`      | Garante que o número seja positivo (retorna zero se negativo).                |
| `ArredondaPraCima(decimal value)`  | Arredonda para cima (equivalente a `Math.Ceiling`).                           |
| `ArredondaPraBaixo(decimal value)` | Arredonda para baixo (equivalente a `Math.Floor`).                            |

> ⚠️ Esses métodos são utilitários estáticos — basta usar diretamente `TextBoxExtension.Metodo(...)`.

---

## 🧠 Exemplos de Uso

### ✔ Manipulação de Texto

```csharp
using MV.Extensions;

string nome = "João Conceição";

string semAcento = TextBoxExtension.RemoverAcentos(nome);
// semAcento == "Joao Conceicao"

string upper = TextBoxExtension.SomenteCaixaAlta(nome);
// upper == "JOÃO CONCEIÇÃO"
```

---

### ✔ Validação/Sanitização Numérica

```csharp
string documento = "123.456.789-00";
string apenasNumeros = TextBoxExtension.SomenteInteiros(documento);
// apenasNumeros == "12345678900"

string valor = "1.250,50,99";
string limpo = TextBoxExtension.SomenteDecimais(valor);
// limpo == "1.250,50"
```

---

### ✔ Ajustes Matemáticos

```csharp
decimal valor = 15.45m;

decimal cima = TextBoxExtension.ArredondaPraCima(valor);
// cima == 16

decimal baixo = TextBoxExtension.ArredondaPraBaixo(valor);
// baixo == 15

int positivo = TextBoxExtension.SomentePositivos(-5);
// positivo == 0
```

---

## 🛠️ Quando Usar

💡 **MV.Extensions** é ideal para:

* Tratamento de inputs de formulários antes de persistir no banco
* Normalização de campos de texto em aplicações desktop ou web
* Sanitização de valores monetários e numéricos
* Prevenção básica contra entradas malformadas

---

## 📁 Estrutura do Projeto

```
MV.Extensions/
├── ArquivoTextoExtension.cs
├── TextBoxExtension.cs
├── MV.Extensions.csproj
├── LICENSE
└── README.md
```

---

## 🤝 Contribuição

Contribuições são **bem-vindas**! Sinta-se à vontade para:

✔ Abrir *issues*
✔ Sugestões de melhorias
✔ *Pull requests*

---

## 📜 Licença

Este projeto está licenciado sob a **MIT License** — veja o arquivo `LICENSE` para detalhes.
