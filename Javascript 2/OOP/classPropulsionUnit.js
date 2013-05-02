Propeller.inherit(PropulsionUnit);
PropellingNozzle.inherit(PropulsionUnit);
Wheel.inherit(PropulsionUnit);

var direction = {
	CLOCKWISE: 0,
	COUNTERCLOCKWISE: 1
};

function PropulsionUnit() {}

function Propeller(numberOfFins) {
	PropulsionUnit.call(this);
	this.numberOfFins = numberOfFins;
	this.spinDirection = direction.CLOCKWISE;
}

Propeller.prototype.accelerate = function() {
	if (this.spinDirection === direction.CLOCKWISE) {
		return this.numberOfFins;
	} else {
		return (-1) * this.numberOfFins;
	}
};

function PropellingNozzle(power) {
	PropulsionUnit.call(this);
	this.power = power;
	this.isAfterburnerOn = true;
}
PropellingNozzle.prototype.accelerate = function() {
	if (this.isAfterburnerOn) {
		return 2 * this.power;
	} else {
		return this.power;
	}
};

function Wheel(radius) {
	PropulsionUnit.call(this);
	this.radius = radius;
}

Wheel.prototype.accelerate = function() {
	return 2 * this.radius * Math.PI;
};