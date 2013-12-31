define(function (require, exports, module) {
    var $ = require("jquery");
    var util = require("../../util/src/util.js");

    $(document).ready(function () {
        $("div.tabel-title-wrapper li").mouseover(function () {
            $("div.tabel-title-wrapper li").removeClass();
            $("div.tabel-title-wrapper li").addClass("other");
            $(this).removeClass();
            
            var key = $(this).attr("key");

            $("div.table-content-wrapper > div").hide();
            $("div.table-content-wrapper > div[key=" + key + "]").show();
        });

        $("a#switch-lang").click(function () {
            var cultureCode = $(this).attr("culturecode");

            util.setCookie("_culture", cultureCode);

            window.location.reload();

            //$.ajax({
            //    url: ruiji.switchLangUrl,
            //    type: "POST",
            //    data: {
            //        culture: cultureCode
            //    }
            //}).done(function () {

            //});
        });
    });
});