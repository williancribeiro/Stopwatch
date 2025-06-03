![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

# Cronômetro Console

Um aplicativo de cronômetro simples e interativo desenvolvido em C# para terminal/console.

## 📋 Descrição

Este projeto implementa um cronômetro básico que permite ao usuário contar tempo em segundos ou minutos através de uma interface de linha de comando intuitiva. O cronômetro exibe uma contagem crescente em tempo real até atingir o tempo especificado.

## 🚀 Funcionalidades

- ⏱️ Contagem de tempo em segundos ou minutos
- 🎯 Interface interativa no console
- 🔢 Exibição em tempo real da contagem
- 🔄 Retorno automático ao menu principal
- 🎬 Animação de início ("Preparar.. Apontar.. Fogo!!")

## 🛠️ Tecnologias Utilizadas

- **C#** (.NET)
- **System.Threading** para controle de tempo
- **Console Application**

## 📦 Como Executar

### Pré-requisitos

- .NET SDK instalado
- Terminal/Prompt de comando

### Passos para execução

1. Clone o repositório:
```bash
git clone [URL_DO_REPOSITORIO]
cd stopwatch
```

2. Compile e execute o projeto:
```bash
dotnet run
```

## 🎮 Como Usar

1. Execute o programa
2. No menu principal, digite o tempo desejado seguido da unidade:
   - `10s` para 10 segundos
   - `5m` para 5 minutos
   - `0` para sair do programa

3. Aguarde a animação de início
4. Observe a contagem em tempo real
5. O programa retornará ao menu automaticamente após a conclusão

### Exemplo de uso:
```
S = Segundos
M = Minutos
0 = Sair
Quanto tempo deseja contar?
> 30s
```

## 📁 Estrutura do Projeto

```
Stopwatch/
│
├── Program.cs          # Arquivo principal com toda a lógica
└── README.md          # Este arquivo
```

## 🔧 Principais Métodos

- `Menu()`: Exibe o menu principal e captura entrada do usuário
- `PreStart()`: Executa a animação de preparação
- `Start()`: Executa o cronômetro principal com contagem
- `Main()`: Método de entrada da aplicação

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para:

1. Fazer fork do projeto
2. Criar uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abrir um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## ✨ Autor

Desenvolvido com ❤️ para aprendizado em C#

---

⭐ Se este projeto foi útil para você, considere dar uma estrela no repositório!
