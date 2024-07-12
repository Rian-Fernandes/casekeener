
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <h1>Case Keener</h1>
    <p>O presente projeto tem como objetivo construir um sistema de gerenciamento de estoque com a implementação de um sistema de cadastro.</p>
    <h2>Requisitos Atendidos</h2>
    <ul>
        <li>Página de login;</li>
        <li>Página de cadastro;</li>
        <li>Página de cadastro de produtos;</li>
        <li>Página de listagem de produtos;</li>
    </ul>
    <h2>Tecnologias Utilizadas</h2>
    <ul>
    <li><img src="https://www.dialhost.com.br/ajuda/wp-content/uploads/2018/07/aspnet-featured.png" width="100" height="100">
        <p>ASP.nets</p>
    </li>
    <li><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/1200px-Logo_C_sharp.svg.png" alt="Icone do c#" width="100" height="100">
        <p>C#</p>
    </li>
    <li><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/SQLite370.svg/1280px-SQLite370.svg.png" alt="Icone do sqlite" width="100" height="100">
        <p>SQLite</p>
    </li>
    <li><img src="https://user-images.githubusercontent.com/74038190/238200426-29fd6286-4e7b-4d6c-818f-c4765d5e39a9.gif" alt="Icone do html" width="100" height="100">
        <p>HTML</p>
    </li>  
     <li><img src="https://media3.giphy.com/media/fsEaZldNC8A1PJ3mwp/giphy.gif?cid=6c09b952vt4crkcv376f1h9mgayr17bkynuvn3rkciu0nn70&ep=v1_internal_gif_by_id&rid=giphy.gif&ct=s" alt="Icone do Css" width="100" height="100">
        <p>CSS</p>
    </li>  
</ul>
    <h2>Instalação e Execução</h2>
    <ol>
        <li>Clone o repositório para o seu ambiente local.</li>
        <pre><code>https://github.com/Rian-Fernandes/casekeener.git</code></pre>
        <li>Navegue até o diretório do projeto.</li>
        <pre><code>cd seu-projeto</code></pre>
        <li>Instale as dependências do projeto.</li>
        <pre><code>dotnet restore</code></pre>
        <li>Inicie a aplicação.</li>
        <pre><code>dotnet run</code></pre>
    </ol>
    <p>Agora, sua aplicação estará disponível em <a href="http://localhost:5000">http://localhost:5000</a>.</p>
    <h2>Utilizando a aplicação no navegador</h2>
      <ol>
        <li>Abra seu navegador e vá para <code>http://localhost:5000/Conta/Cadastro</code>.</li>
          <img src="/assetsrdme/cadastrocase.png" alt="" width="300">
        <li>Faça seu cadastro, e após isso, entre com as credenciais na página de login.</li>
          <img src="/assetsrdme/logincase.png" alt="" width="300">
        <li>Após o login, você terá acesso às funcionalidades de cadastro, listagem e controle de produtos e categorias.</li>
          <img src="/assetsrdme/cadastroprodutocase.png" alt="" width="300">
          <img src="/assetsrdme/listagemprodutoscase.png" alt="" width="300">
          <img src="/assetsrdme/cadastrocategoria.png" alt="" width="300">
          <img src="/assetsrdme/listagemcategoriascase.png" alt="" width="300">
    </ol>
   <ol> 
       <h2>Observações</h2>
<p>Foi necessário fazer o uso de alguns recursos pra a conclusão do case:</p>
<ul>
    <li>O uso de uma versão mais antiga do SDK, visto que em versões mais recentes o meu arquivo Startup.cs não era gerado;</li>
    <li>A utilização do SQLite como banco de dados, pelo fato do computador não conseguir suportar abrir o banco de dados padrão como postgres ou mysql;</li>
    <li>Obrigado pela oportunidade!</li>
</ul>
</body>
</html>
