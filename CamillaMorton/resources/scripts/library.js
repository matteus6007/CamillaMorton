/***** Model Dialog *****/

//0 means disabled; 1 means enabled;
var dialogStatus = 0;

function loadDialog(html) {
    //loads popup only if it is disabled
    if (dialogStatus == 0) {
        $('body').append('<div id="modalDialog"><div class="model-dialog-wrapper"><div class="modal-dialog-content" ></div><div class="close"><a href="javascript:closeDialog();" title="close window">Close</a></div></div><div class="modal-dialog-background" onclick="closeDialog();"></div></div>');

        $('.modal-dialog-content').html(html);

        $(".modal-dialog-background").css({ "opacity": "0.7" });
        $(".modal-dialog-background").fadeIn("slow");
        $(".model-dialog-wrapper").fadeIn("slow");
        dialogStatus = 1;

        //add window resize event listener
        $(window).resize(function() { centerDialog(); });
        $(window).scroll(function() { centerDialog(); });

        //escape event listener
        $(document).keypress(function(e) {
            if (e.keyCode == 27 && dialogStatus == 1) {
                closeDialog();
            }
        });

        //re-center when images have loaded
        $("#modalDialog img").load(function() { centerDialog(); })

        centerDialog();
    }
}

function closeDialog() {

    if (dialogStatus == 1) {
        $("#modalDialog").fadeOut("slow", function() {
            $("#modalDialog").detach();
        });
        dialogStatus = 0;

        //reset event listeners
        $(window).resize();
        $(window).scroll();
        $(document).keypress();
    }
}

function centerDialog() {
    //request data for centering
    var windowWidth = $(window).width();
    var windowHeight = $(window).height();
    var scrollTop = $(window).scrollTop();
    var scrollLeft = $(window).scrollLeft();
    var popupHeight = $(".model-dialog-wrapper").height();
    var popupWidth = $(".model-dialog-wrapper").width();

    var top = (windowHeight / 2 - popupHeight / 2) + scrollTop;

    //centering
    $(".model-dialog-wrapper").css({
        "position": "absolute",
        "top": top < 0 ? 0 : top,
        "left": (windowWidth / 2 - popupWidth / 2) + scrollLeft
    });

    //only need force for IE6
    if ($.browser.msie && parseInt($.browser.version) == 6) {

        $(".modal-dialog-background").css({
            "height": windowHeight,
            "width": windowWidth
        });
    }
}

function loadHtmlPopup(url) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function(data) {
            loadDialog(data);
        }
    });
}
