let cur = '0', prev = '', oper = '', fresh = false;
const D = document.getElementById('disp');

function show() {
  D.textContent = cur;
}

function dig(d) {
  if (fresh) {
    cur = d;
    fresh = false;
  } else {
    cur = cur === '0' ? d : cur.length < 12 ? cur + d : cur;
  }
  show();
}

function dot() {
  if (!cur.includes('.')) cur += '.';
  show();
}

function op(o) {
  prev = cur;
  oper = o;
  fresh = true;
}

function calc() {
  if (!oper || !prev) return;
  const a = parseFloat(prev);
  const b = parseFloat(cur);
  let r;
  if (oper === '+') r = a + b;
  else if (oper === '-') r = a - b;
  else if (oper === '*') r = a * b;
  else if (oper === '/') r = b === 0 ? 'Xəta' : a / b;
  cur = r === 'Xəta' ? r : String(parseFloat(r.toFixed(10)));
  oper = '';
  prev = '';
  fresh = true;
  show();
}

function reset() {
  cur = '0';
  prev = '';
  oper = '';
  fresh = false;
  show();
}