let scale: number = 100;
let inputScale: string;
let initialTempleate: string[][] = [...[], ...[]];;
let x: Number[] = [];
let y: Number[] = [];




this.initializeTempleate(scale);
this.getPositions();
this.drawingX();





function initializeTempleate(scale: Number) {
    if (scale > 0) {
        for (let i = 0; i < scale; i++) {
            this.initialTempleate[i] = []
            for (let k = 0; k < scale; k++) {
                this.initialTempleate[i][k] = '_';
            }
        }
    } else {
        console.log("ERROR");
    }



}

function getPositions() {
    for (let a = 0; a < 2; a++) {
        if (a == 0) {
            for (let i = 0; i <= (this.scale - 1); i++) {
                //x
                this.x.push(i);
                this.y.push(i);

            }
        } else {
            //y
            for (let i = 0; i <= (this.scale - 1); i++) {
                //x
                this.x.push(i);
            }
            for (let yy = this.scale - 1; yy >= 0; yy--) {
                this.y.push(yy);

            }
        }
    }
}

function drawingX() {
    let response: String = "";
    for (let d = 0; d < this.x.length; d++) {
        this.initialTempleate[this.x[d].toString()][this.y[d]] = 'x'
        // console.log('x', this.x[d]);

    }

    this.initialTempleate.forEach((x, y) => {
        x.forEach((h, j) => {
            response += h;
            if (j === this.scale - 1) {
                response += '\n';
            }
        })
    })
    console.log(response);
}
