﻿$("#addManufacturer").click(function () {
    var data = {
        ManufacturerID: $("#ManufacturerID").val(),
        ManufacturerName: $("#ManufacturerName").val(),
    };

    $.ajax({
        url: '/Phone/CreateAJAX',
        type: 'POST',
        data: data,
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $("#ManufacturerID").val(),
            $("#ManufacturerName").val()
        },
        error: function () {
            alert("error");
        }
    });
});



