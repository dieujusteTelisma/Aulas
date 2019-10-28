// JavaScript source code

$(document).ready(
    /*funcao dentro do nosso document ready*/
    function () {
        $('.dinheiro').mask('#.###0,00', { reverse: true });
        $('input[type="button"]').click(
            function funcao() {
                /*obtemos a idade*/
                var dinheiro = $('input[name="dinheiro"]').val();

                var resultado = dinheiro / 4.24;

                $('input[name="value"]').val(resultado);
                /* obtemos o nome da pessoa*/

            })
    }
);

