function myFunction1() {
    // create element
    var img2 = document.createElement('img');
    img2.src="../car2.png";
    img2.id="img2";
    img2.width="300";
    img2.height="300";
    var s = document.getElementById("div1");
    s.appendChild(img2).insertBefore('img1');
    myFunction2();
    // document.appendChild("img2");
    // window.appendChild(img2);
}

function myFunction2() {
    // Remove 'btn1' from the document
    document.getElementById('btn1').remove();
}
