﻿

// Create TypeWriter constructor function which shows the implementation of the typewriter effect
const TypeWriter = function (txtElement, words, wait = 3000) {
    this.txtElement = txtElement;
    this.words = words;
    this.txt = "";
    this.wordIndex = 0;
    this.wait = parseInt(wait, 10);
    this.isDeleting = false;
    this.type();
};

//type method
TypeWriter.prototype.type = function () {
    // current index of word
    const current = this.wordIndex % this.words.length;
    //get full text of current word
    const fullTxt = this.words[current];

    // check if deleting
    if (this.isDeleting) {
        // remove char
        this.txt = fullTxt.substring(0, this.txt.length - 1);
    } else {
        // add char
        this.txt = fullTxt.substring(0, this.txt.length + 1);
    }

    // insert txt into span
    this.txtElement.innerHTML = `<span class="type-txt">${this.txt}</span>`;

    //Initial type speed
    let typeSpeed = 100;

    if (this.isDeleting) {
        typeSpeed /= 2;
    }

    // if word is complete
    if (!this.isDeleting && this.txt === fullTxt) {
        // make pause at end
        typeSpeed = this.wait;
        //set deleting to true
        this.isDeleting = true;
    } else if (this.isDeleting && this.txt === "") {
        this.isDeleting = false;

        // move to next word
        this.wordIndex++;

        // pause before start typing
        typeSpeed = 500;
    }
    setTimeout(() => this.type(), typeSpeed);
};

//Init on DOM load
document.addEventListener("DOMContentLoaded", init);

function init() {
    const txtElement = document.querySelector(".type-writer");
    const words = JSON.parse(txtElement.getAttribute("data-words"));
    const wait = txtElement.getAttribute("data-wait");

    //INIT TypeWriter
    new TypeWriter(txtElement, words, wait);
}