$(document).ready(function(){

    $("#hideBtn").click(function(){

        $(".box").hide();

    });

    $("#showBtn").click(function(){

        $(".box").show();

    });

    $("#fadeOutBtn").click(function(){

        $(".box").fadeOut();

    });

    $("#fadeInBtn").click(function(){

        $(".box").fadeIn();

    });

    $("#toggleBtn").click(function(){

        $(".box").toggle();

    });

    $("#slideBtn").click(function(){

        $(".box")
            .slideUp()
            .delay(1000)
            .slideDown();

    });

});