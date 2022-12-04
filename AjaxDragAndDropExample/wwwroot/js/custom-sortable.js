$(function () {

    $("#sortable-1").sortable({
        connectWith: "#sortable-3,#sortable-2,#sortable-1",
        placeholder: "highlight"
    });
    $("#sortable-2").sortable({
        connectWith: "#sortable-1,#sortable-2,#sortable-3",
        placeholder: "highlight"

    });
    $("#sortable-3").sortable({
        connectWith: "#sortable-1,#sortable-2,#sortable-3",
        placeholder: "highlight"
    });

 

    //$("#sortable-1").sortable({
    //    connectWith: "#sortable-1",
    //  //  handle: ".card-header",
    //  //  cancel: ".card-toggle",
    //    //placeholder: "card-placeholder ui-corner-all"
    //});

    //$(".card")
    //    .addClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all")
    //    .find(".list-group-item")
    //    .addClass("ui-widget-header ui-corner-all")


    //$(".list-group").sortable({
    //    connectWith: ".list-group",
    //    activeClass: "active",
    //    //handle: ".card-header",
    //    //cancel: ".card-toggle",
    //    //placeholder: "card-placeholder ui-corner-all"
    //});

    //$(".list-group-item")
    //    .addClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all")
    //    .find(".list-group-item")
    //    .addClass("ui-widget-header ui-corner-all")


    //$(".card-toggle").click(function () {
    //    var icon = $(this);
    //    icon.toggleClass("ui-icon-minusthick ui-icon-plusthick");
    //    icon.closest(".card").find(".card-body").toggle();
    //});
});