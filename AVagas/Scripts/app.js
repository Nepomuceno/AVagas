var AVagas;
(function (AVagas) {
    var Vaga = (function () {
        function Vaga(Descricao, Dispinibilidade, Endereco, Foto) {
            this.Descricao = Descricao;
            this.Dispinibilidade = Dispinibilidade;
            this.Endereco = Endereco;
            this.Foto = Foto;
        }
        return Vaga;
    })();
    AVagas.Vaga = Vaga;

    var IndexViewModel = (function () {
        function IndexViewModel(urlVagas) {
            this.vagas = ko.observableArray();
            var instance = this;
            navigator.geolocation.getCurrentPosition(function (p) {
                urlVagas = urlVagas + '/Perto/' + p.coords.latitude + '/' + p.coords.longitude + '/';
                $.get(urlVagas, function (data) {
                    data.forEach(function (vaga) {
                        instance.vagas.push(new Vaga(ko.observable(vaga.Descricao), ko.observable(vaga.Dispinibilidade), ko.observable(vaga.Endereco), ko.observable(vaga.Foto)));
                    });
                });
            });
        }
        return IndexViewModel;
    })();
    AVagas.IndexViewModel = IndexViewModel;
})(AVagas || (AVagas = {}));

$(document).ready(function () {
    var viewModel = new AVagas.IndexViewModel($('#urlVagas').val());
    ko.applyBindings(viewModel, document.getElementById('container'));
});
//# sourceMappingURL=app.js.map
