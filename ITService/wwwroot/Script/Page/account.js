
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
                { 'data': "emP_ID", sClass: "text-center" },
                { 'data': "emP_NAMETH", sClass: "text-center" },
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
                },
                {
                    'data': 'ID',
                    'orderable': false,
                    "className": "text-center",
                    sWidth: "5%",
                    'mRender': function (ID, type, data, obj) {
                        if (data.activate != "1") {
                            return '<a class="btn btn-danger btn-xs" data-toggle="tooltip" title="จัดการข้อมูล">จัดการข้อมูล</a>';

                        }
                        else {
                            return '<a class="btn btn-primary btn-xs" data-toggle="tooltip" onclick="OpenModalDetailAccount(' + data.emP_ID + ')" title="จัดการข้อมูล">จัดการข้อมูล</a>';
                        }
                    }
                }

            ],
            "fnDrawCallback": function () {
                $('.my_switch').bootstrapToggle();

            },

        });

            });
            Application.LoadWait(false);
        }

        function TestDataTablesRemove(table) {
        $(document).ready(function () {
            $(table).DataTable().destroy();
            var elEM = document.querySelector(table + '_wrapper');
            elEM.parentNode.removeChild(elEM);
        });
        }

        function UpdatedetailUserAccount() {
            var emP_ID = $('#emP_ID').text();
            var nameTH = $('#nameTH').val();
            var lastTH = $('#lastTH').val();
            var namEn = $('#namEn').val();
            var lastEn = $('#lastEn').val();
            var nicknameTH = $('#nicknameTH').val();
            var nicknameEn = $('#nicknameEn').val();
            var telephone = $('#telephone').val();
            var position = $('#position').val();

            var Updatevalue = {
        emP_ID: emP_ID,
                emP_NAME: namEn,
                emP_LASTNAME: lastEn,
                emP_NICKNAME: nicknameEn,
                emP_NAMETH: nameTH,
                emP_LASTNAMETH: lastTH,
                emP_NICKNAMETH: nicknameTH,
                emP_TEL: telephone,
                emP_DEPT: position,
            };

            $.ajax({
        url: 'http://localhost:4000/api/UserAccount/UpdateDetialUserAccount',
                type: 'POST',
                contentType: "application/json",
                data: JSON.stringify(Updatevalue),
                dataType: "json",
                beforeSend: function () {
        //Application.LoadWait(true);
    },
                async: true,
                success: function (data) {
        //Application.LoadWait(false);
        console.log(data.status);
                    CloseElement();
                }
            });
        };

        function ActivateStatus(id, activestatus) {

            if (activestatus == "1") {
                var ActiveStatus = {
        emP_ID: id,
                    activate: "2",
                };
                $.ajax({
        url: 'http://localhost:4000/api/UserAccount/ActiveStatus',
                    type: 'PUT',
                    contentType: "application/json",
                    data: JSON.stringify(ActiveStatus),
                    dataType: "json",
                    async: true,
                    success: function () {
                        var mytbl = $("#example").DataTable();
                        mytbl.ajax.reload(null, false);
                        console.log("success");
                    }
                });
            }
            if (activestatus == "2") {
                var ActiveStatus = {
        emP_ID: id,
                    activate: "1",
                };
                $.ajax({
        url: 'http://localhost:4000/api/UserAccount/ActiveStatus',
                    type: 'PUT',
                    contentType: "application/json",
                    data: JSON.stringify(ActiveStatus),
                    dataType: "json",
                    async: true,
                    success: function () {

                        var mytbl = $("#example").DataTable();
                        mytbl.ajax.reload(null, false);
                        console.log("success");


                    }
                });
            }
        }

        function OpenModalDetailAccount(id) {
            var callidem = {emP_ID: id };
            $('#ViewHistory').modal('show');
            $.ajax({
        url: 'http://localhost:4000/api/UserAccount/GetUserAccountId',
                type: 'POST',
                contentType: "application/json",
                data: JSON.stringify(callidem),
                dataType: "json",
                async: true,
                success: function (result) {
        $("#emP_ID").html(result[0]["emP_ID"]);
                    $("#nameTH").val(result[0]["emP_NAMETH"]);
                    $("#lastTH").val(result[0]["emP_LASTNAMETH"]);
                    $("#namEn").val(result[0]["emP_NAME"]);
                    $("#lastEn").val(result[0]["emP_LASTNAME"]);
                    $("#nicknameTH").val(result[0]["emP_NICKNAMETH"]);
                    $("#nicknameEn").val(result[0]["emP_NICKNAME"]);
                    $("#telephone").val(result[0]["emP_TEL"]);
                    $("#email").val(result[0]["emP_MAIL"]);
                    $("#position").val(result[0]["emP_DEPT"]);


                },
                error: function (status) {
        alert("error");
                },

            });
        };

        function OpenElement() {
        document.getElementById('updateimg').style.visibility = 'visible';
            $("#nameTH").prop('disabled', false);
            $("#lastTH").prop('disabled', false);
            $("#namEn").prop('disabled', false);
            $("#lastEn").prop('disabled', false);
            $("#nicknameTH").prop('disabled', false);
            $("#nicknameEn").prop('disabled', false);
            $("#telephone").prop('disabled', false);
            $("#position").prop('disabled', false);
        };

        function CloseElement() {
        document.getElementById('updateimg').style.visibility = 'hidden';
            $("#nameTH").prop('disabled', true);
            $("#lastTH").prop('disabled', true);
            $("#namEn").prop('disabled', true);
            $("#lastEn").prop('disabled', true);
            $("#nicknameTH").prop('disabled', true);
            $("#nicknameEn").prop('disabled', true);
            $("#telephone").prop('disabled', true);
            $("#position").prop('disabled', true);
        }
