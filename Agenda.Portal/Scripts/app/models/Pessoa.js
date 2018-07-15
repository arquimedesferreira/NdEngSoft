class Pessoa {
    constructor(name) {
        this._name = name;
        this._contacts = [];
        this._adresses = [];
        console.log("testando entidade Pessoa");
    }


    get name() {
        return this._name;
    }

    set name(name) {
        this._name = name;
    }

    get contacts() {
        return [].concat(this._contacts);
    }

    set contact(contact) {
        this._contacts.push(contact);
    }

    get adresses() {
        return [].concat(this._contacts);
    }

    set setAdress(adress) {
        this._adresses.push(adress);
    }
}