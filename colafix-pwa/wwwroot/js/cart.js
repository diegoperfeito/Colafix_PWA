var currentOrder = JSON.parse(localStorage.getItem("ORDER"));
function BuildOrder() {
    if (currentOrder === null) {
        const o = new Object();
        o.CodVen = currentUser.Id;
        o.CodCli = currentCli.Id;
        o.CodEmp = null;
        o.CodEmpFat = null;
        o.CodLocCob = null;
        o.CodNatOper = null;
        o.CodTransa = null;
        o.CodTransp = null;
        o.Diap1 = null;
        o.Diap2 = null;
        o.Diap3 = null;
        o.Diap4 = null;
        o.Diap5 = null;
        o.Diap6 = null;
        o.Diap7 = null;
        o.Diap8 = null;
        o.Diap9 = null;
        o.Diap10 = null;
        o.Embalagem = null;
        o.Obs = null;
        o.PercAcrescimo = null;
        o.PercDesc = null;
        o.PesoBru = null;
        o.PesoLiq = null;
        o.Situacao = null;
        o.TipoFrete = null;
        o.TotalFrete = null;
        o.UsuAltera = null;
        o.UsuInclui = null;
        o.VlrMerc = null;
        o.VlrTot = null;
        o.VlrAcrescimo = null;
        o.VlrDesc = null;
        o.VlrFrete = null;
        o.VlrIcms = null;
        o.VlrIcmsSt = null;
        o.VlrIpi = null;
        o.PedidoItemApp = [];

        localStorage.setItem("ORDER", JSON.stringify(o));
        currentOrder = JSON.parse(localStorage.getItem("ORDER"));
    }
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
            var jaTem = false;
            for (let i = 0; i < currentOrder.PedidoItemApp.length; i++) {
                if (currentOrder.PedidoItemApp[i].CodProd === id) {
                    currentOrder.PedidoItemApp[i].Item = returnData.EmbeddedData.nomeProd;
                    currentOrder.PedidoItemApp[i].QtdePed += parseFloat(document.getElementById("qtdItem").value.replace(",", "."));
                    currentOrder.PedidoItemApp[i].Valor += parseFloat(document.getElementById("totalItem").value.replace(",", "."));
                    item.ValorIndice = parseFloat(document.getElementById("valorItem").value.replace(",", "."));
                    jaTem = true;
                    break;
                }
            }
            if (!jaTem) {
                const item = new Object();
                item.CodProd = id;
                item.IndComissao = null;
                item.IndCusto = null;
                item.IndFinanceiro = null;
                item.IndFrete = null;
                item.IndGeral = null;
                item.IndImpostos = null;
                item.Item = returnData.EmbeddedData.nomeProd;
                item.Obs = null;
                item.PercDesconto = null;
                item.PercIcms = null;
                item.PercIpi = null;
                item.PesoBruUn = null;
                item.PesoLiqUn = null;
                item.QtdePed = parseFloat(document.getElementById("qtdItem").value.replace(",", "."));
                item.QtdeEmb = null;
                item.Situacao = null;
                item.Valor = parseFloat(document.getElementById("totalItem").value.replace(",", "."));
                item.ValorFabrica = null;
                item.ValorIndice = parseFloat(document.getElementById("valorItem").value.replace(",", "."));
                currentOrder.PedidoItemApp.push(item);
            }
            localStorage.setItem("ORDER", JSON.stringify(currentOrder));
            document.getElementById("qtdItem").value = "0";
            document.getElementById("totalItem").value = "";
            $("#qtdItem").focus();
            $("#qtdItem").select();
            HasCartOpen();
            console.log(returnData.EmbeddedData);
        },
        error: function(data) {
            Notiflix.Loading.Remove();
            ShowError(data);
        }
    });
}

function ShowCart() {
    var html = "";
    for (let i = 0; i < currentOrder.PedidoItemApp.length; i++) {
        html +=
            `<div class='row' style='margin-bottom:0'>
                <div class='col-12'>
                    <div id='card_${currentOrder.PedidoItemApp[i].CodProd}' class='card' style='margin: 0.5rem 0 0rem 0'>
                        <div class='card-body' style='padding: 7px 5px 0px 5px'>
<div style='position:absolute; height: 25px; width: 25px; right: 0px; top: 2px; z-index:1000; cursor:pointer' onclick=\"DeleteItemCart('${currentOrder.PedidoItemApp[i].CodProd}')\"><i class="material-icons">delete</i></div>
                            <div class='row'>
                                <div class='col-12'>
                                    <label>${currentOrder.PedidoItemApp[i].Item}</label>
                                </div>
                                <div class='col-6' align='center'>
<label for='qtdItem'>Quantidade</label>
<input type="currency" id="qtdItem" onkeyup="calculaItem()" class="form-control" value="${currentOrder.PedidoItemApp[i].QtdePed}" style='text-align:center'/>
                                </div>
                                <div class='col-6' align='center'>
<label for='qtdItem'>Valor</label>
<input type="currency" id="qtdItem" onkeyup="calculaItem()" class="form-control" value="${currentOrder.PedidoItemApp[i].Valor}" style='text-align:center'/>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>`;
    }
    html += `<div><div class='row'><div class='col-12' align='right'><span>TOTAL: </span><label id='labelTotalCart' style='font-weight:bold'>${TotalCart()}</label></div></div></div>`;
    document.getElementById('cartData').innerHTML = html;
}

function TotalCart() {
    var total = 0;
    for (let i = 0; i < currentOrder.PedidoItemApp.length; i++) {
        total += currentOrder.PedidoItemApp[i].Valor;
    }
    return total;
}

function DeleteItemCart(id) {
    Notiflix.Confirm.Show(
        "Confirma?",
        "Excluir o item do carrinho cod. ".concat(id),
        "Sim",
        "Não",
        function () {
            var i = currentOrder.PedidoItemApp.length;
            while (i--) {
                if (currentOrder.PedidoItemApp[i].CodProd === id) {
                    console.log('encontrado');
                    currentOrder.PedidoItemApp.splice(i, 1);
                }
            }
            localStorage.setItem("ORDER", JSON.stringify(currentOrder));
            const element = document.getElementById("card_".concat(id));
            element.parentNode.removeChild(element);
            document.getElementById('labelTotalCart').innerHTML = TotalCart();
            if (currentOrder.PedidoItemApp.length === 0) {
                RedirectAction('/Menu');
            }
        }, function () {

        });
}

function FinishCheckOut() {
    Notiflix.Confirm.Show(
        "Confirma Envio?",
        "Confirmar envio dos dados e conclusão da venda?",
        "Sim",
        "Não",
        function() {
            Notiflix.Notify.Success('Chama ajax do metodo de venda');
        },
        function() {
            Notiflix.Notify.Warning('Envio cancelado');
        });
}