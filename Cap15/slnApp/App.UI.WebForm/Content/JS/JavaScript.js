debugger;

var numero = 15;
var cadena = "Hola Javascript";
var booleanTrue = true;
var booleanFalse = false;
var date = new Date();
var date2 = new Date(2017, 1, 15, 23, 30, 30);
var alumno = {
    Nombre: "Juan",
    Apellidos: "Díaz",
    FechaNacimiento: "1980/05/04",
    GenerarNombreCompleto: function (genero) {
        var fullName = this.Nombre + " " + this.Apellidos;

        if (genero = "M") {
            fullName = "Señor: " + fullName;
        }
        else {
            fullName = "Señora: " + fullName;
        }

        return fullName;
    }
};

//arreglo
var clase = [];
//agregando elementos a un arreglo
clase.push(alumno);
clase.push(
    {
        Nombre: "Pedro",
        Apellidos: "Ruiz",
        Edad: 35
    }
);

function MostrarAlumno() { 
    debugger;
    //Mostrar mensaje
    alert("Es el alumno: "
        + alumno.GenerarNombreCompleto());
}

function MostrarAlumnos() {
    //Implementando una estructura condicional repetitiva
    for (var i = 0; i < clase.length; i++) {
        alert("Es el alumno: "
            + alumno[i].GenerarNombreCompleto());
    }
}