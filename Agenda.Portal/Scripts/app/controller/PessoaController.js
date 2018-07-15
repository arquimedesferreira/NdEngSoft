class PessoaController {
    constructor() {
        let $ = document.querySelector.bind(document);
        this._inputData = $("#data");

        console.log("testando pessoa controller");
    }


    adicionarContato(event) {
        event.preventDefault();

        console.log("PessoaController.adicionaContato");
    }

    adicionarEndereco(event) {
        event.preventDefault();

        console.log("PessoaController.adicionarEndereço");
    }

    gravarSalvar() {
        console.log("Salvando pessoa!");
    }
}