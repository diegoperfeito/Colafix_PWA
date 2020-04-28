var currentUser = JSON.parse(localStorage.getItem("USER"));
var currentCli = JSON.parse(localStorage.getItem("CLI"));
function Ola() {
    if (currentUser === null) {
        window.location.href = "/Login";
    } else {
        const o = new Object();
        o.Usuario = currentUser.usuario;
        $.ajax({
            context: this,
            url: '/Main/UsuarioAtivo',
            type: 'POST',
            data: JSON.stringify(o),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            beforeSend: function () {
                Notiflix.Loading.Dots('Aguarde...');
            },
            success: function (data) {
                Notiflix.Loading.Remove();
                const returnData = JSON.parse(data);
                if (returnData.EmbeddedData == false) {
                    ShowMessage(data);
                    window.location.href = "/Login";
                    return;
                } else {
                    RedirectAction("Menu");
                }
            },
            error: function (data) {
                Notiflix.Loading.Remove();
                ShowMessage(data);
                window.location.href = "/Login";
            }
        });
    }
}

function ShowMessage(mensagem) {
    const obj = JSON.parse(mensagem);
    switch (obj.MessageType) {
        case 0:
            window.Notiflix.Report.Success(
                obj.Title,
                obj.Message,
                "Ok"
            );
            break;
        case 1:
            window.Notiflix.Report.Failure(
                obj.Title,
                obj.Message,
                "Ok"
            );
            break;
        case 2:
            window.Notiflix.Report.Warning(
                obj.Title,
                obj.Message,
                "Ok"
            );
            break;
        case 3:
            window.Notiflix.Report.Info(
                obj.Title,
                obj.Message,
                "Ok"
            );
    }
}

function ShowError(error) {
    const obj = JSON.parse(error);
    window.Notiflix.Report.Warning(
        obj.Title,
        obj.Message,
        "Ok"
    );
}

function RedirectAction(action) {
    window.location.href = action;
}

function OpenMenu(action) {
    if (action.toLowerCase() === "clientes") {
        RedirectAction("/Clientes/?id=".concat(currentUser.id).concat("&admin=").concat(currentUser.admin));
    }
    if (action.toLowerCase() === "pedidos") {
        console.log(currentCli);
        if (currentCli === null) {
            RedirectAction("/Pedidos/?id=".concat(currentUser.id).concat("&codCliente=0"));
        } else {
            RedirectAction("/Pedidos/?id=".concat(currentUser.id).concat("&codCliente=".concat(currentCli.Id)));
        }

    }
    if (action.toLowerCase() === "checkout") {
        RedirectAction("/CheckOut/?usuario=".concat(currentUser.usuario));
    }
    if (action.toLowerCase() === "checkoutnovo") {
        RedirectAction("/CheckOutNovo/?usuario=".concat(currentUser.usuario).concat("&codCliente=".concat(currentCli.Id)));
    }
    if (action.toLowerCase() === "financ") {
        if (currentCli == null) {
            Notiflix.Report.Warning(
                'Atenção',
                'Selecione um cliente',
                'Fechar');
            return;
        }
       RedirectAction("/Financeiro/?id=".concat(currentCli.Id));
    }

    if (action.toLowerCase() === "semcompras") {
        if (currentCli == null) {
            Notiflix.Report.Warning(
                'Atenção',
                'Selecione um cliente',
                'Fechar');
            return;
        }
        RedirectAction("/ProdutosSemCompras/?id=".concat(currentCli.Id));
    }

    if (action.toLowerCase() === "entregas") {
        if (currentCli == null) {
            Notiflix.Report.Warning(
                'Atenção',
                'Selecione um cliente',
                'Fechar');
            return;
        }
        RedirectAction("/RegistroEntrega/?id=".concat(currentCli.Id));
    }
}

function Sair() {
    Notiflix.Confirm.Show(
        "Confirma sair?",
        "Ao retornar terá que infrmar usuário e senha novamente.",
        "Sair",
        "Ficar",
        function () {
            localStorage.removeItem("USER");
            localStorage.removeItem("CLI");
            localStorage.removeItem("ORDER");
            RedirectAction("/Login");
        }, function () {

        });
}

function LimparCarrinho() {
    Notiflix.Confirm.Show(
        "Confirma Limpar Carrinho?",
        "Pedido atual será apagado.",
        "Sim",
        "Não",
        function () {
            localStorage.removeItem("ORDER");
            localStorage.removeItem("CLI");
            RedirectAction("/Menu");
        }, function () {

        });
}

function BuildData(obj) {
    const o = new Object();
    o.Usuario = currentUser.usuario;
    o.Senha = currentUser.senha;
    o.BodyData = obj !== null ? obj : null;
    return JSON.stringify(o);
}

function AddRemoveCli(id, nome) {
    console.log(id);
    if (id !== null) {
        const o = new Object();
        o.Id = id;
        o.Nome = nome.substring(0, 30);
        localStorage.removeItem("CLI");
        localStorage.setItem("CLI", JSON.stringify(o));
        currentCli = JSON.parse(localStorage.getItem("CLI"));
        console.log(currentCli);
        const currentOrder = JSON.parse(localStorage.getItem("ORDER"));
        if (currentOrder !== null) {
            if (currentOrder.Id !== id) {
                console.log(currentOrder);
                currentOrder.CodCli = currentCli.Id;
                currentOrder.cod_cli = currentCli.Id;
                localStorage.removeItem("ORDER");
                localStorage.setItem("ORDER", JSON.stringify(currentOrder));
                Notiflix.Notify.Success("O pedido atual teve seu cliente alterado");
            }
        }
        RedirectAction('/Menu');
        return;
    } else {
        if (currentCli === null) {
            RedirectAction("/Clientes/?id=".concat(currentUser.id).concat("&admin=").concat(currentUser.admin));
        } else {
            Notiflix.Confirm.Show(
                "Confirma?",
                "Ao desconsiderar o cliente selecionado os pedidos não confirmados também serão excluídos.",
                "Confirmar",
                "Deixa assim",
                function () {
                    localStorage.removeItem("CLI");
                    localStorage.removeItem("ORDER");
                    currentCli = null;
                    HasCartOpen();
                    RedirectAction("/Menu");
                }, function () {

                });
        }
    }
    ShowCurrentCli();
}

function ShowCurrentCli() {
    document.getElementById("currentUserName").innerHTML = "Usuário: "+ currentUser.usuario;
    if (currentCli !== null) {
        document.getElementById("cliIcon").innerHTML = "delete";
        document.getElementById("currentCliName").innerHTML = currentCli.Id + " - " + currentCli.Nome;
    } else {
        document.getElementById("cliIcon").innerHTML = "person_add";
        document.getElementById("currentCliName").innerHTML = "Nenhum cliente selecionado";
    }
    HasCartOpen();
}

function HasCartOpen() {
    const currentOrder = JSON.parse(localStorage.getItem("ORDER"));
    if (currentOrder === null) {
        document.getElementById("cartIcon").style.display = "none";
    } else {
        document.getElementById("cartIcon").style.display = currentOrder.pedido_item_app.length > 0 ? "block" : "none";
    }
}