(function (window) {
    window.i18n = {
        unwatch : 'Non osservato',
        watch : 'Osservato',
        formatWatch: function (isSubscribed) { return isSubscribed ? 'Non osservato' : 'Osservato'; },
        formatWatchTitle: function (isSubscribed) { return (isSubscribed ? 'Non osservato' : 'Osservato') + ' Ticket'; }
    };
})(window);