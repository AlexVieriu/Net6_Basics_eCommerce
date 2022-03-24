(function (window) {
    window.logUser = window.logUser ||
        function (counter) {
            console.log(`Printing in JavaScript counter: ${counter}`);
        }
})(window);