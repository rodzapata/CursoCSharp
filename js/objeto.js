class Comida{
    static contador=0;

    constructor(id,nombre,color){
        this.id=id ;
        this.nombre=nombre ;
        this.color=color ;
        this.numero=++Comida.contador;
    }
    nombrar(){
        return `el objeto ${this.nombre} es de color ${this.color}`;
    }
    get numeroCreacion(){
        return this.numero;
    }

}

class Galleta extends Comida{
    constructor(id,nombre,color,sabor){
        super(id,nombre,color);
        this.sabor=sabor;

    }
    nombrarGalleta(){
        return `la galleta de nombre ${this.nombre} es de color ${this.color}`
    }
}
manzana = new Comida(1,"manzana","rojo");
console.log(manzana.numeroCreacion);
console.log(manzana);
console.log(manzana.nombrar());


pera = new Comida(2,"pera","verde");
console.log(pera.numeroCreacion);
console.log(pera);

croqueta= new Galleta(3,"Galleta croqueta","marron","chocolate")
console.log(croqueta.numeroCreacion);
console.log(croqueta);
console.log(croqueta.nombrarGalleta());