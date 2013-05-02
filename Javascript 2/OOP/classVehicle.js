LandVehicle.inherit(Vehicle);
AirVehicle.inherit(Vehicle);
WaterVehicle.inherit(Vehicle);
AmphibiousVehicle.inherit(Vehicle);

function Vehicle(propulsionUnits) {
    this.speed = 0;
    this.propulsionUnits = propulsionUnits;
}
Vehicle.prototype.accelerate = function() {
    var sum = 0;
    for (var i = 0; i < this.propulsionUnits.length; i++) {
        sum += this.propulsionUnits[i].accelerate();
    }
    this.speed += sum;
};

function LandVehicle(wheels) {
    Vehicle.call(this, wheels);
}

function AirVehicle(propellingNozzle) {
    Vehicle.call(this, propellingNozzle);
}

AirVehicle.prototype.switchAfterburner = function() {
    this.propulsionUnits.forEach(function(unit) {
        unit.isAfterburnerOn = !unit.isAfterburnerOn;
    });
};

function WaterVehicle(propellers) {
    Vehicle.call(this, propellers);
}

WaterVehicle.prototype.changeSpinDirection = function() {
    this.propulsionUnits.forEach(function(unit) {
        if (unit.spinDirection === direction.CLOCKWISE) {
            unit.spinDirection = direction.COUNTERCLOCKWISE;
        } else {
            unit.spinDirection = direction.CLOCKWISE;
        }
    });
};

AmphibiousVehicle.extend(WaterVehicle, 'changeSpinDirection');

function AmphibiousVehicle(wheels, propellers) {
    Vehicle.call(this, wheels);
    this.isOnLand = true;
    this.propellers = propellers;
    this.wheels = wheels;
}

AmphibiousVehicle.prototype.switchMode = function() {

    if (this.isOnLand) {
        this.propulsionUnits = this.propellers;
    } else {
        this.propulsionUnits = this.wheels;
    }
    this.isOnLand = !this.isOnLand;
};