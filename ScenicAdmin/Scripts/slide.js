$(document).ready(function () { $('a[href="#"]').each(function () { $(this).attr("href", "javascript:void(0)") }); $(".perform li").each(function () { var d = $(this); $(this).find(".s").click(function () { var e = $(this).index(); d.find(".s").removeClass("on").eq(e).addClass("on"); d.find(".info").hide().eq(e).fadeIn(500) }) }); $(".artist_l li").each(function (d) { $(this).find("a").css("top", -$(this).height()); $(this).hover(function () { $(this).find("a").animate({ top: "0" }, 200) }, function () { $(this).find("a").animate({ top: $(this).height() }, { duration: 200, complete: function () { $(this).css("top", -$(this).parent("li").height()) } }) }) }); $("#calendar td").live("mouseover", function () { $("#calendar td").removeClass("hover"); $(this).addClass("hover") }); $(".category_list .item").each(function (d) { $(this).hover(function () { $(".category_list .item").removeClass("on").eq(d).addClass("on"); $(".category_list ol").hide().eq(d).show() }, function () { $(this).find("ol").hide(); $(this).removeClass("on") }) }); $(".u_city_a li").each(function (d) { $(this).click(function () { if (d == 10) { return false } $(".u_city_nav li").removeClass("on").eq(d).addClass("on"); $(".u_city_nav p").hide().eq(d).show() }) }); var b = 0; var a = 0; $(".u_city_nav .more").click(function () { if (b == 1) { $(this).removeClass("on"); $(".s_citys").hide(200); b = 0 } else { $(this).addClass("on"); $(".s_citys").show(200); b = 1 } return false }); $(".s_citys").hover(function () { a = 1 }, function () { a = 0 }); $("body").bind("click", function () { if (b == 1 && a == 0) { $(".s_citys").hide(200); $(".u_city_nav .more").removeClass("on"); b = 0 } }); function c() { if ($(".scroll_txt li").length <= 1) { return } var d = $(".scroll_txt li:last"); d.hide(); $(".scroll_txt li:last").remove(); $(".scroll_txt li:first").before(d); d.slideDown(500) } window.setInterval(c, 5000); $(".live_top li").each(function (d) { $(this).hover(function () { $(".live_top li").removeClass("on").eq(d).addClass("on") }) }); $(".list_1 li").each(function (d) { $(this).hover(function () { $(".list_1 li").removeClass("on").eq(d).addClass("on") }) }); $(".vote_m dd").each(function (d) { $(this).click(function () { $(".vote_m dd").removeClass("on").eq(d).addClass("on") }) }); $(".tr_commend dl").each(function (d) { $(this).hover(function () { $(".tr_commend dl").removeClass("on").eq(d).addClass("on") }) }); $(".ticketInfo .help").hover(function () { $(".minTips").fadeIn("fast") }, function () { $(".minTips").fadeOut("fast") }); $(".videoList li").hover(function () { $(this).addClass("on") }, function () { $(this).removeClass("on") }); $(".min_tip .tab_min_b a").each(function (d) { $(this).click(function () { $(".tab_min_b a").removeClass("on").eq(d).addClass("on") }) }); $(".news_list li").hover(function () { $(this).addClass("on") }, function () { $(this).removeClass("on") }); $(".tr_pic_list li").hover(function () { $(this).addClass("on") }, function () { $(this).removeClass("on") }); $("#city").height("auto"); $(".sift .expand").html("\u6536\u7f29"); $(".sift .expand").toggle(function () { $("#city").height(24); $(this).html("\u5c55\u5f00") }, function () { $("#city").height("auto"); $(this).html("\u6536\u7f29") }); $(".sift .toggle .s_down").live("click", function () { $(".sift dl:gt(1)").show(); $(".sift dl:eq(1)").removeClass("noborder"); $(this).hide(); $(".sift .toggle .s_up").show() }); $(".sift .toggle .s_up").live("click", function () { $(".sift dl:gt(1)").hide(); $(".sift dl:eq(1)").addClass("noborder"); $(this).hide(); $(".sift .toggle .s_down").show() }); $(".hzlist .hztitle").each(function (d) { $(this).click(function () { $(".hzlist .info") }) }); $(".buy_caption .tab_t a").each(function (d) { $(this).click(function () { $(".buy_caption .tab_t a").removeClass("on").eq(d).addClass("on"); $(".buy_caption dl").hide().eq(d).show() }) }); $(".vocal_list li .t .c7").click(function () { $(this).parent().parent().find(".t").show(); $(this).parent().hide() }) }); $(document).ready(function () { var m = false; var l = ""; var i = 500; var o = 950;/*thanks for damai.com*/ var f = $("#actor li").length; var g = f * 18; var a = (o - (g + 26)) / 2; var b = 0; $("#actor").width(o * f); $("#actor li").each(function (c) { l += "<span></span>" }); $("#numInner").width(g).html(l); $("#imgPlay .mc").width(g); $("#imgPlay .num").css("left", a); $("#numInner").css("left", a + 13); $("#numInner span:first").addClass("on"); function d(n, c) { n = $(n) ? $(n) : n; n.addClass(c).siblings().removeClass(c) } $("#imgPlay .next").click(function () { h(1) }); $("#imgPlay .prev").click(function () { h(-1) }); function h(c) { if ($("#actor").is(":animated") == false) { b += c; if (b != -1 && b != f) { $("#actor").animate({ marginLeft: -b * o + "px" }, i) } else { if (b == -1) { b = f - 1; $("#actor").css({ marginLeft: -(o * (b - 1)) + "px" }); $("#actor").animate({ marginLeft: -(o * b) + "px" }, i) } else { if (b == f) { b = 0; $("#actor").css({ marginLeft: -o + "px" }); $("#actor").animate({ marginLeft: 0 + "px" }, i) } } } d($("#numInner span").eq(b), "on") } } $("#numInner span").click(function () { b = $(this).index(); e(b); d($("#numInner span").eq(b), "on") }); function e(c) { if ($("#actor").css("marginLeft") != -c * o + "px") { $("#actor").css("marginLeft", -c * o + "px"); $("#actor").fadeOut(0, function () { $("#actor").fadeIn(500) }) } } function j() { m = setInterval(function () { h(1) }, 5000) } function k() { if (m) { clearInterval(m) } } $("#imgPlay").hover(function () { k() }, function () { j() }); j() }); $(document).ready(function () { var b = false; var a = false; $(".s_city .s").click(function () { if (b == false) { $(".s_c_links").show(200); $(this).addClass("on"); b = true } else { $(".s_c_links").hide(200); $(this).removeClass("on"); b = false } return false }); $(".s_c_links").hover(function () { a = true }, function () { a = false }); $("body").bind("click", function () { if (b == true && a == false) { $(".s_c_links").hide(200); $(".s_city .s").removeClass("on"); b = false } }) }); $(document).ready(function () { $(".sd").each(function (a) { $(this).find(".hztitle").click(function () { $(".sd").eq(a).find("p").toggle() }) }); $(".hztitle").toggle(function () { $(this).addClass("hztitle-2") }, function () { $(this).removeClass("hztitle-2") }) }); function loadpic() { var b = $("#artist_photo").width() / $("#artist_photo").height(); if (b < 1) { if ($("#artist_photo").height() > 243) { $("#artist_photo").height(243) } } else { if ($("#artist_photo").width() > 243) { $("#artist_photo").width(243) } var a = 243 - $("#artist_photo").height(); $("#artist_photo").css("marginTop", a / 2) } } function artHeight() { var e = $(".artists_r").height(); var c = $(".artists_l").height(); var d = $(".artists_l .tab_min_in").height(); var a = e - c; if (a > 0) { var b = c + a - 12; $(".artists_l").height(b) } if (e - d < 90) { $(".artists_l").height("auto") } } $(document).ready(function () { $(".q-seat .seat-i").hover(function () { $(".q-seat .new-infos").fadeIn("fast") }, function () { $(".q-seat .new-infos").fadeOut("fast") }); $(".scare-infos .txt").click(function () { $(".scare-infos .scare-notes").fadeIn("fast") }); $(".scare-notes-close").click(function () { $(".scare-infos .scare-notes").fadeOut("fast") }); $(".scare-infos .ok-btn").click(function () { $(".scare-infos .scare-notes").fadeOut("fast") }); if ($(".option-rob-ticket").css("display") == "block") { $(".option .bd").height(311) } else { $(".option .bd").height("auto") } $(".count-down-box").hover(function () { $(".count-down-msg").fadeIn("fast") }, function () { $(".count-down-msg").fadeOut("fast") }) });