export default function VariablesEjemplo(){
    let apellido = 'Barrera';
    apellido = 'Tapia';
    let edad = 999;
    let fecha = new Date();

    let persona = {
        nombre : 'Felipe',
        apellido:"Gomez",
        edad:999,
        fechaActual : new Date(),
        estaLogueado : true
    };

    let miFuncion = function duplicar(valor){return valor*2};
}