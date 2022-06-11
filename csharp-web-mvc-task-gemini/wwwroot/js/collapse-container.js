$(document).ready(function () {
    var collapseBtn = $('#collapseBtn');
    var collapseContainer = $('.optionalContainer');
    collapseBtn.on('click', function () {
        if (collapseContainer.css("display")!="none") {
            collapseBtn.html("<i class=\"fa-solid fa-angle-down mr-2\"></i>Parametri za izračunavanje bruto zarade i dodatnih troškova (opciono)");
        } else {
            collapseBtn.html("<i class=\"fa-solid fa-angle-up mr-2\"></i>Parametri za izračunavanje bruto zarade i dodatnih troškova (opciono)");
        }
        collapseContainer.toggle("slow");
    });
});