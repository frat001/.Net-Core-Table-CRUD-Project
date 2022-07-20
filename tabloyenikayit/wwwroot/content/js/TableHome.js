$(document).ready(function () {
    $('#myTable').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.12.1/i18n/tr.json"
        }
        });

    var myTable = document.getElementById("myTable"), sumMaas = 0;

    for (var i = 1; i < myTable.rows.length; i++) {
        sumMaas = sumMaas + parseInt(myTable.rows[i].cells[2].innerHTML);
    }
    document.getElementById("Maas").innerHTML = "Sum Maas = " + sumMaas;

});

