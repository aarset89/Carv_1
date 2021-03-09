var __spreadArrays = (this && this.__spreadArrays) || function () {
    for (var s = 0, i = 0, il = arguments.length; i < il; i++) s += arguments[i].length;
    for (var r = Array(s), k = 0, i = 0; i < il; i++)
        for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
            r[k] = a[j];
    return r;
};
var scale = 100;
var inputScale;
var initialTempleate = __spreadArrays([], []);
;
var x = [];
var y = [];
this.initializeTempleate(scale);
this.getPositions();
this.drawingX();
function initializeTempleate(scale) {
    if (scale > 0) {
        for (var i = 0; i < scale; i++) {
            this.initialTempleate[i] = [];
            for (var k = 0; k < scale; k++) {
                this.initialTempleate[i][k] = '_';
            }
        }
    }
    else {
        console.log("ERROR");
    }
}
function getPositions() {
    for (var a = 0; a < 2; a++) {
        if (a == 0) {
            for (var i = 0; i <= (this.scale - 1); i++) {
                //x
                this.x.push(i);
                this.y.push(i);
            }
        }
        else {
            //y
            for (var i = 0; i <= (this.scale - 1); i++) {
                //x
                this.x.push(i);
            }
            for (var yy = this.scale - 1; yy >= 0; yy--) {
                this.y.push(yy);
            }
        }
    }
}
function drawingX() {
    var _this = this;
    var response = "";
    for (var d = 0; d < this.x.length; d++) {
        this.initialTempleate[this.x[d].toString()][this.y[d]] = 'x';
        // console.log('x', this.x[d]);
    }
    this.initialTempleate.forEach(function (x, y) {
        x.forEach(function (h, j) {
            response += h;
            if (j === _this.scale - 1) {
                response += '\n';
            }
        });
    });
    console.log(response);
}
