var currentUser = JSON.parse(localStorage.getItem("USER"));
var currentCli = JSON.parse(localStorage.getItem("CLI"));
function Ola() {
    if (currentUser === null) {
        window.location.href = "/Login";
    } else {
        window.location.href = "/Menu";
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
        RedirectAction("/Pedidos/?id=".concat(currentUser.id));
    }
    if (action.toLowerCase() === "checkout") {
        RedirectAction("/CheckOut/?usuario=".concat(currentUser.usuario));
    }
    if (action.toLowerCase() === "checkoutnovo") {
        RedirectAction("/CheckOutNovo/?usuario=".concat(currentUser.usuario));
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
    if (id !== null) {
        const o = new Object();
        o.Id = id;
        o.Nome = nome;
        localStorage.setItem("CLI", JSON.stringify(o));
        currentCli = JSON.parse(localStorage.getItem("CLI"));
        const currentOrder = JSON.parse(localStorage.getItem("ORDER"));
        if (currentOrder !== null) {
            if (currentOrder.Id !== id) {
                currentOrder.CodCli = currentCli.Id;
                Notiflix.Notify.Success("O pedido atual teve seu cliente alterado");
                localStorage.setItem("ORDER", JSON.stringify(currentOrder));
            }
        }
        RedirectAction('/Menu');
        return;
    } else {
        if (currentCli === null) {
            RedirectAction("/Clientes/?id=".concat(currentUser.id));
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
    if (currentCli !== null) {
        document.getElementById("cliIcon").innerHTML = "delete";
        document.getElementById("currentCliName").innerHTML = currentCli.Nome;
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