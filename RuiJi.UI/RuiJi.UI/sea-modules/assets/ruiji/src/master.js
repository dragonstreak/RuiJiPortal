define(function (require, exports, module) {
    var $ = require("jquery");
    var util = require("../../util/src/util.js");

    $(document).ready(function () {
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