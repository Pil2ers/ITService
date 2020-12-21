function TestDataTablesAdd(table, Url) {
    Application.LoadWait(true);
    $(document).ready(function () {
        $(table).DataTable({
            "processing": true,
            "serverSide": false,
            "bAutoWidth": false,
            "ajax": {
                "url": Url,
                "type": "GET",
                "dataSrc": ""
            },
            "columns": [
                { 'data': "equipmenT_RECORD", sClass: "text-center" },
                { 'data': "equipmenT_ID", sClass: "text-center" },
                { 'data': "emP_LASTNAMETH", sClass: "text-center" },
                { 'data': "emP_MAIL", sClass: "text-center" },
                { 'data': "emP_DEPT", sClass: "text-center" },
                {
                    'data': 'activate',
                    'orderable': false,
                    "className": "text-center",
                    'render': function (ID, type, data, obj) {
                        if (data.activate != "1") {
                            return '<input id="toggle-demo" class="my_switch" type="checkbox" data-toggle="toggle" data-on="เปิดใช้งาน" data-off="ปิดใช้งาน" data-onstyle="success" data-offstyle="danger" onchange="ActivateStatus(' + data.emP_ID + ',' + data.activate + ');" >';

                        }
                        else {
                            return '<input id="toggle-demo" class="my_switch" type="checkbox" data-toggle="toggle" data-on="เปิดใช้งาน" data-off="ปิดใช้งาน" data-onstyle="success" data-offstyle="danger" onchange="ActivateStatus(' + data.emP_ID + ',' + data.activate + ');"   checked >';
                        }


                    }
                } 
                
        });

    });
    Application.LoadWait(false);
}