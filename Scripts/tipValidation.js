var total = document.getElementById("total").value;
var percent;
var calculate = document.getElementById("calculate")
var minTotal = 0.01;

calculate.onclick = validateTotal(total);

function validateTotal(a) {
    if (a > 0.00) {
        return a;
    }
    else {
        alert("Invalid bill total.");
    }
}

var slider = document.getElementById("slider");
var output = document.getElementById("value");

output.innerHTML = slider.value;

slider.oninput = function () {
    output.innerHTML = this.value;
}