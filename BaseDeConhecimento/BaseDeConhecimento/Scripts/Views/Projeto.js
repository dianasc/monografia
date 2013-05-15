$(function () {
    Projeto.init();
});


function ScriptProjeto() {

    this.init = function () {
        $("#dataPrevistaInicio").datepicker({ dateFormat: "dd/mm/yy" });
        $("#dataPrevistaTermino").datepicker({ dateFormat: "dd/mm/yy" });
        $("#dataInicio").datepicker({ dateFormat: "dd/mm/yy" });
        $("#dataFim").datepicker({ dateFormat: "dd/mm/yy" });

        $("#btnAddAspecto").unbind("click").bind("click", function (event) {
            event.preventDefault();
            var htmlTbl, idAspecto = $("#selectAspectos option:selected").val(), descAspecto = $("#selectAspectos option:selected").text(),
                valorAspecto = $("#valorAtribuido").val().trim(), prioridade = $("#prioridade").val();

            console.log($("#prioridade").val());
            if (idAspecto === "" || valorAspecto === "") {
                alert("Informe os dados do aspecto para poder adicionar.");
                return false;
            } else {
                htmlTbl = "<tr><td><input type='hidden' name='hdIdAspecto[]' value='" + idAspecto + "'/><input type='hidden' name='hdTextAspecto[]' value='" + descAspecto + "'/>" +
                    "<input type='hidden' name='hdValorAspecto[]' value='" + valorAspecto + "'/><input type='hidden' name='hdPrioridade[]' value='" + prioridade + "'/></td>" +
                    "<td>" + descAspecto + "</td>" +
                    "<td>" + valorAspecto + "</td>" +
                    "<td>" + prioridade + "</td>" +
                    "<td><a onclick='Projeto.removeTr(this)'>Remover</a></td></tr>";
                
                $("#selectAspectos").find('option:selected').removeAttr("selected");
                $("#valorAspecto").val("");
                $("#tblAspectos tbody").append(htmlTbl);
            }
        });

    }

    this.removeTr = function (obj) {
        $(obj).parent().parent().remove();
    }
}

var Projeto = new ScriptProjeto();