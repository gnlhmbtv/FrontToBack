// $('.portfolio-item').isotope({
//     itemSelector: '.item',
//     layoutMode: 'fitRows'
// });
// $('.portfolio-menu ul li').click(function(){
//     $('portfolio-menu ul li').removeClass('active');
//     $(this).addClass('active');

//     var selector = $(this).attr('data-filter');
//     $('.portfolio-item').isotope({
//         filter:selector
//     });
//     return false;
// });
$(document).ready(function(){
    $(".slider2").owlCarousel(
        {
            items: 1,
            loop: true,
            autoplay: true
        }
    );
    $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        nav: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 3
            },
            1000: {
                items: 4
            }
        }
    })
});