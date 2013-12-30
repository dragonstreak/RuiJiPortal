define(function (require, exports, module) {
    var $ = require("jquery");

    $(document).ready(function () {
        $("div.tabel-title-wrapper li").mouseover(function () {
            $("div.tabel-title-wrapper li").removeClass();
            $("div.tabel-title-wrapper li").addClass("other");
            $(this).removeClass();
            
            var key = $(this).attr("key");

            $("div.table-content-wrapper > div").hide();
            $("div.table-content-wrapper > div[key=" + key + "]").show();
        });
    });
});