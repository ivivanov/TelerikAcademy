var carousel = (function () {
    var currentImageOffset = 0;
    var imagesCount = 0;
    var IMAGE_WIDTH = 400;

    function init() {
        var list = document.querySelectorAll(".slider-img");
        imagesCount = list.length;
        for (var i = 0; i < list.length; i++) {
            list[i].style.left = i * IMAGE_WIDTH + "px";
        }
    }

    function next() {
        var holder = document.getElementById("galery");
        if (Math.abs(currentImageOffset) == imagesCount - 1) {
            return;
        }
        currentImageOffset--;
        holder.style.left = (currentImageOffset * IMAGE_WIDTH) + "px";
    }

    function previous() {
        var holder = document.getElementById("galery");
        if (currentImageOffset == 0) {
            return;
        }
        currentImageOffset++;
        holder.style.left = (currentImageOffset * IMAGE_WIDTH) + "px";
    }

    return {
        init: init,
        previous: previous,
        next: next
    }
}());