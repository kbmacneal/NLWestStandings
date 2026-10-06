window.nlwestTheme = {
    isDark: false,
    setDarkMode: function (isDarkMode) {
        this.isDark = !!isDarkMode;
        document.documentElement.classList.toggle("app-dark-mode", this.isDark);
    },
    // Applies the persisted mode before first paint/circuit start so logos match immediately
    applyStored: function () {
        try {
            this.setDarkMode(JSON.parse(localStorage.getItem("CurrentMode")) === true);
        } catch (e) { }
    }
};

// Blazor enhanced navigation patches <html> attributes from the server response (which has no
// theme class), so re-apply the current mode whenever the class is dropped.
new MutationObserver(function () {
    var html = document.documentElement;
    if (html.classList.contains("app-dark-mode") !== window.nlwestTheme.isDark) {
        html.classList.toggle("app-dark-mode", window.nlwestTheme.isDark);
    }
}).observe(document.documentElement, { attributes: true, attributeFilter: ["class"] });
