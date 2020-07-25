$(window).scroll(function () {
        var buton = document.getElementById("buttonFinder");
        if ($(window).scrollTop() + $(window).height() >= $(document).height() - 50) {
    buton.classList.remove('activeButton');
            buton.classList.add('inactiveButton');
        }
        else {
    buton.classList.remove('inactiveButton');
            buton.classList.add('activeButton');
        }
    });
