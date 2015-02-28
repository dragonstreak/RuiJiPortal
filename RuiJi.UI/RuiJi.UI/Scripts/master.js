var $j = jQuery;

//define name space
if (typeof (_ruiji) == "undefined")
	_ruiji = {};

if (typeof (_ruiji.internal) == "undefined")
	_ruiji.internal = {};

if (typeof (_ruiji.internal.master) == "undefined")
    _ruiji.internal.master = {};

if (typeof (_ruiji.ModalBox) == "undefined")
    _ruiji.ModalBox = {};

function strobj(o) {
    var temp = '';
    var t, a = [];
    for (var i in o) {
        try {
            if (typeof (o[i]) == "function") {
                t = '""' + i + '""' + ':' + 'function(){<em>[native code]</em>}' + '';
            }
            else if (Object.prototype.toString.call(o[i]) === '[object Array]') //数组
            {
                var p, b = [];
                for (var j in o[i]) {
                    if (isNaN(o[i][j])) { p = '"' + o[i][j] + '"'; } else { p = '' + o[i][j] + ''; }
                    b.push(p);
                }
                t = '""' + i + '""' + ':[' + b.join(',') + ']';
            }
            else {
                if (typeof (o[i]) == 'object') //对象,其他
                {
                    t = '""' + i + '""' + ':' + strobj(o[i]) + '';
                }
                else {
                    if (isNaN(o[i])) { t = '""' + i + '""' + ':"' + o[i] + '"'; } else { t = '""' + i + '""' + ':' + o[i] + ''; }
                }
            }
            a.push(t); t = '';
        }
        catch (e) {
            alert(e.message);
        }
    }
    temp = "{" + a.join(', ') + "}";
    return temp;
}

_ruiji.internal.master.escapeHtml = function (html) {
    var findReplace = [[/&/g, "&amp;"], [/</g, "&lt;"], [/>/g, "&gt;"], [/"/g, "&quot;"]];
    for (var item in findReplace)
        html = html.replace(findReplace[item][0], findReplace[item][1]);

    return html;
}
//set element to center
//usage: $(element).center();
$j.fn.center = function () {
	this.css("position", "absolute");
	this.css("top", (($(window).height() - this.outerHeight()) / 2) + $(window).scrollTop() + "px");
	this.css("left", (($(window).width() - this.outerWidth()) / 2) + $(window).scrollLeft() + "px");
	return this;
}

_ruiji.internal.master.modalBoxCache = new Array();

_ruiji.internal.master.showMessage = function (msg) {
	$j('#promptMessage').html(msg);
	//settimeout for ie8
	setTimeout("$j('#promptMessageContainer').center();	$j('#promptMessage').center();	$j('#promptMessageContainer').fadeIn();	$j('#promptMessage').fadeIn();", 50);

	setTimeout("$j('#promptMessageContainer').fadeOut()", 2050);
	setTimeout("$j('#promptMessage').fadeOut()", 2050);
}

//handle Error
_ruiji.internal.master.handerError = function (jqXHR, textStatus, errorThrown) {
    _ruiji.internal.master.hideLoading();
    $j("#messagebox").empty().html("System error. Please try again.").dialog({
        modal: true,
        buttons: {
            Ok: function () {
                $(this).dialog("close");
            }
        }
    });
	//alert(jqXHR.responseText);
}

//modal box initalization helper
_ruiji.internal.master.initialModalBox = function (containerId, enablejQueryAnimation) {
    if (!(_ruiji && _ruiji.ModalBox)) {
        $j("#messagebox").empty().html("missing script file!").dialog({
            modal: true,
            buttons: {
                Ok: function () {
                    $(this).dialog("close");
                }
            }
        });
        return;
    }

    var instanceObj = new _ruiji.ModalBox(containerId, enablejQueryAnimation);

    instanceObj.OverLay.Color = '#000';
    instanceObj.OverLay.Opacity = '30';
    instanceObj.OverLay.enablejQueryAnimation = !(enablejQueryAnimation === false);
    instanceObj.Fixed = true;
    instanceObj.Center = true;

    _ruiji.internal.master.modalBoxCache.push(instanceObj);

    return instanceObj;
}

_ruiji.internal.master.closeAllModalBox = function(){
    for(var i = 0; i < _ruiji.internal.master.modalBoxCache.length; i++ ){
        _ruiji.internal.master.modalBoxCache[i].Close();
    }
}

_ruiji.internal.master.setPageMessage = function (pageStatus, pageMessage) {
    if ($j('#PageStatus') && $j('#PageMessage')) {
        $j('#PageStatus').val(pageStatus);
        $j('#PageMessage').val(pageMessage);
    }
}

//modalbox instance
_ruiji.internal.master.mbLoading = null;

//show loading modalbox
_ruiji.internal.master.showLoading = function () {
	//$j('#divLoadingContainer').html("<div class='loading'><img src='@Url.Content("~/Images/ajax-loader.gif")' /></div>");
	if (_ruiji.internal.master.mbLoading)
		_ruiji.internal.master.mbLoading.Show();
}

//hide loading modalbox
_ruiji.internal.master.hideLoading = function () {
	if(_ruiji.internal.master.mbLoading)
		_ruiji.internal.master.mbLoading.Close();
}

_ruiji.internal.master.printContent = function(divContainer, styleSheets) {
	var sheetsLink = '';
	for (var i = 0; i < styleSheets.length; i++)
		sheetsLink += ('<link href="' + styleSheets[i] + '" rel="stylesheet" type="text/css" />');

	var docContainer = document.getElementById(divContainer);
	var html = '<!DOCTYPE html><html><head>' +
                                   sheetsLink +
                                   '</head><body style="background:#ffffff;">' +
                                   docContainer.innerHTML +
                                   '</body></html>';

	var winObj = window.open(""
                                                , "printWindow"
                                                , "width=800,height=650,top=50,left=50,toolbars=no,scrollbars=yes,status=no,resizable=yes");
	winObj.document.writeln(html);
	winObj.document.close();
	winObj.focus();
	winObj.print();
	winObj.close();
}

//initial loading on document ready.
$j(function () {
    if (!_ruiji.internal.master.mbLoading) {
        _ruiji.internal.master.mbLoading = _ruiji.internal.master.initialModalBox('divLoading', false);
        _ruiji.internal.master.mbLoading.OverLay.Opacity = '0';
    }

    if (typeof (schoolTimeZoneOffset) != 'undefined'
       && typeof(schoolTimeZoneDisplayName) != 'undefined') {
        _ruiji.internal.master.SetTimeZoneInfo(schoolTimeZoneOffset, schoolTimeZoneDisplayName);
    }
})

