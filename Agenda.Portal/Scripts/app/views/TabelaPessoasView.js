class TabelaPessoasView {

    constructor(elemento) {
        this._elemento = elemento;
    }


    template(dados) {

        return `
    <table class="table table-hover table-bordered">
    <thead>
        <tr>
            <th>NOME</th>
            <th>MARCADOR</th>
            <th>AÇÃO</th>
        </tr>
    </thead>

    <tbody>
            ${dados.map(p => {
            return `
                 <tr>
                    <th>${p.Name.FisrtName}</th>
                    <th>${p.Contacts[0].Marker.Name}</th>
                    <th>
                        <button type="button" class="btn btn-success" onclick="homeControle.editarPessoa(event)"> <span itenId="${p.Id}" class="glyphicon glyphicon-pencil" aria-hidden="true"></span></button>
                        ----
                        <button type="button" class="btn btn-danger" onclick="homeControle.editarPessoa(event)"> <span class="glyphicon glyphicon-remove" aria-hidden="true"></span></button>
                    </th>
                </tr>
            `
            }).join('')}
                
                
           
            
        </tbody>

        <tfoot>
       
        </tfoot>
    </table>`;
    }


    update(dados=[]) {
         this._elemento.innerHTML = this.template(dados);
        //console.log(dados);
               
        //dados.forEach(function(iten) {
        //    console.log(iten);
        //    });
        
    }
}