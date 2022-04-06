$(document).ready(function () {

    

    // ============# Header Dropdown #=================

    let drop_btn = document.getElementById("drop_btn");
    let dropdown_user = document.getElementsByClassName("dropdown_user")[0];
    let drop_icon = document.getElementsByClassName("fa-angle-down")[0];

    drop_btn.addEventListener("click", function (e) {
        e.preventDefault();
        if (dropdown_user.classList.contains("drop_show")) {
            dropdown_user.classList.remove("drop_show");
            drop_icon.style.transform = "rotate(0deg)";
        } else {
            dropdown_user.classList.add("drop_show");
            drop_icon.style.transform = "rotate(-180deg)";
        }
    });

    // ==================================================

    //============# Sidebar Active Link #================
    let sidebar = document.querySelector(".sidebar");
    let sidmenu_link = document.getElementsByClassName("sidmenu-link");

    for (let j = 0; j < sidmenu_link.length; j++) {
        sidmenu_link[j].addEventListener("click", function (e) {
            e.preventDefault();

            let sub_ul = this.nextElementSibling;
            let icon = this.lastElementChild;

            if (sub_ul.style.display === "block") {
                sub_ul.style.display = "none";
                icon.style.transition = ".4s";
                icon.style.transform = "rotate(0deg)";
            } else {
                sub_ul.style.display = "block";
                icon.style.transition = ".4s";
                icon.style.transform = "rotate(90deg)";
            }
        });
    }
    //===================================================

    //===============# Header Button #===================

    let header_link = document.querySelector(".header_link");
    let sidmenu_link_All = document.querySelectorAll(".sidmenu_link_All");
    let header_left = document.querySelector(".header_left");
    let main=document.getElementsByTagName("main")[0]
    
    header_link.addEventListener("click", function (e) {
        e.preventDefault();

        let sidmenu_title = document.getElementsByClassName("sidmenu-title");

        if (header_left.style.width === "320px") {
            for (let i = 0; i < sidmenu_link_All.length; i++) {
                sidmenu_link_All[i].classList.add("spanactive");
            }
            header_left.style.width = "85px";

            for (let i = 0; i < sidmenu_title.length; i++) {
                sidmenu_title[i].style.opacity = "0";
            }
            sidebar.style.width = "85px";
            main.style.paddingLeft="85px"
            header_left.style.transition = ".4s all";
            sidebar.style.transition = ".4s all";
            main.style.transition=".4s all"

            for (let i = 0; i < sidmenu_link.length; i++) {
                let ul = sidmenu_link[i].nextElementSibling;
                
                ul.style.display="none"
            }
        } else {
            for (let i = 0; i < sidmenu_link_All.length; i++) {
                sidmenu_link_All[i].classList.remove("spanactive");
            }

            for (let i = 0; i < sidmenu_title.length; i++) {
                sidmenu_title[i].style.opacity = "1";
            }
            header_left.style.width = "320px";
            sidebar.style.width = "320px";
            main.style.paddingLeft="320px"
        }

        // ==================# Sidebar Hover #=================================
        $(sidebar).hover(
            function () {
                if (header_left.style.width === "85px") {
                    for (let i = 0; i < sidmenu_link_All.length; i++) {
                        sidmenu_link_All[i].classList.remove("spanactive");
                    }

                    for (let i = 0; i < sidmenu_title.length; i++) {
                        sidmenu_title[i].style.opacity = "1";
                    }
                    sidebar.style.width = "270px";
                }
            },
            function () {
                if (header_left.style.width === "320px") {
                    for (let i = 0; i < sidmenu_link_All.length; i++) {
                        sidmenu_link_All[i].classList.remove("spanactive");
                    }

                    for (let i = 0; i < sidmenu_title.length; i++) {
                        sidmenu_title[i].style.opacity = "1";
                    }
                    sidebar.style.width = "320px";

                    
                } else {
                    for (let i = 0; i < sidmenu_link_All.length; i++) {
                        sidmenu_link_All[i].classList.add("spanactive");
                    }

                    for (let i = 0; i < sidmenu_title.length; i++) {
                        sidmenu_title[i].style.opacity = "0";
                    }
                    sidebar.style.width = "85px";

                    for (let i = 0; i < sidmenu_link.length; i++) {
                        let ul = sidmenu_link[i].nextElementSibling;
                        ul.style.display="none"
                    }
                }
            }
        );

        // ==================================================================
    });


    // ==================# Mobil Nav Button #===========================

    let mobile_btn=document.querySelector(".mobile_btn");
    let overlay= document.querySelector(".overlay")
    mobile_btn.addEventListener("click" , function(){
        if(sidebar.classList.contains("left_active")){
            sidebar.classList.remove("left_active")
            overlay.style.display="none"
        }
        else{
            sidebar.classList.add("left_active")
            overlay.style.display="block"
        }
    })

    // ===============================================================
});


