//========= owl carousel main banner =========
$(function () {
  $("#main-banner").owlCarousel({
    items: 1,
    autoplay: true,
    autoplaySpeed: 1000,
    smartSpeed: 1200,
    dots: true,
    // autopalyTimeout: 5000, //5s
    // autoplayHoverPause: true,
    // doc: false,
    freeDrag: true,
    loop: true,
    nav: true,
    navText: ["<i class='fas fa-angle-left'></i>", "<i class='fas fa-angle-right'></i>"],
  });
});
//========= owl carousel main banner =========

// ========= burger dropdown ========= 
$(".header .header-left .burger").click(function (e) { 
  e.preventDefault();
  $(".burger-dropdown").addClass("burger-dropdown-active");
  console.log("h");
});

$(".btn-out .fa-times").click(function (e) { 
  e.preventDefault();
  $(".burger-dropdown").removeClass("burger-dropdown-active");
});
// ========= burger dropdown ========= 

//========= owl carousel latest product =========
$(function () {
  $("#latest-product").owlCarousel({
    items: 4,
    autoplay: true,
    autoplaySpeed: 1000,
    smartSpeed: 1200,
    dots: false,
    // autopalyTimeout: 5000, //5s
    // autoplayHoverPause: true,
    // doc: false,
    loop: true,
    nav: true,
    navText: ["<i class='fas fa-angle-left'></i>", "<i class='fas fa-angle-right'></i>"],
    responsive: {
      0: {
        items: 1,
        nav: false,
      },
      411: {
        items: 2,
        nav: false,
      },
      769: {
        items: 4,
        nav: true,
      }
    },
  });
  
  const latestProducts = [
    {
      "id": 1,
      "srcimg": "./images/latest-product/latest-product-1.jpg",
      "name": "Fixair Product Sample",
      "price": 120.00,
    },
    {
      "id": 2,
      "srcimg": "./images/latest-product/latest-product-2.jpg",
      "name": "Fixair Product Sample",
      "price": 40.00,
    },
    {
      "id": 3,
      "srcimg": "./images/latest-product/latest-product-3.jpg",
      "name": "Fixair Product Sample",
      "price": 20.00,
    },
    {
      "id": 4,
      "srcimg": "./images/latest-product/latest-product-4.jpg",
      "name": "Fixair Product Sample",
      "price": 60.00,
    },
    {
      "id": 5,
      "srcimg": "./images/latest-product/latest-product-5.jpg",
      "name": "Fixair Product Sample",
      "price": 70.00,
    },
    {
      "id": 6,
      "srcimg": "./images/latest-product/latest-product-6.jpg",
      "name": "Fixair Product Sample",
      "price": 10.00,
    },
  ];
  renderOwl(latestProducts, ".latest-product .container .owl-carousel");
  

});

function renderOwl(list, selector) {

  list.reverse().map((val, index) => {
    // $(".rate").empty();
    $(selector) 
    .trigger("add.owl.carousel", [
    `
    <div class="slide">
      <div class="img-product">
        <img src="${val.srcimg}" alt="">
      </div>
      <div class="btn-add">
        <i class="fas fa-plus"></i>
      </div>
      <div class="info-product">
        <div class="${val.name}">Bright Blush Powder</div>
        <div class="price">$${val.price}</div>
      </div>
    </div>  
    `
    , index,])
    .trigger("refresh.owl.carousel");
  })
}

//========= owl carousel latest product =========

// ========= best seller ========= 
$(function () {
  const bestSellerProducts = [
    {
      "id": 1,
      "srcimg": "./images/best-seller/bsl-prod-1.jpg",
      "srcimgChange": "./images/bsl-changeImg-1.jpg",
      "name": "Fixair Product Sample",
      "price": 120.00,
    },
    {
      "id": 2,
      "srcimg": "./images/best-seller/bsl-prod-2.jpg",
      "srcimgChange": "./images/bsl-changeImg-2.jpg",
      "name": "Fixair Product Sample",
      "price": 40.00,
    },
    {
      "id": 3,
      "srcimg": "./images/best-seller/bsl-prod-3.jpg",
      "srcimgChange": "./images/bsl-changeImg-3.jpg",
      "name": "Fixair Product Sample",
      "price": 20.00,
    },
    {
      "id": 4,
      "srcimg": "./images/best-seller/bsl-prod-4.jpg",
      "srcimgChange": "./images/bsl-changeImg-4.jpg",
      "name": "Fixair Product Sample",
      "price": 60.00,
    },
    {
      "id": 5,
      "srcimg": "./images/best-seller/bsl-prod-5.jpg",
      "srcimgChange": "./images/bsl-changeImg-5.jpg",
      "name": "Fixair Product Sample",
      "price": 70.00,
    },
    {
      "id": 6,
      "srcimg": "./images/best-seller/bsl-prod-6.jpg",
      "srcimgChange": "./images/bsl-changeImg-6.jpg",
      "name": "Fixair Product Sample",
      "price": 10.00,
    },
  ];

  renderBestSellerProducts(bestSellerProducts);

});

//animation hover change img
function setNewImage(id) {
  document.getElementById(id).src = `./images/best-seller/bsl-changeImg-${id}.jpg`
}
function setOldImage(id) {
  document.getElementById(id).src = `./images/best-seller/bsl-prod-${id}.jpg`
}

function renderBestSellerProducts(list) {
  list.map((val, index) => {
    $(
    `
    <div class="item">
      <div class="image">
        <img id="${val.id}" 
        onmouseover="setNewImage(${val.id})" 
        onmouseout="setOldImage(${val.id})" 
        src="${val.srcimg}" 
        alt="">
      </div>
      <div class="content">
        <p class="name-product">${val.name}</p>
        <span class="price-product">$${val.price}</span>
      </div>
    </div>
  `
    ).appendTo(".best-seller .items");
  })
}

  
// ========= best seller ========= 

// ========= beauty club blog ========= 
$(function () {
  const beautyClubBlog = [
    {
      "id": 1,
      "srcimg": "./images/beauty-club-blog/beauty-club-blog-1.jpg",
      "name": "FALL-ING FOR YOU — BEAUTY TRENDS WE'RE OBSESSING OVER", 
      "date": "SEPTEMBER 12, 2021"
    },
    {
      "id": 2,
      "srcimg": "./images/beauty-club-blog/beauty-club-blog-2.jpg",
      "name": "ROUTINE REBEL — BEAUTY TIPS", 
      "date": "MAY 29, 2021"
    },
    {
      "id": 3,
      "srcimg": "./images/beauty-club-blog/beauty-club-blog-3.jpg",
      "name": "BEAUTY BUYS — MUST-HAVES IN YOUR BAG THIS FALL", 
      "date": "APRIL 19, 2021"
    },
  ];

  renderBeautyClubBlog(beautyClubBlog);

});
function renderBeautyClubBlog(list) {
  list.map((val, index) => {
    $(
    `
    <div class="item" style="background-image:url(${val.srcimg});">
      <div class="content">
        <a href="">${val.name}</a>
        <span class="date">${val.date}</span>
        <a class="continue" href="">Continue reading</a>
      </div>
    </div>
  `
    ).appendTo(".beauty-club-blog .items");
  })
}
// ========= beauty club blog ========= 



