# Rates Calculator System

Este projeto em C# .NET foi criado para estudar a implementação de classes e métodos abstratos, além de trabalhar com generics.

## 💻 Descrição

O sistema calcula os impostos de diferentes tipos de contribuintes (pessoas físicas e jurídicas) com base na renda anual e outros critérios específicos. A aplicação utiliza conceitos de herança, classes abstratas e polimorfismo para fornecer uma estrutura flexível e extensível.

## 🔮 Funcionalidades

- **Cálculo de Impostos**:
  - Para **pessoas físicas**: Considera a renda anual e despesas médicas.
  - Para **pessoas jurídicas**: Considera a renda anual e o número de empregados.
- **Polimorfismo**: Através de classes e métodos abstratos, diferentes tipos de contribuintes implementam sua própria lógica de cálculo de impostos.
- **Generics**: Uso de listas com tipos genéricos para armazenar e manipular diferentes tipos de contribuintes.

## 📁 Estrutura do Código

- **Classe Abstrata `Taxpayer`**: Define a estrutura básica de um contribuinte, com propriedades para nome e renda anual, além de um método abstrato `GetTotalRate()` para calcular o imposto que nas sub-classes serão 'sobrepostas'.
- **Classe `NaturalPerson`**: Herda de `Taxpayer` e implementa o cálculo de imposto específico para pessoas físicas, levando em conta a renda anual e despesas médicas.
- **Classe `LegalEntity`**: Herda de `Taxpayer` e implementa o cálculo de imposto para pessoas jurídicas, considerando a renda anual e o número de empregados.

## 🎈 Exemplo de Uso

Ao executar a aplicação, o usuário informa a quantidade de contribuintes, o tipo de contribuinte (pessoa física ou jurídica), e os dados necessários para o cálculo de impostos. O sistema então calcula e exibe o imposto a ser pago por cada contribuinte e o total de impostos coletados.

## ✨ Exemplo de Uso

- **C#**
- **.NET 8.0**

---

<h3 align="center">
    Feito com ☕ por <a href="https://github.com/Brendon3578"> Brendon Gomes</a>
</h3>
