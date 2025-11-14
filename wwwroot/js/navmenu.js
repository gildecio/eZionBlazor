document.addEventListener('DOMContentLoaded', function () {
  var toggles = document.querySelectorAll('.menu-toggle');
  toggles.forEach(function (t) {
    t.addEventListener('click', function (e) {
      e.preventDefault();
      var node = t.closest('.menu-node');
      if (!node) return;
      node.classList.toggle('expanded');
      var submenu = node.querySelector(':scope > .submenu');
      if (!submenu) return;
      if (node.classList.contains('expanded')) {
        submenu.style.maxHeight = submenu.scrollHeight + 'px';
      } else {
        submenu.style.maxHeight = '0px';
      }
    });
  });
});

window.navmenu = {
  registerOutsideClose: function (dotnetRef) {
    document.addEventListener('click', function (e) {
      var container = document.querySelector('.nav-item-contabil');
      if (!container) return;
      if (!container.contains(e.target)) {
        try { dotnetRef.invokeMethodAsync('CloseContabil'); } catch (err) { /* noop */ }
      }
    });
  }
};