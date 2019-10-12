var currentUser = JSON.parse(localStorage.getItem("USER"));
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
        RedirectAction("/Clientes/?id=".concat(currentUser.id));
    }
}

function Sair() {
    Notiflix.Confirm.Show(
        'Confirma sair?',
        'Ao retornar terá que infrmar usuário e senha novamente.',
        'Sair',
        'Ficar',
        function () {
            localStorage.removeItem('USER');
            RedirectAction("/Login");
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