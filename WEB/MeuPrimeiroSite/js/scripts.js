$(document).ready(
    /*funcao dentro do nosso document ready*/
    function () {
      
        $('input[type="button"]').click(
            
            function () {
                
                var nome = $('input[name="nome"]').val();
                alert("bem vindo " + nome);

               
                }
            );

    }
);