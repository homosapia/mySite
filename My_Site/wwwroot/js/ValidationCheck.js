function ValidationCheck() {
    function ValidationCheck() {
        let input = document.getElementById("input_User").value;

        if (input >= 10 && input <= 99) {
            console.log("правильно");
        } else {
            document.getElementById("span").innerHTML = "Не правелиный ввод";
        }
    }
}