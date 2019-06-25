// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
try {
    var storTest = window['localStorage'];
    storTest.setItem("", ".");
    storTest.removeItem("");
}
catch (e) { alert("This browser does not support local storage. Try updating or switching browsers."); }
