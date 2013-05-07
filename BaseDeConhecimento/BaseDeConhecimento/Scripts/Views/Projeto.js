$(function () {
    Projeto.init();
});


function ScriptProjeto() {
    
    this.init = function () {
        $("#dataPrevistaInicio").datepicker({ dateFormat: "dd/mm/yy" });
        $("#dataPrevistaTermino").datepicker({ dateFormat: "dd/mm/yy" });
        $("#dataInicio").datepicker({ dateFormat: "dd/mm/yy" });
        $("#dataFim").datepicker({ dateFormat: "dd/mm/yy" });
    }
}

var Projeto = new ScriptProjeto();