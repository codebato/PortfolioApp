(function () {

    const savedTheme = localStorage.getItem("theme") || "dark";
    document.documentElement.setAttribute("data-theme", savedTheme);

    const toggleBtn = document.getElementById("theme-toggle");
    const icon = document.getElementById("theme-icon");

    function updateIcon(theme) {
        if (!icon) return;
        icon.className = theme === "dark"
            ? "bi bi-sun"
            : "bi bi-moon-stars";
    }

    updateIcon(savedTheme);

    if (toggleBtn) {
        toggleBtn.addEventListener("click", function () {

            const current = document.documentElement.getAttribute("data-theme") || "dark";
            const next = current === "dark" ? "light" : "dark";

            document.documentElement.setAttribute("data-theme", next);
            localStorage.setItem("theme", next);

            updateIcon(next);
        });
    }

})();