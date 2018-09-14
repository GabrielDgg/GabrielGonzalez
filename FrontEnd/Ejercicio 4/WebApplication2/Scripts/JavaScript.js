alert("HOLA");
var motos = [];
var BMW = new Object();
BMW.marca = "BMW";
BMW.modelo = [];
BMW.modelo.push("model1");
BMW.modelo.push("model2");
motos.push(BMW);

var honda = new Object();
honda.marca = "honda";
honda.modelo = [];
honda.modelo.push("model3");
honda.modelo.push("model4");
motos.push(honda);

var json = JSON.stringify(motos) ;


var enString = json;

var salida = "";

miObjato = JSON.parse(enString);
for (i in miObjato) {
    salida += "Marca=" + miObjato[i].marca + '\n';
    salida += "Modelo=" + miObjato[i].modelo + '\n';
}

alert(salida);
