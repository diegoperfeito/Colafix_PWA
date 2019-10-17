if ("serviceWorker" in navigator) {
    console.log("Will the service worker register?");
    navigator.serviceWorker.register("/sw.js")
        .then(function (reg) {
            console.log("Yes, it did.");
        }).catch(function (err) {
            console.log("No it didn't. This happened: ", err);
        });
}

////////////////////
//Shorcut para IOS//
////////////////////
const isIos = () => {
    const userAgent = window.navigator.userAgent.toLowerCase();
    return /iphone|ipad|ipod/.test(userAgent);
};
// Detects if device is in standalone mode
const isInStandaloneMode = () => ("standalone" in window.navigator) && (window.navigator.standalone);
// Checks if should display install popup notification:
//if (isIos() && !isInStandaloneMode()) {
//    this.setState({ showInstallMessage: true });
//}

(function ($) {
    $(function () {
        $(".modal").modal();
        $(".fixed-action-btn").floatingActionButton({ direction: "top", hoverEnabled: false });
        $(".tabs").tabs();
        $(".tabsInner").tabs();
        var optionsCpfCnpj = {
            onKeyPress: function (cpf, ev, el, op) {
                var masks = ["000.000.000-000", "00.000.000/0000-00"],
                    mask = (cpf.length > 14) ? masks[1] : masks[0];
                el.mask(mask, op);
            }
        };
        $(".cpfCnpj").mask("000.000.000-000", optionsCpfCnpj);
        $(".cnpjApenas").mask("00.000.000/0000-00", { reverse: true });
        $(".cpfApenas").mask("000.000.000-000", { reverse: true });
        $(".range-all").mask("00000", { reverse: true });
        $(".datepicker").datepicker();
        $(".timepicker").timepicker();
        $(".telefoneCelular").mask("0.0000-0000");
        $(".telefoneCelularComDdd").mask("(00) 0.0000-0000");
        $(".cep").mask("00000-000");
        $(".dataNascimento").mask("00/00/0000");
        $(".expirationData").mask("00/00");
        $(".hora").mask("00:00:00");
        $(".horaCurta").mask("00:00");
        $(".linhaDigitavel").mask("00000.00000 00000.000000 00000.000000 0 00000000000000");
        $(".money").mask("000.000.000.000.000,000", { reverse: true });
        $(".weight").mask("0000000", { reverse: true });
    });
})(jQuery);


(function($) {
    $(function() {
        $('.sidenav').sidenav();
    });
})(jQuery);

wow = new WOW(
    {
        boxClass: "wow",      // default
        animateClass: "animated", // default
        offset: 0,          // default
        mobile: true,       // default
        live: true        // default
    }
);
wow.init();
