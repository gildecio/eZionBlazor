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