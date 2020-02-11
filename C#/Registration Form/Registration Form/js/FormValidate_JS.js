function validateUser()
{
    //Form fields
    var FirstName = document.getElementById("FirstNameTextBox").value;
    var LastName = document.getElementById("LastNameTextBox").value;
    var PhoneNumber = document.getElementById("PhoneNumberTextBox").value;
    var EMail = document.getElementById("EMailTextBox").value;

    //Regular Expressions
    var phone_number_exp = "^(\\+91)?[\\d]{10}$";
    var email_address_exp = "^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$";

    //Gender-Radio Button List
    var Gender = document.getElementById("GenderRadioButtonList");
    var radio = Gender.getElementsByTagName("input");
    var gender_isChecked = false;
    for (var i = 0; i < radio.length; i++) {
        if (radio[i].checked) {
            gender_isChecked = true;
            break;
        }
    }

    //Stream-Check Box list
    var Stream = document.getElementById("StreamCheckBoxList");
    var checkbox = Stream.getElementsByTagName("input");
    var stream_isChecked = false;
    for (var i = 0; i < radio.length; i++) {
        if (checkbox[i].checked) {
            stream_isChecked = true;
            break;
        }
    }

    //Place- DropDownList
    var Country_DropDownList = document.getElementById("CountryDropDownList");
    var State_DropDownList = document.getElementById("StateDropDownList");
    var City_DropDownList = document.getElementById("CityDropDownList");

    if (FirstName == "" && LastName == "" && PhoneNumber == "" && EMail == "" && !gender_isChecked && !stream_isChecked && Country_DropDownList.value == "--Select Country--") {
        alert("Enter All Fields!");
        return false;
    }

    if (FirstName == "") {
        alert("Please enter your First Name");
        return false;
    }

    if (LastName == "") {
        alert("Please enter your Last Name");
        return false;
    }

    if (!gender_isChecked) {
        alert("Please select your gender");
        return false;
    }

    //DoB - Calendar
    var dob = document.getElementById("DOBCalendar").value;
    if (dob == null || dob == Date.now()) {
        alert("Invalid Date of Birth");
        return false;
    }

    //Country-DropDownList
    if (Country_DropDownList.value == "--Select Country--") {
        alert("Please select your Country");
        return false;
    }

    //State-DropDownList
    if (Country_DropDownList.value != "--Select Country--") {
        if (State_DropDownList.value == "--Select State--") {
            alert("Please select your State");
            return false;
        }
        else {
            //City-DropDownList
            if (City_DropDownList.value == "--Select City--") {
                alert("Please select your City");
                return false;
            }
        }
    }

    if (!stream_isChecked) {
        alert("Please select any stream");
        return false;
    }

    //validation whther the field is empty or not
    if (PhoneNumber == "") {
        alert("Please enter your Phone Number");
        return false;
    }

    if (PhoneNumber != "") {
        if (!PhoneNumber.match(phone_number_exp)) {
            alert("Invalid Phone Number");
            return false;
        }
    }

    if (EMail == "") {
        alert("Please enter your E-Mail");
        return false;
    }
    if (EMail != "") {
        if (!EMail.match(email_address_exp)) {
            alert("Invalid E-Mail ID.");
            return false;
        }
    }
    return true;
}