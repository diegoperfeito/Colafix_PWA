var currentOrder = JSON.parse(localStorage.getItem("ORDER"));
//var empresaLista = JSON.parse(localStorage.getItem("EMPRESAS"));
function BuildOrder() {
    if (currentOrder === null) {
        const o = new Object();
        o.cod_ven = currentUser.id;
        o.cod_cli = currentCli.Id;
        o.cod_emp = 0;
        o.cod_emp_fat = 0;
        o.cod_loc_cob = 0;
        o.cod_nat_oper = 0;
        o.cod_transa = 0;
        o.cod_transp = 0;
        o.diap1 = 0;
        o.diap2 = 0;
        o.diap3 = 0;
        o.diap4 = 0;
        o.diap5 = 0;
        o.diap6 = 0;
        o.diap7 = 0;
        o.diap8 = 0;
        o.diap9 = 0;
        o.diap10 = 0;
        o.embalagem = "";
        o.obs = "";
        o.perc_acrescimo = 0;
        o.perc_desc = 0;
        o.peso_bru = 0;
        o.peso_liq = 0;
        o.situacao = "";
        o.tipo_frete = "";
        o.total_frete = 0;
        o.usu_altera = "";
        o.usu_inclui = "";
        o.vlr_merc = 0;
        o.vlr_tot = 0;
        o.vlr_acrescimo = 0;
        o.vlr_desc = 0;
        o.vlr_frete = 0;
        o.vlr_icms = 0;
        o.vlr_icms_st = 0;
        o.vlr_ipi = 0;
        o.pedido_item_app = [];

        localStorage.setItem("ORDER", JSON.stringify(o));
        currentOrder = JSON.parse(localStorage.getItem("ORDER"));
    }
}

function BuildEmpresa() {
    empresaLista = JSON.parse(localStorage.getItem("EMPRESAS"));
    var currentUser = JSON.parse(localStorage.getItem("USER"));
    const o = new Object();
    o.usuario = currentUser.usuario;
    $.ajax({
        context: this,
        url: "/Main/GetUsuarioEmpresaLista",
        type: "POST",
        data: BuildData(o),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: function () {
            Notiflix.Loading.Dots("Aguarde...");
        },
        success: function (data) {
            Notiflix.Loading.Remove();
            const returnData = JSON.parse(data);
            if (returnData.MessageType !== 0) {
                ShowMessage(data);
                return;
            }
            var jaTem = false;
            var empLista = [];
            for (let d = 0; d < returnData.EmbeddedData.length; d++) {
                const empresa = new Object();
                empresa.CodEmp = returnData.EmbeddedData[d]['codEmp'];
                empresa.NomeEmp = returnData.EmbeddedData[d]['nomeEmp'];
                empresa.Unidade = returnData.EmbeddedData[d]['unidade'];
                empLista.push(empresa);
            }
            localStorage.setItem("EMPRESAS", JSON.stringify(empLista));
            empresaLista = JSON.parse(localStorage.getItem("EMPRESAS"));
        },
        error: function (data) {
            Notiflix.Loading.Remove();
            ShowError(data);
        }
    });
}

function BuildLocalCobranca() {
    localCobrancaLista = JSON.parse(localStorage.getItem("LOCAISCOBRANCA"));
    var currentUser = JSON.parse(localStorage.getItem("USER"));
    const o = new Object();
    o.usuario = currentUser.usuario;
    $.ajax({
        context: this,
        url: "/Main/GetLocaisCobrancaLista",
        type: "POST",
        data: BuildData(o),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: function () {
            Notiflix.Loading.Dots("Aguarde...");
        },
        success: function (data) {
            Notiflix.Loading.Remove();
            const returnData = JSON.parse(data);
            if (returnData.MessageType !== 0) {
                ShowMessage(data);
                return;
            }
            var jaTem = false;
            var locLista = [];
            for (let d = 0; d < returnData.EmbeddedData.length; d++) {
                const localCobranca = new Object();
                localCobranca.CodLocCob = returnData.EmbeddedData[d]['codLocCob'];
                localCobranca.MostraNoPedido = returnData.EmbeddedData[d]['mostraNoPedido'];
                localCobranca.NomeLocCob = returnData.EmbeddedData[d]['nomeLocCob'];
                locLista.push(localCobranca);
            }
            localStorage.setItem("LOCAISCOBRANCA", JSON.stringify(locLista));
            localCobrancaLista = JSON.parse(localStorage.getItem("LOCAISCOBRANCA"));
        },
        error: function (data) {
            Notiflix.Loading.Remove();
            ShowError(data);
        }
    });
}

function BuildTransacao() {
    transacaoLista = JSON.parse(localStorage.getItem("TRANSACOES"));
    var currentUser = JSON.parse(localStorage.getItem("USER"));
    const o = new Object();
    o.usuario = currentUser.usuario;
    $.ajax({
        context: this,
        url: "/Main/GetTransacoesLista",
        type: "POST",
        data: BuildData(o),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: function () {
            Notiflix.Loading.Dots("Aguarde...");
        },
        success: function (data) {
            Notiflix.Loading.Remove();
            const returnData = JSON.parse(data);
            if (returnData.MessageType !== 0) {
                ShowMessage(data);
                return;
            }
            var jaTem = false;
            var transLista = [];
            for (let d = 0; d < returnData.EmbeddedData.length; d++) {
                const transacao = new Object();
                transacao.CodTran = returnData.EmbeddedData[d]['codTran'];
                transacao.NomeTran = returnData.EmbeddedData[d]['nomeTran'];
                transLista.push(transacao);
            }
            localStorage.setItem("TRANSACOES", JSON.stringify(transLista));
            transacaoLista = JSON.parse(localStorage.getItem("TRANSACOES"));
        },
        error: function (data) {
            Notiflix.Loading.Remove();
            ShowError(data);
        }
    });
}


function AddCartItem(id) {
    const o = new Object();
    o.codProduto = id;
    $.ajax({
        context: this,
        url: "/Main/GetProduto",
        type: "POST",
        data: BuildData(o),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: function() {
            Notiflix.Loading.Dots("Aguarde...");
        },
        success: function(data) {
            Notiflix.Loading.Remove();
            const returnData = JSON.parse(data);
            if (returnData.MessageType !== 0) {
                ShowMessage(data);
                return;
            }

            if (document.getElementById("qtdItem").value === "0" || document.getElementById("qtdItem").value === "" ) {
                Notiflix.Report.Info(
                    'Atenção',
                    'Informe a quantidade do produto!',
                    'Fechar');
                return
            }

            if (document.getElementById("valorItem").value === "0" || document.getElementById("valorItem").value === "") {
                Notiflix.Report.Info(
                    'Atenção',
                    'Informe o valor do produto!',
                    'Fechar');
                return
            }

            if (returnData.EmbeddedData.embalagem != "0") {
                if (document.getElementById("qtdItem").value % returnData.EmbeddedData.embalagem != 0) {
                    Notiflix.Report.Info(
                        'Atenção',
                        'Quantidade informada não é multiplo da embalagem deste produto.',
                        'Fechar');
                    return
                }
            }

            var jaTem = false;
            if (currentOrder != null) {
                for (let i = 0; i < currentOrder.pedido_item_app.length; i++) {
                    if (currentOrder.pedido_item_app[i].cod_prod === id) {
                        currentOrder.pedido_item_app[i].nome_prod = returnData.EmbeddedData.nomeProd;
                        currentOrder.pedido_item_app[i].qtde_ped = parseFloat(document.getElementById("qtdItem").value.replace(",", "."));
                        currentOrder.pedido_item_app[i].valor = parseFloat(document.getElementById("valorItem").value.replace(",", "."));
                        currentOrder.pedido_item_app[i].valor_indice = returnData.EmbeddedData.ValorIndice;
                        currentOrder.pedido_item_app[i].valor_fabrica = parseFloat(document.getElementById("valorItem").value.replace(",", "."));
                        currentOrder.pedido_item_app[i].peso_bru_un = returnData.EmbeddedData.pesoBru;
                        currentOrder.pedido_item_app[i].peso_liq_un = returnData.EmbeddedData.pesoLiq;
                        currentOrder.pedido_item_app[i].unidade = returnData.EmbeddedData.unidade;
                        currentOrder.pedido_item_app[i].item = currentOrder.pedido_item_app.length + 1;
                        currentOrder.pedido_item_app[i].embalagem = returnData.EmbeddedData.embalagem;
                        jaTem = true;
                        break;
                    }
                }
            }
            if (!jaTem) {
                const item = new Object();
                item.cod_prod = id;
                item.nome_prod = returnData.EmbeddedData.nomeProd;
                item.ind_comissao = 0;
                item.ind_custo = 0;
                item.ind_financeiro = 0;
                item.ind_frete = 0;
                item.ind_geral = 0;
                item.ind_impostos = 0;
                item.item = currentOrder.pedido_item_app.length + 1;
                //item.obs = ;
                item.perc_desconto = 0;
                item.perc_icms = 0;
                item.perc_ipi = 0;
                item.peso_bru_un = returnData.EmbeddedData.pesoBru.replace(",", ".");
                item.peso_liq_un = returnData.EmbeddedData.pesoLiq.replace(",", ".");
                item.qtde_ped = parseFloat(document.getElementById("qtdItem").value.replace(",", "."));
                item.qtde_emb = 0;
                item.situacao = "ANALISE";
                item.unidade = returnData.EmbeddedData.unidade;
                item.valor = parseFloat(document.getElementById("valorItem").value.replace(",", "."));
                item.valor_fabrica = parseFloat(document.getElementById("valorItem").value.replace(",", "."));
                item.valor_indice = 0;
                item.embalagem = returnData.EmbeddedData.embalagem;

                currentOrder.pedido_item_app.push(item);
            }
            localStorage.setItem("ORDER", JSON.stringify(currentOrder));
            document.getElementById("qtdItem").value = "0";
            document.getElementById("totalItem").value = "";
            $("#qtdItem").focus();
            $("#qtdItem").select();
            RedirectAction('/Menu');
//            HasCartOpen();
        },
        error: function(data) {
            Notiflix.Loading.Remove();
            ShowError(data);
        }
    });
}


function ShowCart() {
    BuildOrder();
    console.log(currentOrder);
    var html = "";
    for (let i = 0; i < currentOrder.pedido_item_app.length; i++) {
        html +=
            `<div class='row' style='margin-bottom:0'>
                <div class='col-12'>
                    <div id='card_${currentOrder.pedido_item_app[i].cod_prod}' class='card' style='margin: 0.5rem 0 0rem 0'>
                        <div class='card-body' style='padding: 7px 5px 0px 5px'>
                            <div style='position:absolute; height: 25px; width: 25px; right: 0px; top: 2px; z-index:1000; cursor:pointer' onclick=\"DeleteItemCart('${currentOrder.pedido_item_app[i].cod_prod}')\"><i class="material-icons">delete</i></div>
                                <div class='row'>
                                    <div class='col-12'>
                                        <label>${currentOrder.pedido_item_app[i].nome_prod}</label>
                                    </div>
                                    <div class='col-6' align='center'>
                                        <label for='qtdItem'>Quantidade</label>
                                        <input type="currency" id="qtdItem" disabled="true" class="form-control" value="${currentOrder.pedido_item_app[i].qtde_ped}" style='text-align:center'/>
                                    </div>
                                    <div class='col-6' align='center'>
                                        <label for='qtdItem'>Valor</label>
                                        <input type="currency" id="qtdItem" disabled="true" class="form-control" value="${currentOrder.pedido_item_app[i].valor}" style='text-align:center'/>
                                    </div>
                                    <div class='col-12' align='right'>
                                        <label id="lblTotalItem" style='font-weight:bold'>${(currentOrder.pedido_item_app[i].qtde_ped * currentOrder.pedido_item_app[i].valor).toLocaleString("pt-BR", { style: "currency", currency: "BRL" })}</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>`
    }

    html += `<div class='row'>
                    <div class='col-6'>
                        <span>Peso(kg): </span><label id='labelPeso' style='font-weight:bold'>${TotalCartPeso()}</label>
                    </div>
                    <div class='col-6' align='right'>
                        <span>Total: </span><label id='labelTotalCart' style='font-weight:bold'>${TotalCart()}</label></div>
                    </div>
             </div>`;
    document.getElementById('cartData').innerHTML = html;
}


function ShowInfo() {
    BuildOrder();
    var html = "";

    html += `<div class='row'>
                    <div class='col-6'>
                        <span>Valor do Frete: </span><label id='labelValorFrete' style='font-weight:bold'></label>
                    </div>
                    <div class='col-6'>
                        <input type="currency" id="valorFrete" class="form-control" style='text-align:center'/>
                    </div>
             </div>`;

    html += `<div class='row'>
                    <div class='col-6'>
                        <span>Prazo Pagto(ex: 30.40.60): </span><label id='labelValorFrete' style='font-weight:bold'></label>
                    </div>
                    <div class='col-6'>
                        <input type="text" id="prazoPagto" class="form-control" style='text-align:center'/>
                    </div>
             </div>`;

    html += `<div class='row'>
                    <div class='col-12'>
                        <span>Observações: </span><label id='labelObs' style='font-weight:bold'></label>
                    </div>
                    <div class='col-12'>
                        <input type="text" id="obs" class="form-control" style='text-align:center'/>
                    </div>
             </div>`;

    document.getElementById('cartInfo').innerHTML = html;
}







function TotalCart() {
    var total = 0;
    for (let i = 0; i < currentOrder.pedido_item_app.length; i++) {
        total += currentOrder.pedido_item_app[i].valor * currentOrder.pedido_item_app[i].qtde_ped;
    }
    currentOrder.vlr_tot = total;
    currentOrder.vlr_merc = total;
    return total.toLocaleString("pt-BR", { style: "currency", currency: "BRL" });



}


function TotalCartPeso() {
    var pesoTotal = 0;
    for (let i = 0; i < currentOrder.pedido_item_app.length; i++) {
        if (currentOrder.pedido_item_app[i].unidade == 2) {
            pesoTotal += currentOrder.pedido_item_app[i].qtde_ped; // * xMultiplo;
        } else {
            pesoTotal += parseFloat(currentOrder.pedido_item_app[i].qtde_ped * currentOrder.pedido_item_app[i].peso_bru_un); // * xMultiplo;
        }
    }
    return  pesoTotal;
}

function ValidaPrazo() {
    const prazo = document.getElementById("prazoPagto").value;
    var arPrazo = prazo.split(".");
    if (arPrazo.length == 0 || arPrazo[0] == "" || arPrazo.length > 10) {
        Notiflix.Report.Warning(
            'Atenção',
            'prazo de pagamento inválido',
            'Fechar');
        return false;
    } else {
        // verificação de contéudo e de ordem correta dos prazos
        var x = 0;
        for (var i = 0; i <= arPrazo.length-1; i++) {
            if (!$.isNumeric(arPrazo[i])) {
                Notiflix.Report.Warning(
                    'Atenção',
                    'prazo de pagamento inválido',
                    'Fechar');
                return false;
            }
            if (parseFloat(arPrazo[i]) < x) {
                Notiflix.Report.Warning(
                    'Atenção',
                    'prazo de pagamento inválido',
                    'Fechar');
                return false;
            } else {
                x = parseFloat(arPrazo[i]);
            }
        }
        for (var i = 0; i <= arPrazo.length - 1; i++) {
            if (i == 0) currentOrder.diap1 = arPrazo[0];
            if (i == 1) currentOrder.diap2 = arPrazo[1];
            if (i == 2) currentOrder.diap3 = arPrazo[2];
            if (i == 3) currentOrder.diap4 = arPrazo[3];
            if (i == 4) currentOrder.diap5 = arPrazo[4];
            if (i == 5) currentOrder.diap6 = arPrazo[5];
            if (i == 6) currentOrder.diap7 = arPrazo[6];
            if (i == 7) currentOrder.diap8 = arPrazo[7];
            if (i == 8) currentOrder.diap9 = arPrazo[8];
            if (i == 9) currentOrder.diap10 = arPrazo[9];
        }
        return true;
    }
}


function DeleteItemCart(id) {
    Notiflix.Confirm.Show(
        "Confirma?",
        "Excluir o item do carrinho cod. ".concat(id),
        "Sim",
        "Não",
        function () {
            var i = currentOrder.pedido_item_app.length;
            while (i--) {
                if (currentOrder.pedido_item_app[i].cod_prod === id) {
                    console.log('encontrado');
                    currentOrder.pedido_item_app.splice(i, 1);
                }
            }
            localStorage.setItem("ORDER", JSON.stringify(currentOrder));
            const element = document.getElementById("card_".concat(id));
            element.parentNode.removeChild(element);
            if (currentOrder.pedido_item_app.length === 0) {
                RedirectAction('/Menu');
            } else {
                document.getElementById('labelTotalCart').innerHTML = TotalCart();
                document.getElementById('labelPeso').innerHTML = TotalCartPeso();
            }
        }, function () {

        });
}



function currencyFormat(num) {
    return "R$" + num.toFixed(2).replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")
}


function FinishCheckOut() {
    if (!ValidaPrazo()) {
        return;
    }

    var emp = document.getElementById("txtEmpresa").value
    if (emp == "") {
        Notiflix.Report.Warning(
            'Atenção',
            'Selecione empresa de faturamento',
            'Fechar');
        return;
    }
    currentOrder.cod_emp = emp.split(" - ")[0];
    currentOrder.cod_emp_fat = emp.split(" - ")[0];

    var locCob = document.getElementById("txtLocalCobranca").value
    if (locCob == "") {
        Notiflix.Report.Warning(
            'Atenção',
            'Selecione forma de pagamento',
            'Fechar');
        return;
    }
    currentOrder.cod_loc_cob = locCob.split(" - ")[0];

    var frete = document.getElementById("txtTipoFrete").value;
    if (frete == "") {
        Notiflix.Report.Warning(
            'Atenção',
            'Selecione tipo de frete',
            'Fechar');
        return;
    }
    currentOrder.tipo_frete = frete.split(" - ")[0];
    currentOrder.vlr_frete = parseFloat(document.getElementById("valorFrete").value.replace(",", "."));;

    if (isNaN(currentOrder.vlr_frete)) {
        currentOrder.vlr_frete = 0;
    }

    currentOrder.situacao = 'ANALISE';

    var tipo = document.getElementById("txtTransacao").value;
    if (tipo == "") {
        Notiflix.Report.Warning(
            'Atenção',
            'Selecione tipo de transação',
            'Fechar');
        return;
    }
    currentOrder.cod_transa = tipo.split(" - ")[0];

    currentOrder.obs = document.getElementById("obs").value;
    currentOrder.usu_inclui = currentUser.usuario;

    var objPed = new Object();
    objPed.pedidoApp = currentOrder;



    Notiflix.Confirm.Show(
        "Confirma Envio?",
        "Confirmar envio dos dados e conclusão da venda?",
        "Sim",
        "Não",
        function () {
         //   localStorage.removeItem("ORDER");
            Notiflix.Notify.Success('Enviando pedido para o servidor');
            $.ajax({
                context: this,
                url: "/Main/InsertPedidoApp",
                type: "POST",
                data: BuildData(objPed),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                beforeSend: function () {
                    Notiflix.Loading.Dots("Aguarde...");
                },
                success: function (data) {
                    Notiflix.Loading.Remove();
                    const returnData = JSON.parse(data);
                    if (returnData.MessageType !== 0) {
                        Notiflix.Notify.Success(data);
                        return;
                    }
                    Notiflix.Notify.Success('Pedido enviado com sucesso');
                    localStorage.removeItem("ORDER");
                    localStorage.removeItem("CLI");
                    RedirectAction("/Menu");
                },
                error: function (data) {
                    Notiflix.Loading.Remove();
                    ShowError(data);
                }
            });
        },
        function() {
            Notiflix.Notify.Warning('Envio cancelado');
        });
}

