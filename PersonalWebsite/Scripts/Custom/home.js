var home = {
    init: function () {
        typeText = $(".element");
        navbar = $(".navbar");
        footer = $("footer");
        homeBackground = $(".home-background");

        this.typeIntro();
        this.windowResize();
        this.setHeight();
    },

    typeIntro: function () {
        typeText.typed({
            strings: ["Hey there!", "Nice to meet you.", "I'm Hamrit."],
            typeSpeed: 40,
            showCursor: false
        })

    },

    windowResize: function () {
        $(window).on("resize", function () {
            home.setHeight();
        });
    },

    setHeight: function () {
        var top = navbar.outerHeight();
        var bottom = footer.outerHeight();
        homeBackground.css({
            'height': $(window).height() - top - bottom + 'px'
        });

    }
}

home.init();
