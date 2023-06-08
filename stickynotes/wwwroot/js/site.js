// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener('DOMContentLoaded', function () {
    const stickyNotes = document.getElementsByClassName('stickynote');

    function resizeText() {
        for (let i = 0; i < stickyNotes.length; i++) {
            const stickyNote = stickyNotes[i];
            const text = stickyNote.querySelector('p');

            let fontSize = 12; // Set an initial font size in pt
            text.style.fontSize = fontSize + 'pt';

            while (
                text.scrollHeight > stickyNote.offsetHeight ||
                text.scrollWidth > stickyNote.offsetWidth
            ) {
                fontSize -= 1;
                text.style.fontSize = fontSize + 'pt';
            }
        }
    }

    resizeText();
});
