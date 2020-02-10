function validateUser()
{
    var FirstName = document.getElementById("FirstNameTextBox").value;
    var LastName = document.getElementById("LastNameTextBox").value;
    var PhoneNumber = document.getElementById("PhoneNumberTextBox").value;
    var EMail = document.getElementById("EMailTextBox").value;
    var Gender = document.getElementById("GenderRadioButtonList").value;
    var Stream = document.getElementById("StreamCheckBoxList").value;

    if (FirstName == '' && LastName == '' && PhoneNumber == '' && EMail == '') {
        alert("Enter All Fields!");
        return false;
    }
    if (FirstName == '') {
        alert("Please enter your First Name");
        return false;
    }
    if (LastName == '') {
        alert("Please enter your Last Name");
        return false;
    }
    //validation whther the field is empty or not
    if (PhoneNumber == '') {
        alert("Please enter your Phone Number");
        return false;
    }

    if (PhoneNumber != '') {
        
    }

    if (EMail == '') {
        alert("Please enter your E-Mail");
        return false;
    }
}