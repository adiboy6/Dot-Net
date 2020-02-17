$(document).ready(function () {
    $("#SubmitButton").click(function () {
        if ($("#FirstNameTextBox").val() == "" && $("#LastNameTextBox").val() == "" && $("#PhoneNumberTextBox").val() == "" && $("#EMailTextBox").val() == ""
            && $("#GenderRadioButtonList :radio:checked").length == 0 && $("#CountryDropDownList").val() == "--Select Country--" && $("#StreamCheckBoxList :checkbox:checked").length == 0
        ) {
            alert("JQ : Please enter in the required fields");
            return false;
        }

        if ($("#FirstNameTextBox").val() == "") {
            alert("JQ : Please enter your First Name");
            return false;
        }

        if ($("#LastNameTextBox").val() == "") {
            alert("JQ : Please enter your Last Name");
            return false;
        }

        if ($("#GenderRadioButtonList :radio:checked").length == 0) {
            alert("JQ : Please select your gender");
            return false;
        }

        if ($("#CountryDropDownList").val() == "--Select Country--") {
            alert("JQ : Please select your Country");
            return false;
        }

        if ($("#CountryDropDownList").val() != "--Select Country--") {
            if ($("#StateDropDownList").val() == "--Select State--") {
                alert("JQ : Please select your State");
                return false;
            }
            else {
                if ($("#CityDropDownList").val() == "--Select City--") {
                    alert("JQ : Please select your City");
                    return false;
                }
            }
        }


        if ($("#StreamCheckBoxList :checkbox:checked").length == 0) {
            alert("JQ : Please select your stream");
            return false;
        }

        if ($("#PhoneNumberTextBox").val() == "") {
            alert("JQ : Please enter your Phone Number");
            return false;
        }

        if ($("#EMailTextBox").val() == "") {
            alert("JQ : Please enter your E-Mail");
            return false;
        }

        return true;
    }
    );
}
);