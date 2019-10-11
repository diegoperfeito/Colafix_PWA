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
