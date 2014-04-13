/*
Raphael.fn.drawGrid = function (x, y, w, h, wv, hv, color) {
    color = color || "#000";
    var path = ["M", Math.round(x) + .5, Math.round(y) + .5, "L", Math.round(x + w) + .5, Math.round(y) + .5, Math.round(x + w) + .5, Math.round(y + h) + .5, Math.round(x) + .5, Math.round(y + h) + .5, Math.round(x) + .5, Math.round(y) + .5],
        rowHeight = h / hv,
        columnWidth = w / wv;
    for (var i = 1; i < hv; i++) {
        path = path.concat(["M", Math.round(x) + .5, Math.round(y + i * rowHeight) + .5, "H", Math.round(x + w) + .5]);
    }
    for (i = 1; i < wv; i++) {
        path = path.concat(["M", Math.round(x + i * columnWidth) + .5, Math.round(y) + .5, "V", Math.round(y + h) + .5]);
    }
    return this.path(path.join(",")).attr({stroke: color});
};*/

$(function () {
    $("#data").css({
        position: "absolute",
        left: "-9999em",
        top: "-9999em"
    });
    $("#urls").css({
        position: "absolute",
        left: "-9999em",
        top: "-9999em"
    });
});

window.onload = function () {
    /*function getAnchors(p1x, p1y, p2x, p2y, p3x, p3y) {
        var l1 = (p2x - p1x) / 2,
            l2 = (p3x - p2x) / 2,
            a = Math.atan((p2x - p1x) / Math.abs(p2y - p1y)),
            b = Math.atan((p3x - p2x) / Math.abs(p2y - p3y));
        a = p1y < p2y ? Math.PI - a : a;
        b = p3y < p2y ? Math.PI - b : b;
        var alpha = Math.PI / 2 - ((a + b) % (Math.PI * 2)) / 2,
            dx1 = l1 * Math.sin(alpha + a),
            dy1 = l1 * Math.cos(alpha + a),
            dx2 = l2 * Math.sin(alpha + b),
            dy2 = l2 * Math.cos(alpha + b);
        return {
            x1: p2x - dx1,
            y1: p2y + dy1,
            x2: p2x + dx2,
            y2: p2y + dy2
        };
    }*/
    // Grab the data
    var labels = [],
        data = [],
        data2 = [],
        urls = [];
    $("#data tfoot th").each(function () {
        labels.push($(this).html());
    });
    $("#data tbody td").each(function () {
        data.push($(this).html());
    });
    $("#data thead th").each(function () {
        data2.push($(this).html());
    });

    $("#urls span").each(function () {
        urls.push($(this).html());
    });
    
    // Draw
    var width = 1000,
        height = 400,
        leftgutter = 20,
        bottomgutter = 20,
        topgutter = 20,
        colorhue = .6 || Math.random(),
        color = "hsl(" + [colorhue, .5, .5] + ")",
        r = Raphael("holder", width, height),
        txt = {font: '12px Helvetica, Arial', fill: "#fff"},
        txt1 = {font: '10px Helvetica, Arial', fill: "#fff"},
        txt2 = {font: '12px Helvetica, Arial', fill: "#000"};
        //X = (width - leftgutter) / labels.length,
        //max = Math.max.apply(Math, data),
        //Y = (height - bottomgutter - topgutter) / max;
		var circle = r.rect(0, 0, 1000, 400, 10).attr({
                    stroke: "none",
                    fill: "0-#9bb7cb-#adc8da"
                });
				
		circle.attr({
		  "fill": "19-#0270bb:5-#1c298a:95",
		  "fill-opacity": 0.5
		});
				
		r.setStart();
		//var hue = Math.random();
		for (var country in worldmap.shapes) {
			// var c = Raphael.hsb(Math.random(), .5, .75);
			// var c = Raphael.hsb(.11, .5, Math.random() * .25 - .25 + .75);
			r.path(worldmap.shapes[country]).attr({stroke: "#000", fill: "#f0efeb", "stroke-opacity": 0.25});
		}
		
		var over = function () {
			this.c = this.c || this.attr("fill");
			this.stop().animate({fill: "#bacabd"}, 200);
		},
			out = function () {
				this.stop().animate({fill: this.c}, 200);
			};
		var world = r.setFinish();
		
                world.hover(over, out);
   // r.drawGrid(leftgutter + X * .5 + .5, topgutter + .5, width - leftgutter - X, height - topgutter - bottomgutter, 10, 10, "#000");
    var path = r.path().attr({stroke: color, "stroke-width": 4, "stroke-linejoin": "round"}),
        bgp = r.path().attr({stroke: "none", opacity: .3, fill: color}),
        label = r.set(),
        lx = 0, ly = 0,
        is_label_visible = false,
        leave_timer,
        blanket = r.set();
    label.push(r.text(60, 12, "24 hits").attr(txt));
    label.push(r.text(60, 27, "22 September 2008").attr(txt1).attr({fill: color}));
    label.hide();
    var frame = r.popup(100, 100, label, "right").attr({fill: "#000", stroke: "#666", "stroke-width": 2, "fill-opacity": .7}).hide();
var X0=0, Y0=0;
    var p, bgpp;
    for (var i = 0, ii = labels.length; i < ii; i++) {
      //aqui van las coordenadas
	    datos = data2[i].split(",");
	    var y = datos[0]* -2.6938 + 227.066,
            x = datos[1]* 2.6938 + 465.4;
			X=x;
			Y=y;
            //t = r.text(x, height - 6, labels[i]).attr(txt).toBack();
        if (!i) {
            p = ["M", x, y, "C", x, y];
        }
       // if (i && i < ii - 1) {
        //    var Y0 = Math.round(height - bottomgutter - Y * data[i - 1]),
          //      X0 = Math.round(leftgutter + X * (i - .5)),
           //     Y2 = Math.round(height - bottomgutter - Y * data[i + 1]),
            //    X2 = Math.round(leftgutter + X * (i + 1.5));
           // var a = getAnchors(X0, Y0, x, y, X0, Y0);
            p = p.concat([X0, Y0, x, y, x, y]);
			X0=x;
			Y0=y;
        //}
        var dot = r.circle(x, y, 4).attr({fill: "#333", stroke: color, "stroke-width": 2});
        blanket.push(r.rect(x-10, y-10, 20, 20).attr({stroke: "none", fill: "#fff", opacity: 0}));
        var rect = blanket[blanket.length - 1];
        (function (x, y, data, lbl, dot, url) {
            var timer, i = 0;
            rect.click(function () {
                window.open(url, "_blank");
            });
            rect.hover(function () {
                clearTimeout(leave_timer);
                var side = "right";
                if (x + frame.getBBox().width > width) {
                    side = "left";
                }
                var ppp = r.popup(x, y, label, side, 1),
                    anim = Raphael.animation({
                        path: ppp.path,
                        transform: ["t", ppp.dx, ppp.dy]
                    }, 200 * is_label_visible);
                lx = label[0].transform()[0][1] + ppp.dx;
                ly = label[0].transform()[0][2] + ppp.dy;
                frame.show().stop().animate(anim);
                label[0].attr({text: data + ""}).show().stop().animateWith(frame, anim, {transform: ["t", lx, ly]}, 200 * is_label_visible);
                label[1].attr({text: lbl + ""}).show().stop().animateWith(frame, anim, {transform: ["t", lx, ly]}, 200 * is_label_visible);
                dot.attr("r", 7);
				dot.attr({stroke: "#d00"});
                is_label_visible = true;
            }, function () {
                dot.attr("r", 4);
				dot.attr({stroke: "#3f72bf"});
                leave_timer = setTimeout(function () {
                    /*frame.hide();
                    label[0].hide();
                    label[1].hide();
                    is_label_visible = false;*/
                }, 1);
            });
        })(x, y, data[i], labels[i], dot, urls[i]);
    }
    //p = p.concat([x, y, x, y]);
    //bgpp = bgpp.concat([x, y, x, y, "L", x, height - bottomgutter, "z"]);
	// ocultar rayas
    //path.attr({path: p});
    //bgp.attr({path: bgpp});
    frame.toFront();
    label[0].toFront();
    label[1].toFront();
    blanket.toFront();
};