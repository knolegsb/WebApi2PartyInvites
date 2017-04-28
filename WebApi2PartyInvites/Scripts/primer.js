var modelData = ko.observable("(Ready"));

var sendRequest = function(){
    $.ajax("/api/pagesize", {
        type: "GET",
        success: function(data){
            console.log(data);
            modelData("Response: " + data.data + " bytes");
        }
    });
}

$(document).ready(function(){
    ko.applyBindings();
});