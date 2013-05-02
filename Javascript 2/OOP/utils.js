// Function.prototype.inherit = function(parent) {
//     this.prototype = Object.create(parent.prototype);
//     this.prototype.constructor = this;
//     this.prototype.parent = parent.prototype;
// };

Function.prototype.inherit = function(parent) {
    this.prototype = new parent();
    this.prototype.constructor = this;
};

Function.prototype.extend = function(parent) {
    for (var i = 1; i < arguments.length; i += 1) {
        var name = arguments[i];
        this.prototype[name] = parent.prototype[name];
    }
    return this;
};