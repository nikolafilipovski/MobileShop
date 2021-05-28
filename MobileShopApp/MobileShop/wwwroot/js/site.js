$("#ajax").click(function () {
    var data = {
        ManufacturerID: $("#ManufacturerID"),
        ManufacturerName: $("#ManufacturerName"),
    };

    $.ajax({
        url: '/Phone/Create',
        type: 'POST',
        data: data,
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $("#ManufacturerID").val();
            $("#ManufacturerName").val();
        },
        error: function () {
            alert("error");
        }
    });
});



