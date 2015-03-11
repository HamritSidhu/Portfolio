var home = {
    init: function () {
        typeText = $(".element");
        navbar = $(".navbar");
        footer = $("footer");
        homeBackground = $(".home-background");
        welcome = document.getElementById("welcome");

        this.typeIntro();
        this.windowResize();
        this.setHeight();
    },

    typeIntro: function () {
        var i = 1;
        typeText.typed({
            strings: ["Hey there!", "Nice to meet you.", "I'm Hamrit."],
            typeSpeed: 40,
            showCursor: false,
            onStringTyped: function () {
                if (i == this.strings.length) {
                    welcome.innerHTML = "Welcome to my website.<br> Take a look around."
                    $("#welcome").fadeIn('slow');
                }
                i++; 
            }
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
