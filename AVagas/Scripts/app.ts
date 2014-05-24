module AVagas {
    export class Vaga {
        constructor(public Descricao: KnockoutObservable<string>,
            public Dispinibilidade: KnockoutObservable<boolean>,
            public Endereco: KnockoutObservable<string>,
            public Foto: KnockoutObservable<string>) {

        }
    }

    export class IndexViewModel {

        vagas: KnockoutObservableArray<Vaga> = ko.observableArray<Vaga>();

        constructor(urlVagas: string) {
            var instance = this;
            navigator.geolocation.getCurrentPosition(p => {
                urlVagas = urlVagas + '/Perto/'+p.coords.latitude+'/'+ p.coords.longitude +'/'
                $.get(urlVagas, (data) => {
                    data.forEach(vaga => {
                        instance.vagas.push(new
                            Vaga(
                            ko.observable(vaga.Descricao),
                            ko.observable(vaga.Dispinibilidade),
                            ko.observable(vaga.Endereco),
                            ko.observable(vaga.Foto)));
                    });
                });
            });
            
        }
        
    }

}

$(document).ready(() => {
    var viewModel = new AVagas.IndexViewModel($('#urlVagas').val());
    ko.applyBindings(viewModel, document.getElementById('container'));
});