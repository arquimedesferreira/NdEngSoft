class HomeController {

    constructor() {
        let $ = document.querySelector.bind(document);
        //this._inputData = $("#data");
        this._tabelaPessoas = $("#tabelaTodasPessoas");
        //Buscar todas as pessoas e montear a tabela;


        this._tabelaPessoasView = new TabelaPessoasView(this._tabelaPessoas);
        let pessoas = ConsultarService.buscarPessoas();
        this._tabelaPessoasView.update(pessoas);
    }

    buscarPessoas() {
        let pessoas = ConsultarService.buscarPessoas();
        this._tabelaPessoasView.update(pessoas);

        //console.log([].concat(pessoas));
    }
    //Ordenar por categoria
    ordenarPorCategoria(categoria) {
        //let pessoas = ConsultarService.buscarPessoas();

        //this._tabelaPessoasView.update(pessoas);
        //console.log(ConsultarService.buscarPessoas());
    }

    editarPessoa(event) {
        console.log(event);
        console.log("editando pessoa!");
    }

    deletandoPessoa(event) {
        console.log(event);
        console.log("editando pessoa!");
    }
}