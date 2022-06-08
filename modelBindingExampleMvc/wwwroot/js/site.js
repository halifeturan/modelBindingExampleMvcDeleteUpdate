// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function conf(id, ad) {
    if (confirm(ad + ' in Silme işlemini onaylıyor musunuz?')) {
        //submit butonun idsini çekeceğim ve butonun çalışma eventini tetikleyeceğim
        document.getElementById(id).click();
        alert(id + ' Silindi')
    }
    else {
        alert(ad + 'ın Silme iptal edildi')
    }
}


function hoba() {
    alert('asdasdasdsd')
}