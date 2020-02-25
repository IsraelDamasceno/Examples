function ola() {
    if (!isFalse)
        alert("estou funcionando");
}
function validateNumber(value) {
    //Valida o número
    if (!isNumber(value))
        alert("Entre o numero.");
}

function validateZipCode(value) {
    // Valide o código postal
    if (!isZipCode(value))
        alert("Entre o Cep no formulario XXXX.");
}

function calcPrice() {
    var maxPreco = document.getElementById("income").value * 4;
    alert("Você pode comprar uma casa até S" + maxPreco + ".");
}

function findhouses(form) {
    var quartos = document.getElementById("quartos").value;
    var zipCode = document.getElementById("zip").value;
    // exiba uma lista de casas coincidentes a partir do servidor

    form.submit();
}

