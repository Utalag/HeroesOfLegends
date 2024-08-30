const slider1 = document.getElementById('slider1');
const slider2 = document.getElementById('slider2');
const slider3 = document.getElementById('slider3');

slider1.addEventListener('input', updateSliders);
slider2.addEventListener('input', updateSliders);
slider3.addEventListener('input', updateSliders);

function updateSliders() {
    const min = Math.min(slider1.value, slider2.value);
    const max = Math.max(slider1.value, slider2.value);
    slider3.min = min;
    slider3.max = max;
    console.log(`Min: ${min}, Max: ${max}, Selected: ${slider3.value}`);
}