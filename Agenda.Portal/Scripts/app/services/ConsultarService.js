class ConsultarService {
    constructor() {
        throw new Error('Você não pode criar uma instância dessa classe');
    }

    static buscarPessoas() {
        //var endereco = `${this._enderecoBase}/api/v0/todosacessos/por/dia/nomes/${mes}/noano/${ano}`;
        var endereco = `http://localhost:8283/api/v0/pessoa/`;
        console.log(endereco);
        let xhr = new XMLHttpRequest();
        xhr.open("GET", endereco,false);
        var pessoas = [];

        xhr.addEventListener("loadend", () => {
            if (xhr.status == 200) {
                var resposta = xhr.responseText;
                //console.log(typeof resposta);
                pessoas = JSON.parse(resposta);
                //console.log(resposta);
                //função do arquivo confLinha.js
                //atualizarGraficoLinha(pessoas);
                //console.log("API Respondendo OK!");

                //CarregaGrafico.deAcessosPorEmpresaEmBarraCom(acessos);
            } else {
                //erroAjax.classList.remove("invisivel");
                console.log("Algo de errado aconteceu não foi possível carregar o gráfico!");
                //return acessos;
            }
        });
        xhr.send();



        return pessoas;
    }
}