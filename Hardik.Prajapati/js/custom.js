
    $(window).on("scroll", function() {
        if($(window).scrollTop() > 70) {
            $("nav").addClass("fxnavscroll");
        } else {
            //remove the background property so it comes transparent again (defined in your css)
           $("nav").removeClass("fxnavscroll");
        }
    });
