var result = document.getElementById("result").value
var resultado = document.getElementById("resultado")
var porcent = document.getElementById("porcent").value
var porcentaje = document.getElementById("porcentaje")
var file = document.getElementById("upload-photo").value
var error = document.getElementById("comprobadorF")
var aceptado = document.getElementById("comprobadorT")


function comprobar() {
    if (file != '') {
        error.className = "visible"
        aceptado.className = "oculto"
    } else {
        aceptado.className = "visible"
        error.className = "oculto"
    }
}

document.getElementById('upload-photo').onchange = function () {
    comprobar()
};

resultado.innerHTML = result;
porcentaje.innerHTML = porcent;
