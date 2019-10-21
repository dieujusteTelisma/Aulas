$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                $.get("https://viacep.com.br/ws/38402100/json/", function (data) {
                    $('input[name="cep"]').val(data.cep);
                    $('input[name="bairro"]').val(data.bairro);
                    $('input[name="logradouro"]').val(data.logradouro);
                    $('input[name="localidade"]').val(data.localidade);
                    $('input[name="uf"]').val(data.uf);
                    $('input[name="ibge"]').val(data.ibge);
                   
                    
                });
            }
        );
    }
);