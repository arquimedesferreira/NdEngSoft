class ListaPessoas {

    constructor() {
        this._listapessoas = [];
    }

    get pessoas() {
        return [].concat(this._listapessoas);
    }
    set adicionar(pessoa) {
        this._listapessoas.push(pessoa);
    }

    //Implementar uma forma de ordenar uma pessoa
    get pessoasOrdenarPor(marcador) {
        return [].concat(this._listapessoas);
    }
}