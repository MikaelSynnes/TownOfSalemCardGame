window.sessionCookie = {
    set: function (name, value, days) {
        let expires = "";
        if (days) {
            const date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toUTCString();
        }
        document.cookie = name + "=" + (value || "") + expires + "; path=/";
    },
    get: function (name) {
        const nameEQ = name + "=";
        const ca = document.cookie.split(';');
        for (let i = 0; i < ca.length; i++) {
            let c = ca[i];
            while (c.charAt(0) === ' ') c = c.substring(1, c.length);
            if (c.indexOf(nameEQ) === 0) return c.substring(nameEQ.length, c.length);
        }
        return null;
    },
    erase: function (name) {
        document.cookie = name + '=; Max-Age=-99999999;';
    }
};

window.previousSessions = {
    _key: "previousSessions",
    getAll: function () {
        try {
            const raw = localStorage.getItem(this._key);
            return raw ? JSON.parse(raw) : [];
        } catch { return []; }
    },
    save: function (sessionId, username) {
        let sessions = this.getAll();
        sessions = sessions.filter(s => !(s.sessionId === sessionId && s.username === username));
        sessions.unshift({ sessionId, username, savedAt: new Date().toISOString() });
        if (sessions.length > 10) sessions = sessions.slice(0, 10);
        localStorage.setItem(this._key, JSON.stringify(sessions));
    },
    remove: function (sessionId, username) {
        let sessions = this.getAll().filter(s => !(s.sessionId === sessionId && s.username === username));
        localStorage.setItem(this._key, JSON.stringify(sessions));
    }
};
