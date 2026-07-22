$(document).ready(function(){

    // Click
    $("#clickBtn").click(function(){

        $("#message").text("Button Clicked!");

    });

    // Double Click
    $("#eventBox").dblclick(function(){

        $("#message").text("Box Double Clicked!");

    });

    // Mouse Enter
    $("#eventBox").mouseenter(function(){

        $(this).css("background","lightgreen");

        $("#message").text("Mouse Entered!");

    });

    // Mouse Leave
    $("#eventBox").mouseleave(function(){

        $(this).css("background","white");

        $("#message").text("Mouse Left!");

    });

    // Key Press
    $("#nameInput").keypress(function(){

        $("#message").text("Key Pressed...");

    });

});