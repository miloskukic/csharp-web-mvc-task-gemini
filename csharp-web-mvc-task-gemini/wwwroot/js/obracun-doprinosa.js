$(document).ready(function () {
    var poljePlata = $('#netoSalary');
    var poljePIO = $("#pio-field");
    var poljeZdravstveno = $("#zdravstveno-field");
    var poljeNezaposlenost = $("#nezaposlenost-field");
    var iznosPIO = $(".pio-din-value");
    var iznosZdravstveno = $(".zdravstveno-din-value");
    var iznosNezaposlenost = $(".nezaposlenost-din-value");

    var poljePoslodavacPIO = $("#pio-poslodavac-field");
    var poljePoslodavacZdravstveno = $("#zdravstveno-poslodavac-field");
    var poljePoslodavacNezaposlenost = $("#nezaposlenost-poslodavac-field");
    var iznosPoslodavacPIO = $(".pio-poslodavac-din-value");
    var iznosPoslodavacZdravstveno = $(".zdravstveno-poslodavac-din-value");
    var iznosPoslodavacNezaposlenost = $(".nezaposlenost-poslodavac-din-value");
    
    var plata = poljePlata.val();

    var pio = 0;
    var zdravstveno = 0;
    var nezaposlenost = 0;

    poljePlata.on('input', function () {
        var plata = poljePlata.val();
        var pio = poljePIO.val();
        var zdravstveno = poljeZdravstveno.val();
        var nezaposlenost = poljeNezaposlenost.val();
        var pioPoslodavac = poljePoslodavacPIO.val();
        var zdravstvenoPoslodavac = poljePoslodavacZdravstveno.val();
        var nezaposlenostPoslodavac = poljePoslodavacNezaposlenost.val();

        if (!plata.match('^ [0 - 9] + $')) {
            iznosPIO.text(plata * pio / 100);
            iznosZdravstveno.text(plata * zdravstveno / 100);
            iznosNezaposlenost.text(plata * nezaposlenost / 100);

            iznosPoslodavacPIO.text(plata * pioPoslodavac / 100);
            iznosPoslodavacZdravstveno.text(plata * zdravstvenoPoslodavac / 100);
            iznosPoslodavacNezaposlenost.text(plata * nezaposlenostPoslodavac / 100);
        } else {
            iznosPIO.text("NaN");
            iznosZdravstveno.text("NaN");
            iznosNezaposlenost.text("NaN");
            iznosPoslodavacPIO.text("NaN");
            iznosPoslodavacZdravstveno.text("NaN");
            iznosPoslodavacNezaposlenost.text("NaN");
        }
    });

    poljePIO.on('input', function () {
        var plata = poljePlata.val();
        var pio = poljePIO.val();
        if (!plata.match('^ [0 - 9] + $')) {
            iznosPIO.text(plata * pio / 100);
        } else {
            iznosPIO.text("NaN");
        }
    });

    poljeZdravstveno.on('input', function () {
        var plata = poljePlata.val();
        var zdravstveno = poljeZdravstveno.val();
        if (!plata.match('^ [0 - 9] + $')) {
            iznosZdravstveno.text(plata * zdravstveno / 100);
        } else {
            iznosZdravstveno.text("NaN");
        }
    });

    poljeNezaposlenost.on('input', function () {
        var plata = poljePlata.val();
        var nezaposlenost = poljeNezaposlenost.val();
        if (!plata.match('^ [0 - 9] + $')) {
            iznosNezaposlenost.text(plata * nezaposlenost / 100);
        } else {
            iznosNezaposlenost.text("NaN");
        }
    });

    //Poslodavac

    poljePoslodavacPIO.on('input', function () {
        var plata = poljePlata.val();
        var pio = poljePoslodavacPIO.val();
        if (!plata.match('^ [0 - 9] + $')) {
            iznosPoslodavacPIO.text(plata * pio / 100);
        } else {
            iznosPoslodavacPIO.text("NaN");
        }
    });

    poljePoslodavacZdravstveno.on('input', function () {
        var plata = poljePlata.val();
        var zdravstveno = poljePoslodavacZdravstveno.val();
        if (!plata.match('^ [0 - 9] + $')) {
            iznosPoslodavacZdravstveno.text(plata * zdravstveno / 100);
        } else {
            iznosPoslodavacZdravstveno.text("NaN");
        }
    });

    poljePoslodavacNezaposlenost.on('input', function () {
        var plata = poljePlata.val();
        var nezaposlenost = poljePoslodavacNezaposlenost.val();
        if (!plata.match('^ [0 - 9] + $')) {
            iznosPoslodavacNezaposlenost.text(plata * nezaposlenost / 100);
        } else {
            iznosPoslodavacNezaposlenost.text("NaN");
        }
    });
});