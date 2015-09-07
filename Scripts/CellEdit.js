/// <reference path="jquery-1.10.2.js" />
/// <reference path="c:\users\wboun\documents\visual studio 2015\Projects\WebAppTest\WebAppTest\Views/Home/Index.cshtml" />

$(function () {
    $(".editable").on("click", function () {
        var text = $(this).text();
        $(this).html("<input type='text' value="+text+" class='editableInput'>")
    });
    $(".editableInput").on("change", function () {
        var val = $(this).val();
        var parent = $(this).parent();
        var studentID = $(parent).attr("stId");
        var subjectID = $(parent).attr("subId");        
        $.post("/Home/EditGrade", { studentId: studentID, subjectId: subjectID, grade: val });
        $(parent).html(val);
    });
});