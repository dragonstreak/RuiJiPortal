define(function (require, exports, module) {
    var $ = require("jquery");
    var util = require("../../util/src/util.js");

    $(document).ready(function () {
        $("div.table-title-wrapper li").mouseover(function () {
            $("div.table-title-wrapper li").removeClass();
            $("div.table-title-wrapper li").addClass("other");
            $(this).removeClass();
            
            var key = $(this).attr("key");

            $("div.table-content-wrapper > div").hide();
            $("div.table-content-wrapper > div[key=" + key + "]").show();
        });

        $("div.table-title-wrapper li:first").mouseover();
    });
});