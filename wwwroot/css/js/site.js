(function () {
    const savedTheme = localStorage.getItem('theme') || 'dark';
    document.documentElement.setAttribute('data-theme', savedTheme);

    window.addEventListener('DOMContentLoaded', function () {
        const toggleBtn = document.getElementById('theme-toggle');
        
        if (!toggleBtn) {
            console.error("HATA: 'theme-toggle' ID'sine sahip buton bulunamadı!");
            return;
        }

        console.log("Tema butonu başarıyla bulundu, tıklama dinleyicisi ekleniyor.");
        updateIcon(savedTheme);

        toggleBtn.addEventListener('click', function () {
            console.log("Butona tıklandı!");
            const current = document.documentElement.getAttribute('data-theme');
            const next = current === 'dark' ? 'light' : 'dark';
            
            console.log("Tema şuradan değişiyor:", current, "->", next);
            document.documentElement.setAttribute('data-theme', next);
            localStorage.setItem('theme', next);
            updateIcon(next);
        });
    });

    function updateIcon(theme) {
        const icon = document.getElementById('theme-icon');
        if (!icon) return;
        icon.className = theme === 'dark' ? 'bi bi-sun' : 'bi bi-moon-stars';
    }
})();