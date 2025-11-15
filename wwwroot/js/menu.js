window.navMenuRegister = function(dotnetRef, rootId) {
  const root = document.getElementById(rootId);
  function onDocClick(e) {
    if (!root) return;
    if (!root.contains(e.target)) {
      dotnetRef.invokeMethodAsync('CloseAll');
    }
  }
  document.addEventListener('click', onDocClick);
};

window.getSelectedEmpresaId = function () {
  try {
    return localStorage.getItem('selectedEmpresaId') || "";
  } catch {
    return "";
  }
};

window.setSelectedEmpresaId = function (value) {
  try {
    if (value) {
      localStorage.setItem('selectedEmpresaId', value);
    } else {
      localStorage.removeItem('selectedEmpresaId');
    }
  } catch {}
};

window.getAuthUser = function () {
  try {
    return localStorage.getItem('authUser') || "";
  } catch {
    return "";
  }
};

window.setAuthUser = function (user) {
  try {
    if (user) {
      localStorage.setItem('authUser', user);
    } else {
      localStorage.removeItem('authUser');
    }
  } catch {}
};

window.clearAuthUser = function () {
  try {
    localStorage.removeItem('authUser');
  } catch {}
};