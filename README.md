
# FireCare

FireCare é um sistema de gestão para quartéis de bombeiros, desenvolvido em C# com Windows Forms, focado na organização e eficiência das operações de socorro. O sistema oferece um conjunto de funcionalidades que auxiliam na gestão de ocorrências, profissionais, equipamentos e recursos, promovendo um ambiente centralizado para a administração dos serviços de emergência.

## Objetivo do Projeto

O principal objetivo do FireCare é fornecer uma solução tecnológica que permita melhorar a eficiência e a organização dos recursos e das equipas dos bombeiros. Com o FireCare, as corporações de bombeiros podem gerir de forma centralizada as ocorrências de emergência, a disponibilidade de profissionais, o inventário de equipamentos e as operações de socorro, contribuindo para uma resposta mais rápida e eficaz em situações de crise.

## Funcionalidades Principais

- **Gestão de Ocorrências**: Registo e monitorização de ocorrências de emergência, como incêndios, resgates, acidentes e outras situações críticas, com informações detalhadas, incluindo localização e gravidade.
- **Gestão de Profissionais**: Controlo dos profissionais envolvidos, como bombeiros, médicos e enfermeiros, permitindo a consulta e edição de informações pessoais, cargos, disponibilidade, e dados de contacto.
- **Administração de Equipamentos**: Controlo de equipamentos e recursos essenciais, como veículos de emergência, desfibriladores e outros itens importantes para as operações, com o estado de disponibilidade.
- **Interface Intuitiva**: Painel centralizado com funcionalidades para adicionar, editar e eliminar registos de profissionais, equipamentos e ocorrências.
- **Base de Dados Local**: Utilização de SQLite para o armazenamento seguro e persistente das informações, garantindo o fácil acesso e consulta de dados.

## Arquitetura do Sistema

O sistema foi desenvolvido utilizando uma abordagem de Programação Orientada a Objetos (POO), o que permite uma organização modular e facilita a manutenção e a escalabilidade do código. As classes principais incluem:

- **Profissional**: Representa cada profissional com atributos como nome, cargo, disponibilidade, e informações de contacto.
- **Ocorrencia**: Gere as ocorrências registadas, com detalhes sobre tipo, localização e gravidade.
- **Equipamento**: Representa os equipamentos e recursos disponíveis, incluindo o estado de uso e a categoria.
- **Serviços**: Cada entidade possui um serviço dedicado para realizar operações CRUD (Create, Read, Update, Delete), garantindo uma camada de abstração entre a interface e a base de dados.

## Recursos Utilizados

- **Linguagem de Programação**: C#
- **Framework**: .NET Framework com Windows Forms
- **Base de Dados**: SQLite para armazenamento local dos dados
- **IDE**: Visual Studio
- **Controlo de Versão**: Git e GitHub para versionamento e colaboração

## Requisitos do Sistema

- .NET Framework 4.7.2 ou superior
- SQLite instalado e configurado no sistema
- Visual Studio 2019 ou superior para desenvolvimento

## Estrutura do Projeto

O FireCare está organizado da seguinte forma:

```
FireCare/
├── Models/                 # Classes de domínio, como Profissional, Ocorrencia e Equipamento
├── Services/               # Serviços para gestão de dados e operações CRUD
├── Views/                  # Interface gráfica (Windows Forms)
├── Database/               # Arquivos de configuração e conexão com a base de dados SQLite
└── FireCare.sln            # Solução principal do projeto
```

## Licença

Este projeto está sob a licença MIT - veja o arquivo LICENSE para mais detalhes.
# FireCare