<h1 align="center">📬 Buscar endereço pelo CEP</h1>

<div style="display: inline_block">
    <a href="https://github.com/DKAT-DAVI/gestao-de-pedidos-Csharp/blob/main/LICENSE">
        <img src="https://img.shields.io/badge/license-MIT-blue" alt="license">
    </a>
    <img src="https://img.shields.io/badge/STATUS-FINALIZADO-yellow" alt="status-projeto">
<div>

<br>
<div align="center">
    <img max-height="400em" src="assets/capa-projeto-cep.png" alt="diagrama-uml">
</div>


<h2>&#X1F4DD Descrição do projeto</h2>

<p>Neste projeto foi usado a API <a href="https://viacep.com.br/">Via CEP</a> para que quando o usuário digitasse o CEP, fosse buscado os dados daquela localidade e fizesse um auto-complete nos campos.<p>

O projeto tem duas versões.

<h2>1️⃣ Primeira versão</h2>

<p>Na primeira versão foi usado o pacote <a href="https://github.com/MosaicoSolutions/ViaCep">MosaicoSolutions.ViaCep<a> para facilitar o request de dados da API e o pacote <a href="https://www.newtonsoft.com/json">Newtonsoft.Json</a> para fazer a deserialização do json que é retornado pela API.<p>

<h2>2️⃣ Segunda versão</h2>

<p>Na segunda versão foi feito um request diretamente da API usando a classe <a href="https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-7.0">HttpClient</a> e o pacote <a href="https://www.newtonsoft.com/json">Newtonsoft.Json</a> para fazer a deserialização do json que é retornado pela API que foi convertido para um objeto do tipo <a href="https://github.com/DKAT-DAVI/find-adress-by-CEP/blob/main/Release2/find-adress-by-CEP/Adress.cs">Adress</a>.<p>

<h2>&#X1F528 Funcionalidades do projeto</h2>

<ul>
    <li>Tela principal com uma textbox para inserir o CEP, botão para acionar a busca e um botão para limpar os resultados obtidos.</li>
    <li>Ao inserir o CEP e clicar em BUSCAR, o programa vai preencher od campos com os dados buscados.</li>

</ul>

<div align="center">
    <img src="assets/gif-tela-projeto.gif">
</div>

<h2>&#X1F4C1 Acesso ao projeto</h2>

<p>As duas versões estão disponíveis neste repositório, faça download viz arquivo zip ou clone este repositório na sua máquina Windows e compile o código utilizando o <a href="https://visualstudio.microsoft.com/downloads/">Visual Studio</a>.<p>

<ul>
    <li>Download <a>PrimeiraVersão.zip</a></li>
    <li>Download <a>SegundaVersão.zip</a></li>
</ul>


<h2>&#X2714 Técnicas e Tecnologias utilizadas</h2>
<ul>
    <li>
        <img align="center" alt="DKAT-C#" height="30" width="40" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg"/>Linguagem C#
    </li>
    <li>    
        <img align="center" alt="DKAT-C#" height="30" width="40" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg"/>
        Visual Studio  
    </li>
    <li><bigger><b>POO</b></bigger> programação orientada a obejtos</li>
</ul>
<ul><b>Dependêcias</b>
    <li>API <a href="https://viacep.com.br/">Via CEP</a></li>
    <li>Pacote <a href="https://github.com/MosaicoSolutions/ViaCep">MosaicoSolutions.ViaCep<a></li>
    <li>Pacote <a href="https://www.newtonsoft.com/json">Newtonsoft.Json</a></li>
</ul>

<hr>

<div style="display: inline_block">
          
[![Linkedin: SEU NOME](https://img.shields.io/badge/-dkatdavi-blue?style=flat-square&logo=Linkedin&logoColor=white&link=(https://www.linkedin.com/in/dkat-davi/))](https://www.linkedin.com/in/dkat-davi/)
[![Gmail Badge](https://img.shields.io/badge/-dkatdavi@gmail.com-006bed?style=flat-square&logo=Gmail&logoColor=white&link=mailto:dkatdavi@gmail.com)](mailto:dkatdavi@gmail.com)
[![GitHub SEU NOME](https://img.shields.io/github/followers/dkat-davi?label=follow&style=social)](https://github.com/dkat-davi)
</div>
