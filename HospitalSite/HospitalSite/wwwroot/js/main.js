


/** ===============


02. header_search
04. Fixed-header
05. Menu
06. Number rotator
07. Skillbar
08. Tab
09. Accordion
10. Isotope
11. Prettyphoto
12. Slick_slider
13. Back to top 

 =============== */


(function ($) {

    'use strict'




    /*------------------------------------------------------------------------------*/
    /* header_search
    /*------------------------------------------------------------------------------*/

    $(".header_search").each(function () {
        $(".search_btn", this).on("click", function (e) {

            e.preventDefault();
            e.stopPropagation();

            $(".header_search_content").toggleClass("on");

            if ($('.header_search a').hasClass('open')) {

                $(".header_search a i").removeClass('ti-close').addClass('ti-search');

                $(this).removeClass('open').addClass('sclose');

            }

            else {
                $(".header_search a").removeClass('sclose').addClass('open');

                $(".header_search a i").removeClass('ti-search').addClass('ti-close');

            }
        });

    });


    $(function () {

        // appointment form animations
        $('.header_btn > a').on('click', function (event) {
            event.preventDefault();
            $('#appointment').fadeToggle();
        })
        $(this).mouseup(function (e) {


            var container = $("#appointment");

            if (!container.is(e.target) 
                && container.has(e.target).length === 0) 
            {
                container.fadeOut();
            }
        });

    });



 


    /*------------------------------------------------------------------------------*/
    /* Fixed-header
    /*------------------------------------------------------------------------------*/

    $(window).scroll(function () {
        if (matchMedia('only screen and (min-width: 1200px)').matches) {
            if ($(window).scrollTop() >= 50) {

                $('.ttm-stickable-header').addClass('fixed-header');
            }
            else {

                $('.ttm-stickable-header').removeClass('fixed-header');
            }
        }
    });



    /*------------------------------------------------------------------------------*/
    /* Menu
    /*------------------------------------------------------------------------------*/

    var menu = {
        initialize: function () {
            this.Menuhover();
        },

        Menuhover: function () {
            var getNav = $("nav.main-menu"),
                getWindow = $(window).width(),
                getHeight = $(window).height(),
                getIn = getNav.find("ul.menu").data("in"),
                getOut = getNav.find("ul.menu").data("out");

            if (matchMedia('only screen and (max-width: 1200px)').matches) {

                // Enable click event
                $("nav.main-menu ul.menu").each(function () {

                    // Dropdown Fade Toggle
                    $("a.mega-menu-link", this).on('click', function (e) {
                        e.preventDefault();
                        var t = $(this);
                        t.toggleClass('active').next('ul').toggleClass('active');
                    });

                    // Megamenu style
                    $(".megamenu-fw", this).each(function () {
                        $(".col-menu", this).each(function () {
                            $(".title", this).off("click");
                            $(".title", this).on("click", function () {
                                $(this).closest(".col-menu").find(".content").stop().toggleClass('active');
                                $(this).closest(".col-menu").toggleClass("active");
                                return false;
                                e.preventDefault();

                            });

                        });
                    });
                });
            }
        },
    };


    $('.btn-show-menu-mobile').on('click', function (e) {
        $(this).toggleClass('is-active');
        $('.menu-mobile').toggleClass('show');
        return false;
        e.preventDefault();
    });

    // Initialize
    $(document).ready(function () {
        menu.initialize();

    });


    /*------------------------------------------------------------------------------*/
    /* Animation on scroll: Number rotator
    /*------------------------------------------------------------------------------*/

    $("[data-appear-animation]").each(function () {
        var self = $(this);
        var animation = self.data("appear-animation");
        var delay = (self.data("appear-animation-delay") ? self.data("appear-animation-delay") : 0);

        if ($(window).width() > 959) {
            self.html('0');
            self.waypoint(function (direction) {
                if (!self.hasClass('completed')) {
                    var from = self.data('from');
                    var to = self.data('to');
                    var interval = self.data('interval');
                    self.numinate({
                        format: '%counter%',
                        from: from,
                        to: to,
                        runningInterval: 2000,
                        stepUnit: interval,
                        onComplete: function (elem) {
                            self.addClass('completed');
                        }
                    });
                }
            }, { offset: '85%' });
        } else {
            if (animation == 'animateWidth') {
                self.css('width', self.data("width"));
            }
        }
    });



    /*------------------------------------------------------------------------------*/
    /* Skillbar
    /*------------------------------------------------------------------------------*/

    $('.ttm-progress-bar').each(function () {
        $(this).find('.progress-bar').width(0);
    });

    $('.ttm-progress-bar').each(function () {

        $(this).find('.progress-bar').animate({
            width: $(this).attr('data-percent')
        }, 2000);
    });


    // Part of the code responsible for loading percentages:

    $('.progress-bar-percent[data-percentage]').each(function () {

        var progress = $(this);
        var percentage = Math.ceil($(this).attr('data-percentage'));

        $({ countNum: 0 }).animate({ countNum: percentage }, {
            duration: 2000,
            easing: 'linear',
            step: function () {
                // What todo on every count
                var pct = '';
                if (percentage == 0) {
                    pct = Math.floor(this.countNum) + '%';
                } else {
                    pct = Math.floor(this.countNum + 1) + '%';
                }
                progress.text(pct);
            }
        });
    });

    /*------------------------------------------------------------------------------*/
    /* Tab
    /*------------------------------------------------------------------------------*/

    $(document).ready(function () {

        $('.content-tab').children('.content-inner').first().addClass('active');
        $('.ttm-tabs .tabs li').on('click', function (e) {
            if (!$(this).hasClass('active')) {
                var i = $(this).index();
                $('.ttm-tabs .tabs li.active').removeClass('active');
                $('.content-tab .active').hide().removeClass('active');
                $(this).addClass('active');
                $($('.content-tab').children('.content-inner')[i]).fadeIn(600).addClass('active');
                e.preventDefault();
            }
        });
    });


    /*------------------------------------------------------------------------------*/
    /* Accordion
    /*------------------------------------------------------------------------------*/

    /*https://www.antimath.info/jquery/quick-and-simple-jquery-accordion/*/
    $(".accordion").each(function () {

        var allPanels = $('.toggle').children(".toggle-content").hide();
        $('.toggle').children(".toggle-content").eq(2).slideDown("easeOutExpo");
        $('.toggle').children(".toggle-title").children("a").eq(2).addClass("active");

        $('.toggle').children(".toggle-title").children("a").click(function () {
            var current = $(this).parent().next(".toggle-content");
            $(".toggle-title > a").removeClass("active");
            $(this).addClass("active");
            allPanels.not(current).slideUp("easeInExpo");
            $(this).parent().next().slideDown("easeOutExpo");
            return false;
        });

    });


    /*------------------------------------------------------------------------------*/
    /* Isotope
    /*------------------------------------------------------------------------------*/

    $(function () {

        if ($().isotope) {
            var $container = $('.isotope-project');
            $container.imagesLoaded(function () {
                $container.isotope({
                    itemSelector: '.ttm-box-col-wrapper',
                    transitionDuration: '1s',
                    layoutMode: 'fitRows'
                });
            });

            $('.portfolio-filter li').on('click', function () {
                var selector = $(this).find("a").attr('data-filter');
                $('.portfolio-filter li').removeClass('active');
                $(this).addClass('active');
                $container.isotope({ filter: selector });
                return false;
            });
        };

    });



    /*------------------------------------------------------------------------------*/
    /* Prettyphoto
    /*------------------------------------------------------------------------------*/
    $(function () {

        // Normal link
        jQuery('a[href*=".jpg"], a[href*=".jpeg"], a[href*=".png"], a[href*=".gif"]').each(function () {
            if (jQuery(this).attr('target') != '_blank' && !jQuery(this).hasClass('prettyphoto') && !jQuery(this).hasClass('modula-lightbox')) {
                var attr = $(this).attr('data-gal');
                if (typeof attr !== typeof undefined && attr !== false && attr != 'prettyPhoto') {
                    jQuery(this).attr('data-rel', 'prettyPhoto');
                }


            }
        });

        jQuery('a[data-gal^="prettyPhoto"]').prettyPhoto();
        jQuery('a.ttm_prettyphoto').prettyPhoto();
        jQuery('a[data-gal^="prettyPhoto"]').prettyPhoto();
        jQuery("a[data-gal^='prettyPhoto']").prettyPhoto({ hook: 'data-gal' })

    });



    /*------------------------------------------------------------------------------*/
    /* Slick_slider
    /*------------------------------------------------------------------------------*/
    $(".slick_slider").slick({
        speed: 1000,
        infinite: true,
        arrows: false,
        dots: false,
        autoplay: false,
        centerMode: false,

        responsive: [{

            breakpoint: 1360,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 3
            }
        },
        {

            breakpoint: 1024,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 3
            }
        },
        {

            breakpoint: 680,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 2
            }
        },
        {
            breakpoint: 575,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1
            }
        }]
    });




    jQuery(document).ready(function ($) {
        if (jQuery('body').hasClass('ttm-one-page-site')) {
            var sections = jQuery('.ttm-row'),
                nav = jQuery('.ttm-header-wrap, .menu'),
                nav_height = jQuery('#site-navigation').data('sticky-height') - 1;

            jQuery(window).on('scroll', function () {
                if (jQuery('body').scrollTop() < 5) {
                    nav.find('a').parent().removeClass('active');
                }
                var cur_pos = jQuery(this).scrollTop();
                sections.each(function () {
                    var top = jQuery(this).offset().top - (nav_height + 1),
                        bottom = top + jQuery(this).outerHeight();
                    if (cur_pos >= top && cur_pos <= bottom) {
                        if (typeof jQuery(this) != 'undefined' && typeof jQuery(this).attr('id') != 'undefined' && jQuery(this).attr('id') != '') {
                            var mainThis = jQuery(this);
                            nav.find('a').removeClass('active');
                            jQuery(this).addClass('active');
                            var arr = mainThis.attr('id');

                            // Applying active class
                            nav.find('a').parent().removeClass('active');
                            nav.find('a').each(function () {
                                var menuAttr = jQuery(this).attr('href').split('#')[1];
                                if (menuAttr == arr) {
                                    jQuery(this).parent().addClass('active');
                                }
                            })
                        }
                    }
                });
                //}
            });

            nav.find('a').on('click', function () {
                var $el = jQuery(this),
                    id = $el.attr('href');
                var arr = id.split('#')[1];
                jQuery('html, body').animate({
                    scrollTop: jQuery('#' + arr).offset().top - nav_height
                }, 500);
                return false;
            });

        }

    }); // END of  document.ready

   
    /*------------------------------------------------------------------------------*/
    /* Back to top
    /*------------------------------------------------------------------------------*/

    // ===== Scroll to Top ==== 
    jQuery('#totop').hide();

    jQuery(window).scroll(function () {
        "use strict";
        if (jQuery(this).scrollTop() >= 1000) {        // If page is scrolled more than 50px
            jQuery('#totop').fadeIn(200);    // Fade in the arrow
            jQuery('#totop').addClass('top-visible');
        } else {
            jQuery('#totop').fadeOut(200);   // Else fade out the arrow
            jQuery('#totop').removeClass('top-visible');
        }
    });

    jQuery('#totop').on("click", function () {      // When arrow is clicked
        jQuery('body,html').animate({
            scrollTop: 0                       // Scroll to top of body
        }, 500);
        return false;
    });



    $(function () {

    });

})(jQuery);


$(document).ready(function () {
    //Subscribe
    let submit = $("#submitBtn");

    submit.click(function (e) {
        e.preventDefault();

        let email = $("#subscribies input[name='email']");
        let success = $("#subscribies .alert-success");
        let warning = $("#subscribies .alert-warning");
        success.css("display", "none");
        warning.css("display", "none");

        $.ajax({
            url: "Home/Subscribe",
            type: "get",
            dataType: "json",
            data: {
                email: email.val()
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                email.val("");
            }
           
        });
    });

    //Appointment
    let appointmentButton = $(".myButton");

    appointmentButton.click(function (e) {
        e.preventDefault();

        let name = $("#app-form input[name='name']");
        let email = $("#app-form input[name='email']");
        let phone = $("#app-form input[name='phone']");
        let doctor = $("#app-form select[name='doctor']");
        let note = $("#app-form input[name='note']");
        let datetime = $("#app-form input[name='appdatetime']");

        let success = $("#app-form .alert-success");
        let warning = $("#app-form .alert-warning");
        success.css("display", "none");
        warning.css("display", "none");

        $.ajax({
            url: "Appointment/Message",
            type: "post",
            dataType: "json",
            data: {
                email: email.val(),
                name: name.val(),
                phone: phone.val(),
                doctor: doctor.val(),
                note: note.val(),
                datetime: datetime.val(),
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                name.val("");
                email.val("");
                phone.val("");
                doctor.val("");
                note.val("");
                datetime.val("");
            }
        });
    });


    //Contact Us Message
    let messageButton = $("#btn-message");

    messageButton.click(function (e) {
        e.preventDefault();

        let name = $("#ttm-contactform-2 input[name='name']");
        let email = $("#ttm-contactform-2 input[name='email']");
        let phone = $("#ttm-contactform-2 input[name='phone2']");
        let subject = $("#ttm-contactform-2 input[name='subject']");
        let text = $("#ttm-contactform-2 textarea[name='message']");

        let success = $("#ttm-contactform-2 .alert-success");
        let warning = $("#ttm-contactform-2 .alert-warning");
        success.css("display", "none");
        warning.css("display", "none");

        $.ajax({
            url: "ContactUs/Message",
            type: "post",
            dataType: "json",
            data: {
                email: email.val(),
                name: name.val(),
                phone: phone.val(),
                subject: subject.val(),
                text: text.val(),
            },
            success: function (response) {
                if (response.status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                name.val("");
                email.val("");
                phone.val("");
                subject.val("");
                text.val("");
            }
        });
    });


    $(".sweet").click(function () {
        $(swal("Every Day", "10:00 AM -05:00 PM", )).hide();
    });

  


});
