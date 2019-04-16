$(document).ready(function () {
    $(window).on("scroll", function () {
        let navbar = $(".navbar");
        if ($(window).scrollTop() >= 60) {
            if (navbar.hasClass("py-5")) {
                navbar.removeClass("py-5");
                navbar.addClass("compressed");
            }
        } else {
            if (navbar.hasClass("compressed")) {
                navbar.addClass("py-5");
                navbar.removeClass("compressed");
            }
        }
    });

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
        $('.content').toggleClass('active');
    });


    if ($('.sidebar').hasClass('.active')) {
    }
});
