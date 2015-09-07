/// <reference path="jquery-1.10.2.js" />
/// <reference path="c:\users\wboun\documents\visual studio 2015\Projects\WebAppTest\WebAppTest\Views/Home/Index.cshtml" />

$(function () {
    $(".editable").on("click", function () {
        if ($(this).hasClass("clicked")) return;
        var text = $(this).text();
        $(this).addClass("clicked");
        $(this).html("<input type='text' value='" + text + "' class='editableInput'>")
    });
    //$(".editableInput").delegate.on("change", function () {
    //    console.log("change")
    //    var val = $(this).val();
    //    var parent = $(this).parent();
    //    var studentID = $(parent).attr("stId");
    //    var subjectID = $(parent).attr("subId");        
    //    $.post("/Home/EditGrade", { studentId: studentID, subjectId: subjectID, grade: val });
    //    $(parent).html(val);
    //    $(parent).removeClass("clicked");
    //});

    $(document).delegate('.editableInput', 'keypress', function (event) {
        console.log("entered");
        if (event.which === 13) {
            //Disable textbox to prevent multiple submit
            $(this).attr("disabled", "disabled");
            console.log("change")
            var val = $(this).val();
            var parent = $(this).parent();
            var studentID = $(parent).attr("stId");
            var subjectID = $(parent).attr("subId");
            $.post("/Home/EditGrade", { studentId: studentID, subjectId: subjectID, grade: val });
            $(parent).html(val);
            $(parent).removeClass("clicked");
        }
    });

});