//window.theme = {
//    initTheme: function () {
//        var savedTheme = localStorage.getItem('theme');
//        if (savedTheme === 'dark') {
//            document.body.classList.add('dark-mode');
//            return true;
//        }
//        return document.body.classList.contains('dark-mode');
//    },

//    setDarkMode: function (isDark) {
//        if (isDark) {
//            document.body.classList.add('dark-mode');
//            localStorage.setItem('theme', 'dark');
//        } else {
//            document.body.classList.remove('dark-mode');
//            localStorage.setItem('theme', 'light');
//        }
//    }
//};
window.theme = {
    initTheme: function () {
        var savedTheme = localStorage.getItem('theme');
        if (savedTheme === 'dark') {
            document.body.classList.add('dark-mode');
            return true;
        } else if (savedTheme === 'light') {
            document.body.classList.remove('dark-mode');
            return false;
        }
        
        return document.body.classList.contains('dark-mode');
    },

    setDarkMode: function (isDark) {
        if (isDark) {
            document.body.classList.add('dark-mode');
            localStorage.setItem('theme', 'dark');
        } else {
            document.body.classList.remove('dark-mode');
            localStorage.setItem('theme', 'light');
        }
    }
};