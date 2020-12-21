$.ajaxSetup({
    cache: false
});

var Application = {
    LoadWait: function (FlagShow) {
        if (FlagShow) {

            $('body').waitMe({

                //none, rotateplane, stretch, orbit, roundBounce, win8,
                //win8_linear, ios, facebook, rotation, timer, pulse,
                //progressBar, bouncePulse or img
                effect: 'ios',
                //place text under the effect (string).
                text: '',
                //background for container (string).
                bg: 'rgba(255,255,255,0.7)',
                //color for background animation and text (string).
                color: '#000',
                //change width for elem animation (string).
                sizeW: '',
                //change height for elem animation (string).
                sizeH: '',
                // url to image
                source: '',
                // callback
                onClose: function () { }
            });
        }
        else {
            $('body').waitMe('hide');
        }
    },
    toast: function (msg, heading) {
        $.toast({
            heading: heading,
            text: msg,
            //showHideTransition: 'slide',   
            //bgColor: '#FF1356',
            //textColor: 'white'
            icon: heading,
            position: 'top-center',
            textAlign: 'left',
            hideAfter: 7000   // in milli seconds,

        });

    }
}