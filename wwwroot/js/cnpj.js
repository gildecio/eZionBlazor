window.formatCnpj = function (value) {
  if (!value) return "";
  const digits = ("" + value).replace(/\D/g, "").slice(0, 14);
  const p1 = digits.slice(0, 2);
  const p2 = digits.slice(2, 5);
  const p3 = digits.slice(5, 8);
  const p4 = digits.slice(8, 12);
  const p5 = digits.slice(12, 14);
  let out = "";
  if (p1) out += p1;
  if (p2) out += "." + p2;
  if (p3) out += "." + p3;
  if (p4) out += "/" + p4;
  if (p5) out += "-" + p5;
  return out;
};

window.cnpjMaskAttach = function (el) {
  if (!el) return;
  function apply() {
    const start = el.selectionStart;
    const end = el.selectionEnd;
    el.value = window.formatCnpj(el.value);
    try { el.setSelectionRange(start, end); } catch {}
  }
  el.addEventListener('input', apply);
  el.addEventListener('blur', apply);
  apply();
};