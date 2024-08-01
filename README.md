<div align="center">
      <a href="https://dev.to/yagopeixinho/hello-world-mas-em-uma-web-api-com-net-8-1jp6-temp-slug-4672107?preview=3ae07a93613da5d714c9d72db668e34b0b94a669c130e8eb031de5e38e748d7e33a79771266fb7bca7ba2221ff0c653e792ff4fa43c2215645562425" target="_blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Microsoft_.NET_logo.svg/240px-Microsoft_.NET_logo.svg.png" align="center" width="120px"/></a>
</div>

<h4 align="center">Uma Introdução ao Essencial com Entity Framework e SQLite.</h4>

<p align="center">
  <a href="#introdução">Introdução</a> •
  <a href="#contato">Contato</a> •
  <a href="#licença">Licença</a>
</p>

<div align="center">
  <a href="https://dev.to/yagopeixinho/hello-world-mas-em-uma-web-api-com-net-8-1jp6-temp-slug-4672107?preview=3ae07a93613da5d714c9d72db668e34b0b94a669c130e8eb031de5e38e748d7e33a79771266fb7bca7ba2221ff0c653e792ff4fa43c2215645562425" target="_blank"><img src="https://media.dev.to/cdn-cgi/image/width=1000,height=420,fit=cover,gravity=auto,format=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Fufh5p50tk0eqi5y4rv4n.png"></a>
</div>

<br>

## Introdução
> Desenvolva a API DessaVezEuNaoEsqueco. No meio desse desenvolvimento, vamos mergulhar nos conceitos do .NET e API.

Fundamentos Essenciais para Web APIs com .NET: Uma Introdução à Propedêutica (corpo de ensinamentos introdutórios ou básicos de uma disciplina; ciência preliminar, introdução.) com Entity Framework e SQLite. Entenda os conceitos por trás de uma **Web API** utilizando o .NET 8.0 e o **Entity Framework Core**.

Esse artigo é destinado para todos os níveis de programadores, desde os menos experientes até os mais avançados. Nosso objetivo é compreender o que acontece por trás dos panos e nutrir alguns conhecimentos acerca de uma **API** (Application Programming Interface) e seus comportamentos.

**Sumário:**
- Compreendendo .NET & C#
- Entendendo o que é uma API
  - Protocolo HTTP
  - JSON 
  - HTTP Código de Resposta (Status Code)
- Criação do projeto [DessaVezEuNaoEsquecoAPI](https://github.com/yagopeixinho/DessaVezEuNaoEsquecoAPI)
  - Sobre o Projeto
  - Instalação
     - Ubuntu
     - Windows
  - Estrutura Inicial de uma aplicação .NET 8
     - _Program.cs_
     - _appsettings.json_
     - _Dependencies_
  - Entendendo as Entidades (Models)
     - Características de Entidades em .NET
     - Criando Nossa Primeira Entidade
  - Entendendo e o que é uma ORM & Entity Framework Core
     - Data Annotations na nossa Entidade com o Entity Framework
     - Instalando o Entity Framework
        - Compreendendo o que é NuGet
        - Instalando o Pacote Nuget do Entity Framework
        - Configurando o Entity Framework em nosso ambiente
        - Configurar o Contexto do Banco de Dados no arquivo `Program.cs`
        - Migração de Banco de Dados
        - Migração com o Entity Framework
  - Controllers
     - Criando nossos Controllers
     - Configurando Swagger para realizarmos solicitações HTTP
     - Criando arquivo `AtividadesController.cs`
     - Definindo o Método **GET**
     - Definindo o Método **POST**
     - Definindo o Método **GET Individual**
     - Definindo o Método **DELETE**
- Conclusão & Resumo


Para continuar lendo esse artigo. [Clique aqui](https://dev.to/yagopeixinho/hello-world-mas-em-uma-web-api-com-net-8-1jp6-temp-slug-4672107?preview=3ae07a93613da5d714c9d72db668e34b0b94a669c130e8eb031de5e38e748d7e33a79771266fb7bca7ba2221ff0c653e792ff4fa43c2215645562425).

## Contato
- 📬 Me envie um e-mail: peixinhoyago@gmail.com
- Se você tem alguma dúvida ou quer entrar em contato comigo por qualquer outro motivo, você pode encontrar minhas redes sociais e mais informação sobre mim [clicando aqui](https://bento.me/yagopeixinho).
  
## Licença
A licença desse repositório e artigo pode ser encontrada nos links disponibilizados do **README**.
