$(document).ready(function () {
    $(window).on("scroll", function () {
        let navbar = $(".navbar");
        if ($(window).scrollTop() >= 150) {
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

    $(window).on("scroll", function () {
        let sidebar = $("#sidebar-wrapper");
        if ($(window).scrollTop() >= 60) {
            sidebar.addClass("scroll");
        } else {
            sidebar.removeClass("scroll");
        }
    });



    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
        $('.content').toggleClass('active');
    });


    $(function () {
        $('[data-admin-menu]').hover(function () {
            $('[data-admin-menu]').toggleClass('open');
        });
    });

    $('#follow').click(function () {
        if ($('#follow_icon').hasClass("fa-plus")) {
            $('#follow_icon').addClass("fa-minus");
            $('#follow_icon').removeClass("fa-plus");
        } else {
            $('#follow_icon').removeClass("fa-minus");
            $('#follow_icon').addClass("fa-plus");
        }

    });
});
