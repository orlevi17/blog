
// jqHandleLayoutEvent.js

$(document).ready(function () {
    $("#menu ul li a").click(function () {
        $(this).parent().addClass("selected");
        //$(this).parent().siblings().removeClass("selected");
    });
});