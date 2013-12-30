define(function (require, exports, module) {
    exports.random = function (min, max) {
        return min + Math.round(Math.random() * (max - min));
    };

    exports.isNumber = function (val) {
        return (!isNaN(parseInt(val)));
    };

    exports.isNullOrEmptyOrWhitespace = function (val) {
        return (typeof val == "undefined" || val == "" || val.match(/^\s+$/));
    };

    exports.htmlEncode = function (val) {
        var $ = require("jquery");
        return $('<div/>').text(val).html();
    };

    exports.htmlDecode = function (val) {
        var $ = require("jquery");
        return $('<div/>').html(val).text();
    };
});
