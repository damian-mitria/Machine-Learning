var valor = document.getElementById("valor").value;
var resultado = document.getElementById("resultado");



resultado.innerHTML = valor;
if (valor == 'Positivo') {
    resultado.className = "positivo"
} else {
    resultado.className = "negativo"
}