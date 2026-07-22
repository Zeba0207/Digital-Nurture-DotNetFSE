$(document).ready(function(){

    $("#addBtn").click(function(){

        let item = $("#itemInput").val().trim();

        if(item !== ""){

            $("#itemList").append("<li>" + item + "</li>");

            $("#itemInput").val("");

        }

    });

    $("#removeBtn").click(function(){

        $("#itemList").empty();

    });

});