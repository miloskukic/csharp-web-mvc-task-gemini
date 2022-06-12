
function formValidation() {
    var firstName = $('#firstName');
    var lastName = $('#lastName');
    var address = $('#address');
    var netoSalary = $('#netoSalary');
    var submitBtn = $('#submitBtn');

    var firstNameErr = true;
    var lastNameErr = true;
    var addressErr = true;
    var netoSalaryErr = true;

    if (firstName.val().length == 0) {
        firstNameErr = true;
    } else {
        firstNameErr = false;
    }

    if (lastName.val().length == 0) {
        lastNameErr = true;
    } else {
        lastNameErr = false;
    }

    if (address.val().length == 0) {
        addressErr = true;
    } else {
        addressErr = false;
    }

    if (netoSalary.val().length == 0) {
        netoSalaryErr = true;
    } else {
        netoSalaryErr = false;
    }

    if (firstNameErr) {
        firstName.css('border', '2px solid #8e0000');
    } else {
        firstName.css('border', '0.5px solid #ced4da');
    }
    if (lastNameErr) {
        lastName.css('border', '2px solid #8e0000');
    } else {
        firstName.css('border', '0.5px solid #ced4da');
    }
    if (addressErr) {
        address.css('border', '2px solid #8e0000');
    } else {
        firstName.css('border', '0.5px solid #ced4da');
    }
    if (netoSalaryErr) {
        netoSalary.css('border', '2px solid #8e0000');
    } else {
        firstName.css('border', '0.5px solid #ced4da');
    }

    if (!firstNameErr && !lastNameErr && !addressErr && !netoSalaryErr) {
        return true;
    } else {
        return false;
    }
}
$(document).ready(function () {
    var firstName = $('#firstName');
    var lastName = $('#lastName');
    var address = $('#address');
    var netoSalary = $('#netoSalary');
    var submitBtn = $('#submitBtn');

    var firstNameErr = true;
    var lastNameErr = true;
    var addressErr = true;
    var netoSalaryErr = true;
    firstName.on('input', function () {
        if (firstName.val().length == 0) {
            firstNameErr = true;
            firstName.css('border', '2px solid #8e0000');
        } else {
            firstNameErr = false;
            firstName.css('border', '0.5px solid #ced4da');
        }
    })
    lastName.on('input', function () {
        if (lastName.val().length == 0) {
            lastNameErr = true;
            lastName.css('border', '2px solid #8e0000');
        } else {
            lastNameErr = false;
            lastName.css('border', '0.5px solid #ced4da');
        }
    })
    address.on('input', function () {
        if (address.val().length == 0) {
            addressErr = true;
            address.css('border', '2px solid #8e0000');
        } else {
            addressErr = false;
            address.css('border', '0.5px solid #ced4da');
        }
    })
    netoSalary.on('input', function () {
        if (netoSalary.val().length == 0) {
            netoSalaryErr = true;
            netoSalary.css('border', '2px solid #8e0000');
        } else {
            netoSalaryErr = false;
            netoSalary.css('border', '0.5px solid #ced4da');
        }
    })


})