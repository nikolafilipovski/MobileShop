$("#addManufacturer").click(function () {
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

$("#addManufacturer").click(function () {
    var data = new FormData();
    var files = $("#mobileImage").get(0).files;

    if (files.length > 0) { data.append("UploadedImage", files[0]); }

    $.ajax({
        type: "POST",
        url: "/Phone/UploadImage",
        data: data,
        contentType: false,
        processData: false,
        success: function (data) { $("#PhotoURL").val(data.dbPath); },
        error: function () { alert("Error uploading image!"); }
    });
});