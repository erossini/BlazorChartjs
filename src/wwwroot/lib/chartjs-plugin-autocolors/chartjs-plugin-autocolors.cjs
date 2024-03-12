/*!
 * chartjs-plugin-autocolors v0.2.2
 * https://github.com/kurkle/chartjs-plugin-autocolors#readme
 * (c) 2023 Jukka Kurkela <jukka.kurkela@gmail.com>
 * Released under the MIT license
 */
(function (global, factory) {
typeof exports === 'object' && typeof module !== 'undefined' ? module.exports = factory() :
typeof define === 'function' && define.amd ? define(factory) :
(global = typeof globalThis !== 'undefined' ? globalThis : global || self, global["chartjs-plugin-autocolors"] = factory());
})(this, (function () { 'use strict';

/*!
 * @kurkle/color v0.3.2
 * https://github.com/kurkle/color#readme
 * (c) 2023 Jukka Kurkela
 * Released under the MIT License
 */
function round(v) {
  return v + 0.5 | 0;
}
const lim = (v, l, h) => Math.max(Math.min(v, h), l);
function n2b(v) {
  return lim(round(v * 255), 0, 255);
}
function b2n(v) {
  return lim(round(v / 2.55) / 100, 0, 1);
}
function hsv2rgbn(h, s, v) {
  const f = (n, k = (n + h / 60) % 6) => v - v * s * Math.max(Math.min(k, 4 - k, 1), 0);
  return [f(5), f(3), f(1)];
}
function calln(f, a, b, c) {
  return (
    Array.isArray(a)
      ? f(a[0], a[1], a[2])
      : f(a, b, c)
  ).map(n2b);
}
function hsv2rgb(h, s, v) {
  return calln(hsv2rgbn, h, s, v);
}
function rgbString(v) {
  return v && (
    v.a < 255
      ? `rgba(${v.r}, ${v.g}, ${v.b}, ${b2n(v.a)})`
      : `rgb(${v.r}, ${v.g}, ${v.b})`
  );
}

function* hueGen() {
  yield 0;
  while (true) {
    for (let i = 1; i < 10; i++) {
      const d = 1 << i;
      for (let j = 1; j <= d; j += 2) {
        yield j / d;
      }
    }
  }
}

function* colorGen(repeat = 1) {
  const hue = hueGen();
  let h = hue.next();
  while (!h.done) {
    let rgb = hsv2rgb(Math.round(h.value * 360), 0.6, 0.8);
    for (let i = 0; i < repeat; i++) {
      yield {background: rgbString({r: rgb[0], g: rgb[1], b: rgb[2], a: 192}), border: rgbString({r: rgb[0], g: rgb[1], b: rgb[2], a: 144})};
    }
    rgb = hsv2rgb(Math.round(h.value * 360), 0.6, 0.5);
    for (let i = 0; i < repeat; i++) {
      yield {background: rgbString({r: rgb[0], g: rgb[1], b: rgb[2], a: 192}), border: rgbString({r: rgb[0], g: rgb[1], b: rgb[2], a: 144})};
    }
    h = hue.next();
  }
}

function setColors(dataset, background, border) {
  dataset.backgroundColor = dataset.backgroundColor || background;
  dataset.borderColor = dataset.borderColor || border;
  return dataset.backgroundColor === background && dataset.borderColor === border;
}

function getNext(color, customize, context) {
  const c = color.next().value;
  if (typeof customize === 'function') {
    return customize(Object.assign({colors: c}, context));
  }
  return c;
}

var index = {
  id: 'autocolors',
  beforeUpdate(chart, args, options) {
    const {mode = 'dataset', enabled = true, customize, repeat} = options;

    if (!enabled) {
      return;
    }

    const gen = colorGen(repeat);

    if (options.offset) {
      // offset the color generation by n colors
      for (let i = 0; i < options.offset; i++) {
        gen.next();
      }
    }

    if (mode === 'label') {
      return labelMode(chart, gen, customize);
    }

    const datasetMode = mode === 'dataset';

    let c = getNext(gen, customize, {chart, datasetIndex: 0, dataIndex: datasetMode ? undefined : 0});
    for (const dataset of chart.data.datasets) {
      if (datasetMode) {
        if (setColors(dataset, c.background, c.border)) {
          c = getNext(gen, customize, {chart, datasetIndex: dataset.index});
        }
      } else {
        const background = [];
        const border = [];
        for (let i = 0; i < dataset.data.length; i++) {
          background.push(c.background);
          border.push(c.border);
          c = getNext(gen, customize, {chart, datasetIndex: dataset.index, dataIndex: i});
        }
        setColors(dataset, background, border);
      }
    }
  }
};

function labelMode(chart, gen, customize) {
  const colors = {};
  for (const dataset of chart.data.datasets) {
    const label = dataset.label ?? '';
    if (!colors[label]) {
      colors[label] = getNext(gen, customize, {chart, datasetIndex: 0, dataIndex: undefined, label});
    }
    const c = colors[label];
    setColors(dataset, c.background, c.border);
  }
}

return index;

}));
//# sourceMappingURL=chartjs-plugin-autocolors.cjs.map
