# PayPro System 

## Descrição

Este projeto consiste em uma aplicação Windows Forms que interage com uma API RESTful para realizar operações relacionadas a funcionários, holerites, salários, etc.

## Funcionalidades

- CRUD funcionários,Usuarios,Cargos e Licenças
- Gerar holerites e ajustar salários
- Gerenciar Informações
- Relatorios Gerais 
- Integração com a API RESTful para operações diversas

## Pré-requisitos

- PostgreSQL
- .NET Framework (ou .NET Core, se aplicável)
- Java Development Kit (JDK)
- IDE (Ambiente de Desenvolvimento Integrado)
- Apache Maven

## Instalação - PayPro

1. Clone o repositório: `git clone https://github.com/seu-usuario/seu-projeto.git`
2. Abra a solução no Visual Studio ou na sua IDE preferida

## Configurações do Projeto - API RESTfull

- Verifique se as configurações do seu projeto estão corretas, especialmente no arquivo `application.properties` ou `application.yml` que contém informações sobre o banco de dados.

### 6. Dependências do Spring Boot:

- Garanta que as dependências necessárias do Spring Boot estejam no arquivo `pom.xml`.

### 7. Driver JDBC para PostgreSQL:

- Certifique-se de ter o driver JDBC adequado para o PostgreSQL em suas dependências do Maven.

### 8. Network Connection:

- Tenha uma conexão de rede para baixar as dependências do Maven.

### 9. Porta Disponível:

- Verifique se a porta 8083 (ou a configurada) está disponível para sua aplicação.

### 10. Inicie o PostgreSQL:

- Inicie o serviço do PostgreSQL antes de iniciar sua aplicação Spring Boot.

### 11. Execute a Aplicação:

- Abra um terminal na pasta do seu projeto e execute `mvn spring-boot:run` para iniciar a aplicação.

Certifique-se de verificar os logs da aplicação para obter informações detalhadas sobre qualquer erro que possa ocorrer durante o processo de inicialização. Se encontrar algum problema específico, poste os logs para obter assistência.
