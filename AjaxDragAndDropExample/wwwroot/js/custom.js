//https://okandavut.medium.com/jquery-ui-drag-drop-kullan%C4%B1m%C4%B1-c3376a4fc5b
$('#ListCustomers tr').css({ 'z-index': 100 }).draggable({
    'opacity': '0.5',
    'revert': true,
    'cursor': 'pointer',
});

$('.card').droppable({
    drop: function (event, ui) {
        $(this).css('background', 'green');
        console.log('yerleşti:yeşil');

        var customerId = ui.draggable.find(".customerId").val();
        console.log("customerId:" + customerId);

        var roomId = $(this).data('value');
        console.log('roomId:' + roomId);
        ui.draggable.remove();

        $.ajax({
            type: 'POST',
            url: '/CustomerRoom/Add',
            data: { customerId: customerId, roomId: roomId },
            success: function (data) {
                alert(data);
                location.reload();
            }
        });
    },
    over: function (event, ui) {
        $(this).css('background', 'yellow');
        console.log('üzerinde:sarı');
    },
    out: function (event, ui) {
        $(this).css('background', 'red');
        console.log('dışarıda:kırmızı');
    }
});