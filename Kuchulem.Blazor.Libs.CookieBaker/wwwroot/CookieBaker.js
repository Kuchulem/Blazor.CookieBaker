if (!window.k6m)
    window.k6m = {};

window.k6m.cookieBaker = {
    /**
     * Gets the cookie data
     */
    get: () => document.cookie,
    /**
     * Sets a new cookie
     */
    set: (data) => document.cookie = data
}