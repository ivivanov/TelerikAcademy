(function() {
  'use strict';

  function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }

  function createDiv() {
    var div = document.createElement('div');
    div.style.width = '40px';
    div.style.height = '40px';
    div.style.background = 'rgba(100,100,200,0.3)';
    div.style.position = 'absolute';
    div.style.left = '0px';
    div.style.borderRadius = '30px';
    div.innerHTML = '<strong>div</strong>';
    div.style.textAlign = 'center';
    return div;
  }

  function Circle(x, y, r) {
    this.x = x;
    this.y = y;
    this.radius = r;
    this.element = document.createElement('div');
    this.element.style.top = x - r + 'px';
    this.element.style.left = y - r + 'px';
  }

  Circle.prototype.drow = function(element, degree) {
    var x = this.x + this.radius * Math.cos(degree * Math.PI / 180);
    var y = this.y + this.radius * Math.sin(degree * Math.PI / 180);
    element.style.left = x - parseInt(element.style.width, 10) / 2 + 'px';
    element.style.top = y - parseInt(element.style.height, 10) / 2 + 'px';
  };

  var docFragment = document.createDocumentFragment();
  var divArr = [];
  var divCount = 5;
  var circle = new Circle(250, 250, 200);

  docFragment.appendChild(circle.element);

  for (var i = 0; i < divCount; i++) {
    var div = createDiv();
    docFragment.appendChild(div);
    divArr.push(div);
    var degrees = i * 360 / divCount;
    div.setAttribute('angle', degrees);
    circle.drow(div, degrees);
  }

  document.body.appendChild(docFragment);

  setInterval(function() {
    for (var i = 0; i < divCount; i += 1) {
      var currentDiv = divArr[i];
      degrees = (parseFloat(currentDiv.getAttribute('angle')) + 1) % 360;
      currentDiv.setAttribute('angle', degrees);
      circle.drow(currentDiv, degrees);
    }
  }, 100);

})();