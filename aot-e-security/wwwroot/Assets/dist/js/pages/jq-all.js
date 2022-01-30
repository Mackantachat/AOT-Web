$(document).ready(function () {
    $('input.engonly').on('keypress', function (e) {
        let matchtext = /[a-zA-Z0-9\.*\s*\(*\)*]+/gi
        var key = String.fromCharCode(e.which);
        if (matchtext.test(key)) {
            return true
        }
        return false
    })
    $('input.Thionly').on('keypress', function (e) {
        let matchtext = /[ก-๙]+/gi
        var key = String.fromCharCode(e.which);
        if (matchtext.test(key)) {
            return true
        }
        return false
    })
    $('input.Thai').on('keypress', function (e) {
        let matchtext = /[ก-๙\s*]+/gi
        var key = String.fromCharCode(e.which);
        if (matchtext.test(key)) {
            return true
        }
        return false
    })
    $('input.engandnumber').on('keypress', function (e) {
        let matchtext = /[a-zA-Z0-9]+/gi;
        var key = String.fromCharCode(e.which);
        if (matchtext.test(key)) {
            return true
        }
        return false
    })
    $('input.validdates').on('keypress', function (e) {
        let matchtext = /[0-9\/]+/gi;
        var key = String.fromCharCode(e.which);
        if (matchtext.test(key)) {
            return true
        }
        return false
    })

    $(document).ready(function () {
        $('[data-toggle="tooltip"]').tooltip();
    });

    $('input.numberonly').on('keypress', function (e) {
        let matchtext = /[0-9]+/gi
        var key = String.fromCharCode(e.which);
        if (matchtext.test(key)) {
            return true
        }
        return false
    })
    $('input.datenumberonly').on('keypress', function (e) {
        let matchtext = /[0-9\,*\.*\s*/\/*\:*]+/gi
        var key = String.fromCharCode(e.which);
        if (matchtext.test(key)) {
            return true
        }
        return false
    })
});


