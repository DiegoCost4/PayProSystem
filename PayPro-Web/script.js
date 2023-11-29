

document.getElementById('loginForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Impede o envio padrão do formulário

    var selectedUserRole = document.getElementById('selectUserRole').value;

    // Redireciona com base na opção selecionada
    if (selectedUserRole === 'funcionario') {
        window.location.href = 'home_funcionario.html';
    } else if (selectedUserRole === 'administrador') {
        window.location.href = 'home_admin.html';
    }
});

function navigateToCadastro(option) {
    // Implemente a lógica para abrir o modal correspondente
    if (option === 'funcionario') {
        $('#cadastroFuncionarioModal').modal('show');
    } else if (option === 'usuario') {
        $('#cadastroUsuarioModal').modal('show');
    } else if (option === 'cargo') {
        $('#cadastroModal').modal('hide');
        $('#cadastroCargoModal').modal('show');
    } else if (option === 'licenca') {
        $('#cadastroLicencaModal').modal('show');
    }
}

// Adicione as funções para os botões de atualização, exclusão e pesquisa
function atualizarUsuario() {
    // Lógica para atualizar o usuário
    console.log('Atualizando usuário...');
    // Adicione a lógica necessária para preencher o formulário de atualização
    $('#atualizarUsuarioModal').modal('show');
}

function excluirUsuario() {
    // Lógica para excluir o usuário
    console.log('Excluindo usuário...');
    // Adicione a lógica necessária para preencher o formulário de exclusão
    $('#excluirUsuarioModal').modal('show');
}

function pesquisarUsuario() {
    // Lógica para pesquisar o usuário
    console.log('Pesquisando usuário...');
    // Adicione a lógica necessária para preencher o formulário de pesquisa
    $('#pesquisarUsuarioModal').modal('show');
}
function atualizarCargo() {
    // Lógica para atualizar o cargo
    console.log('Atualizando cargo...');
    // Adicione a lógica necessária para preencher o formulário de atualização
}

function excluirCargo() {
    // Lógica para excluir o cargo
    console.log('Excluindo cargo...');
    // Adicione a lógica necessária para preencher o formulário de exclusão
}

function pesquisarCargo() {
    // Lógica para pesquisar o cargo
    console.log('Pesquisando cargo...');
    // Adicione a lógica necessária para preencher o formulário de pesquisa
}
function atualizarLicenca() {
    // Lógica para atualizar a licença
    console.log('Atualizando licença...');
    // Adicione a lógica necessária para preencher o formulário de atualização
}

function excluirLicenca() {
    // Lógica para excluir a licença
    console.log('Excluindo licença...');
    // Adicione a lógica necessária para preencher o formulário de exclusão
}

function pesquisarLicenca() {
    // Lógica para pesquisar a licença
    console.log('Pesquisando licença...');
    // Adicione a lógica necessária para preencher o formulário de pesquisa
}
function atualizarFuncionario() {
    // Lógica para atualizar o funcionário
    console.log('Atualizando funcionário...');
    // Adicione a lógica necessária para preencher o formulário de atualização
}

function excluirFuncionario() {
    // Lógica para excluir o funcionário
    console.log('Excluindo funcionário...');
    // Adicione a lógica necessária para preencher o formulário de exclusão
}

function pesquisarFuncionario() {
    // Lógica para pesquisar o funcionário
    console.log('Pesquisando funcionário...');
    // Adicione a lógica necessária para preencher o formulário de pesquisa
}
// Adicione um ouvinte de evento para o envio do formulário
document.getElementById('cadastroFuncionarioForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Impede o envio padrão do formulário

    // Obtenha os valores dos campos do formulário
    var nome = document.getElementById('nome').value;
    var cpf = document.getElementById('cpf').value;
    var adress = document.getElementById('adress').value;
    var phone = document.getElementById('phone').value;
    var office = document.getElementById('office').value;
    var salary = document.getElementById('salary').value;

    // Usar API
    console.log('Nome:', nome);
    console.log('CPF:', cpf);
    // ... outros campos ...

    // Feche o modal após o envio do formulário
    $('#cadastroFuncionarioModal').modal('hide');

    // Limpe os campos do formulário
    document.getElementById('nome').value = '';
    document.getElementById('cpf').value = '';
    document.getElementById('adress').value = '';
    document.getElementById('phone').value = '';
    document.getElementById('office').value = '';
    document.getElementById('salary').value = '';

    // Feche também o modal principal
    $('#cadastroModal').modal('hide');
});
//Cadastro de usuario
// Adicione um ouvinte de evento para o envio do formulário de cadastro de usuários
document.getElementById('cadastroUsuarioForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Impede o envio padrão do formulário

    // Obtenha os valores dos campos do formulário de cadastro de usuários
    var user = document.getElementById('user').value;
    var password = document.getElementById('password').value;
    var email = document.getElementById('email').value;
    var userType = document.getElementById('userType').value;

    // Faça algo com os valores (por exemplo, envie para a API)
    console.log('Usuário:', user);
    console.log('Senha:', password);
    console.log('E-mail:', email);
    console.log('Tipo de Usuário:', userType);

    // Feche o modal após o envio do formulário
    $('#cadastroUsuarioModal').modal('hide');

    // Limpe os campos do formulário
    document.getElementById('user').value = '';
    document.getElementById('password').value = '';
    document.getElementById('email').value = '';
    document.getElementById('userType').value = '';

    // Feche também o modal principal
    $('#cadastroModal').modal('hide');
});

//CADASTRO CARGOS
// Adicione um ouvinte de evento para o envio do formulário de cadastro de usuários
document.getElementById('cadastroCargoForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Impede o envio padrão do formulário

    // Obtenha os valores dos campos do formulário de cadastro de usuários
    var cargo = document.getElementById('cargo').value;
    // Faça algo com os valores (por exemplo, envie para a API)
    console.log('Usuário:', cargo);
    // Feche o modal após o envio do formulário
    $('#cadastroCargoModal').modal('hide');
    // Limpe os campos do formulário
    document.getElementById('cargo').value = '';
    // Feche também o modal principal
    $('#cadastroModal').modal('hide');
});

// Cadastro de licenca 

// Adicione um ouvinte de evento para o envio do formulário de cadastro de licença
document.getElementById('cadastroLicencaForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Impede o envio padrão do formulário

    // Obtenha os valores dos campos do formulário de cadastro de licença
    var tipo = document.getElementById('tipo').value;
    var descricao = document.getElementById('descricao').value;
    // Faça algo com os valores (por exemplo, envie para a API)
    console.log('Tipo:', tipo);
    console.log('Descrição:', descricao);
    // Feche o modal após o envio do formulário
    $('#cadastroLicencaModal').modal('hide');
    // Limpe os campos do formulário
    document.getElementById('tipo').value = '';
    document.getElementById('descricao').value = '';
    // Feche também o modal principal
    $('#cadastroModal').modal('hide');
});

// Gerar Holerites
function abrirTelaDeHolerite() {
    // Adicione a lógica para abrir a tela de geração de holerite
    // Aqui, estou apenas mostrando um modal como exemplo
    $('#gerarHoleriteModal').modal('show');
}

// Função para abrir o modal de pesquisa de funcionários
function abrirPesquisaFuncionarioModal() {
    $('#pesquisarFuncionarioModal').modal('show');
}

// Função para selecionar um funcionário da pesquisa
function selecionarFuncionario(id, nome) {
    // Preencha os campos no modal de gerar holerite com os dados do funcionário selecionado
    $('#funcionarioId').val(id).prop('readonly', true);
    $('#funcionarioNome').val(nome).prop('readonly', true);

    // Feche o modal de pesquisa de funcionários
    $('#pesquisarFuncionarioModal').modal('hide');
}

// Ajuste salario

function abrirTelaDeAjusteDeSalario() {
    // Adicione a lógica para abrir a tela de ajuste de salário
    // Aqui, estou apenas mostrando um modal como exemplo
    $('#ajusteSalarioModal').modal('show');
}

// Função para abrir o modal de pesquisa de funcionários para ajuste de salário
function abrirPesquisaAjusteSalarioModal() {
    $('#pesquisarAjusteSalarioModal').modal('show');
}
function atualizarFuncionario() {
    // Lógica para atualizar o funcionário
    console.log('Atualizando funcionário...');
    // Adicione a lógica necessária para preencher o formulário de atualização

    // Feche o modal de atualização de funcionário
    $('#cadastroFuncionarioModal').modal('hide');

    // Feche também o modal principal
    $('#cadastroModal').modal('hide');
}
    // Função para selecionar um funcionário da pesquisa para ajuste de salário
    function selecionarFuncionarioAjusteSalario(codigo, nome, salarioAtual) {
        // Preencha os campos no modal de ajuste de salário com os dados do funcionário selecionado
        $('#codigoFuncionario').val(codigo).prop('readonly', true);
        $('#nomeFuncionario').val(nome).prop('readonly', true);
        $('#salarioAtual').val(salarioAtual).prop('readonly', true);
        $('#novoSalario').val('');

        // Feche o modal de pesquisa de funcionários para ajuste de salário
        $('#pesquisarAjusteSalarioModal').modal('hide');
    }

    function atualizarSalario() {
        // Lógica para atualizar o salário
        console.log('Atualizando salário...');
        // Adicione a lógica necessária para preencher o formulário de atualização de salário
    
        // Feche o modal de ajuste de salário
        $('#ajusteSalarioModal').modal('hide');
    
        // Limpe os campos do formulário
        document.getElementById('codigo').value = '';
        document.getElementById('nomeFuncionario').value = '';
        document.getElementById('salarioAtual').value = '';
        document.getElementById('novoSalario').value = '';
    
        // Feche também o modal principal, se necessário
        // $('#seuModalPrincipal').modal('hide');
    }

// Gerenciar Informações
// script.js

function gerenciarInformacoes() {
    // Lógica para gerenciar informações
    console.log('Gerenciando informações...');

    // Adicione a lógica necessária para obter os valores dos campos
    var codigo = document.getElementById('codigo').value;
    var nomeFuncionario = document.getElementById('nomeFuncionario').value;
    var tipoLicenca = document.getElementById('tipoLicenca').value;
    var dataInicio = document.getElementById('dataInicio').value;
    var dataFinal = document.getElementById('dataFinal').value;

    // Exiba os valores no console (substitua pelo código real de envio para a API ou outra lógica necessária)
    console.log('Código:', codigo);
    console.log('Nome do Funcionário:', nomeFuncionario);
    console.log('Tipo de Licença:', tipoLicenca);
    console.log('Data de Início:', dataInicio);
    console.log('Data Final:', dataFinal);

    // Feche o modal de gerenciar informações
    $('#gerenciarInformacoesModal').modal('hide');

    // Limpe os campos do formulário
    document.getElementById('codigo').value = '';
    document.getElementById('nomeFuncionario').value = '';
    document.getElementById('tipoLicenca').value = '';
    document.getElementById('dataInicio').value = '';
    document.getElementById('dataFinal').value = '';

    // Feche também o modal principal, se necessário
    // $('#seuModalPrincipal').modal('hide');
}

// RElatorios gerais:

  // Função para abrir o modal de relatórios gerais
  function abrirRelatoriosGeraisModal() {
    $('#relatoriosGeraisModal').modal('show');
}

// Função para gerar o relatório
function gerarRelatorio() {
    // Obtenha os valores dos campos do formulário
    var tipoRelatorio = document.getElementById('tipoRelatorio').value;
    var periodoInicio = document.getElementById('periodoInicio').value;
    var periodoFim = document.getElementById('periodoFim').value;

    // Adicione aqui a lógica para gerar e exibir o relatório com base nas opções escolhidas
    console.log('Tipo de Relatório:', tipoRelatorio);
    console.log('Período de Início:', periodoInicio);
    console.log('Período Final:', periodoFim);

    // Feche o modal de relatórios gerais
    $('#relatoriosGeraisModal').modal('hide');

    // Limpe os campos do formulário
    document.getElementById('tipoRelatorio').value = '';
    document.getElementById('periodoInicio').value = '';
    document.getElementById('periodoFim').value = '';
}