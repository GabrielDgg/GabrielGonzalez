var json =
{
    "moto":
        [
            {
                "marca": " BMW",
                "modelo":
                    [
                        { "nombre": "C Evolution 11kw" },
                        { "nombre": "HP4 RACE" }
                    ]
            },
            {
                "marca": "E-VOLT",
                "modelo":
                    [
                        { "nombre": " Style" },
                        { "nombre": "Wind " }
                    ]

            },
            {
                "marca": "Energica",
                "modelo":
                    [
                        { "nombre": "Ego" },
                        { "nombre": "Eva" }
                    ]

            }

        ]
};

var d = '<ul>';



$(function () {
   
    for (var i = 0; i < json.moto.length; i++) {
        
       
        d += '<li>' + 'Marca: ' + json.moto[i].marca;
        
        for (var j = 0; j < json.moto[i].modelo.length; j++) {
            
            d += '<ul><li>' + 'Modelo: '+ json.moto[i].modelo[j].nombre + '</li></ul>';
        }
       
        d += '</li>';
        
    }
    d += '</ul>';
 
    $("#lista").append(d);
});