const imgDiv= document.querySelector('.body1');
const img= document.querySelector('#photo');
const file=document.querySelector('#file');
const upload= document.querySelector('#Update');

imgDiv.addEventListener('mouseenter',function(){
    upload.style.display= "block";
});

imgDiv.addEventListener('mouseleave', function(){
    upload.style.display= "none";
});

file.addEventListener('change', function(){
    const choosedFile=this.files[0];
    if(choosedFile)
    {
        const reader= new FileReader();
        reader.addEventListener('load', function(){
            img.setAttribute('src',reader.result);
        });
        reader.readAsDataURL(choosedFile);
    }
})