const jqueryValidate = require("../jquery-validate/jquery.validate");

$(function () {
    $("form[name='phoneCreate']").validate({
        success: "valid",
        onkeyup: true, // validation as we type the data
        focusInvalid: true, // field when invalid
    }),

    rules: {
        Model: {
            required: true,
            minlength: 6
        },
        Price: {
            required: true,
            minlength: 3
        },
        Display: {
            required: true,
            minlength: 6
        },
        Memory: {
            required: true,
            minlength: 6
        },
        Battery: {
            required: true,
            minlength: 6
        },
        Manufacturer: {
            required: true
        }
    },

    messages: {
        Model: {
            required: "Phone model is required!",
            minlength: jqueryValidate.format("At least {0} characters are required!")
        },
        Price: {
            required: "Phone price is required!",
            minlength: jqueryValidate.format("At least {0} characters are required!")
        },
        Display: {
            required: "Display type is required!",
            minlength: jqueryValidate.format("At least {0} characters are required!")
        },
        Memory: {
            required: "Phone memory is required!",
            minlength: jqueryValidate.format("At least {0} characters are required!")
        },
        Battery: {
            required: "Phone battery is required!",
            minlength: jqueryValidate.format("At least {0} characters are required!")
        },
        Manufacturer: {
            required: "Please select a manufacturer!"
        }
    }
    submitHandler: function (form) {
        form.submit();
    }
});

