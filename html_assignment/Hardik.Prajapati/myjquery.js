$(document).ready(function() {
    $(".btn-primary").hover(function() {
        $('#exampleModalCenter').modal({
            show: true
        });
    });

    $("div.card").click(function() {
        $(this).find("div").toggle();
    });
});