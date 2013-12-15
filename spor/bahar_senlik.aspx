<%@ Page Language="VB" AutoEventWireup="false" CodeFile="bahar_senlik.aspx.vb" Inherits="bahar_senlik" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ESOGÜ SPOR SALONU</title>
    <meta charset="iso-8859-1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="styles/main.css" rel="stylesheet" type="text/css" media="all">
    <link href="styles/mediaqueries.css" rel="stylesheet" type="text/css" media="all">
    <!--[if lt IE 9]>
<link href="styles/ie/ie8.css" rel="stylesheet" type="text/css" media="all">
<script src="scripts/ie/css3-mediaqueries.min.js"></script>
<script src="scripts/ie/html5shiv.min.js"></script>
<![endif]-->
    <!-- Slider -->
    <link href="scripts/responsiveslides.js-v1.53/responsiveslides.css" rel="stylesheet" type="text/css" media="all">
    <style type="text/css">
        .auto-style1 {
            width: 100px;
            height: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="wrapper row1">
                <header id="header" class="full_width clear">
                    <hgroup>
                        <h1><a href="Default.aspx">ESOGÜ SPOR SALONU</a></h1>
                        <h2>ESOGÜ SPOR SALONU</h2>
                    </hgroup>
                    <div id="header-contact">
                        <ul class="list none">
                            <li><span class="icon-envelope"></span><a href="#">xxxx@ogu.edu.tr</a></li>
                            <li><span class="icon-phone"></span>+xx xxx xxxxxxxxxx</li>
                        </ul>
                    </div>
                </header>
            </div>



          

            <!-- ################################################################################################ -->
            <div class="wrapper row2">
                <nav id="topnav">
                    <ul class="clear">
                        <li class="active"><a href="Default.aspx" title="Homepage">Anasayfa</a></li>
                        <li><a class="active" href="yonetim.aspx" title="Yonetim">Yönetim</a></li>

                        <li><a class="drop" href="#" title="Pages">Aktiviteler</a>
                            <ul>
                                <li><a href="sahaaktivite.aspx" title="">Saha Aktiviteleri</a></li>
                                <li><a href="grupaktivite.aspx" title="">Grup Aktiviteleri</a></li>
                                <li><a href="fitness.aspx" title="">Fitness Merkezi</a></li>
                            </ul>
                        </li>
                        <li><a class="drop" href="#" title="Elements">Kayıt</a>
                            <ul>
                                <li><a href="kayit_hs.aspx" title="">Halı Saha</a></li>
                                <li><a href="kayit_fm.aspx" title="">Fitness Merkezi</a></li>
                                <li><a href="kayit_t.aspx" title="">Tenis</a></li>
                                <li><a href="kayit_ga.aspx" title="">Grup Aktiviteleri</a></li>
                            </ul>
                        </li>
                        <li><a class="active" href="bahar_senlik.aspx" title="bahar">Bahar Şenlikleri</a></li>
                         <li><a class="active" href="iletisim.aspx" title="iletisim">İletişim</a></li>
                    </ul>
                </nav>
            </div>
           
            <div>
                <asp:Table ID="Table1" runat="server"></asp:Table>

            </div>
                

            <div style="width:800px"  align="center">
              <table border="1" style="height: 414px; width: 1200px">
               <tr>
                   <td class="auto-style1"> 
            <h3> Bahar Şenliği:</h3>
         Eskişehir Osmangazi Üniversitesi Rektörlüğü tarafından düzenlenen ve 13-15 Mayıs 2013 tarihlerinde gerçekleşecek olan Bahar Şenliği 2013 başladı. Şenlik; Atatürk ve Gençlik Anıtı önünde saygı duruşunda bulunulması ve İstiklal Marşı okunmasını takiben şenlik yürüyüşü ile başlarken, Atatürk ve Gençlik Anıtı ile Spor Salonu önündeki şenlik alanı arasında yapılan yürüyüşe; Üniversite Yönetimi, akademik ve idari personel ile öğrenciler katıldı.

Şenlik alanında yapılan açılış töreninde konuşan ESOGÜ Rektör Yardımcısı Prof. Dr. İlhami Ünlüoğlu, konuşmasına Hatay Reyhanlı’da meydana gelen bombalı saldırıda hayatını kaybedenler ve yakınları için üzüntülerini ve başsağlığı dileklerini sunarak başlarken, saldırıyı kınadığını ve lanetlediğini söyledi. Bahar Şenliği 2013’ü Rektörlük olarak öğrencilerin sınavlarının en az etkileneceği zamana denk getirmeye çalıştıklarını belirten Prof. Dr. İlhami Ünlüoğlu; Bahar Şenliği’nin öğrencilerin stres atmasını, dinlenmesini ve motivasyonlarının yükselmesini sağlamayı amaçladığını ifade etti. Bahar Şenliği 2013 kapsamında çok sayıda konser, gösteri ve diğer etkinlikler bulunduğunu hatırlatan Prof. Dr. İlhami Ünlüoğlu, şenliklerin neşeli geçmesini diledi.

Şenlik açılış programı ESOGÜ Halkbilim Araştırma ve Uygulama Merkezi Ritim Grubu tarafından sunulan gösteri ve sonrasında 2013 Bahar Şenliği Fakülteler Arası Spor Müsabakaları kupa töreni ile devam etti. Açılış programı, şenlik pilavı ikramı ile sona erdi.<br />
&nbsp;<h3>Galeri:</h3>

                       <asp:Image ID="Image1" runat="server" ImageUrl="~/images/bahar senligi/senlik1-300x336.jpg" Height="300px" Width="336px" />
                       <asp:Image ID="Image3" runat="server"  ImageUrl="~/images/bahar senligi/senlik4-300x195.jpg" Height="300px" Width="336px" />
                       <asp:Image ID="Image2" runat="server"  ImageUrl="~/images/bahar senligi/senlik3-300x199.jpg" Height="300px" Width="336px" />

                       <br />
                       <br />
                       <h3>Etkinlik Programı:</h3>
                       <p>13 Mayıs- Gripin Konseri     Saat 20.30</p>
                       <p>14 Mayıs- Göksel Konseri     Saat 20.30</p>
                       <p>15 Mayıs- Gökhan Türkmen Konseri     Saat 20.30</p>
                       <h3>Tanıtım Videosu:</h3>

                       <iframe width="560" height="315" src="//www.youtube.com/embed/oazJ2TexUKw" frameborder="0" allowfullscreen></iframe>

                       
                       </table>

          </div>
                    
        <!-- Footer -->
        <div class="wrapper row2">
            <div id="footer" class="clear">
                <div class="one_quarter first">
                    <h2 class="footer_title">Footer Navigation</h2>
                    <nav class="footer_nav">
                        <ul class="nospace">
                            <li><a href="#">Home Page</a></li>
                            <li><a href="#">Our Services</a></li>
                            <li><a href="#">Meet the Team</a></li>
                            <li><a href="#">Blog</a></li>
                            <li><a href="#">Contact Us</a></li>
                            <li><a href="#">Gallery</a></li>
                            <li><a href="#">Portfolio</a></li>
                            <li><a href="#">Online Shop</a></li>
                        </ul>
                    </nav>
                </div>
                <div class="one_quarter">
                    <h2 class="footer_title">Latest Gallery</h2>
                    <ul id="ft_gallery" class="nospace spacing clear">
                        <li class="one_third first"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third first"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third first"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                        <li class="one_third"><a href="#">
                            <img src="images/demo/80x80.gif" alt=""></a></li>
                    </ul>
                </div>
                <div class="one_quarter">
                    <h2 class="footer_title">From Twitter</h2>
                    <div class="tweet-container">
                        <ul class="list none">
                            <li><strong>@<a href="#">name</a></strong> <span class="tweet_text">RT <span class="at">@</span><a href="#">name</a> Donec suscipit vehicula turpis sed lutpat Quisque vitae quam neque.</span> <span class="tweet_time"><a href="#">about 9 hours ago</a></span></li>
                            <li><strong>@<a href="#">name</a></strong> <span class="tweet_text">RT <span class="at">@</span><a href="#">name</a> Donec suscipit vehicula turpis sed lutpat Quisque vitae quam neque.</span> <span class="tweet_time"><a href="#">about 9 hours ago</a></span></li>
                            <li><strong>@<a href="#">name</a></strong> <span class="tweet_text">RT <span class="at">@</span><a href="#">name</a> Donec suscipit vehicula turpis sed lutpat Quisque vitae quam neque.</span> <span class="tweet_time"><a href="#">about 9 hours ago</a></span></li>
                            <li><strong>@<a href="#">name</a></strong> <span class="tweet_text">RT <span class="at">@</span><a href="#">name</a> Donec suscipit vehicula turpis sed lutpat Quisque vitae quam neque.</span> <span class="tweet_time"><a href="#">about 9 hours ago</a></span></li>
                        </ul>
                    </div>
                </div>
                <div class="one_quarter">
                    <h2 class="footer_title">Contact Us</h2>
                    <form class="rnd5" action="#" method="post">
                        <div class="form-input clear">
                            <label for="ft_author">
                                Name <span class="required">*</span><br>
                                <input type="text" name="ft_author" id="ft_author" value="" size="22">
                            </label>
                            <label for="ft_email">
                                Email <span class="required">*</span><br>
                                <input type="text" name="ft_email" id="ft_email" value="" size="22">
                            </label>
                        </div>
                        <div class="form-message">
                            <textarea name="ft_message" id="ft_message" cols="25" rows="10"></textarea>
                        </div>
                        <p>
                            <input type="submit" value="Submit" class="button small orange">
                            &nbsp;
          <input type="reset" value="Reset" class="button small grey">
                        </p>
                    </form>
                </div>
            </div>
        </div>
        <div class="wrapper row4">
            <div id="copyright" class="clear">
                <p class="fl_left">Copyright &copy; 2013 - All Rights Reserved - <a href="#">Domain Name</a></p>
                <p class="fl_right">Template by <a href="http://www.os-templates.com/" title="Free Website Templates">OS Templates</a></p>
            </div>
        </div>
        <!-- Scripts -->
        <script src="http://code.jquery.com/jquery-latest.min.js"></script>
        <script src="http://code.jquery.com/ui/1.10.1/jquery-ui.min.js"></script>
        <script>window.jQuery || document.write('<script src="scripts/jquery-latest.min.js"><\/script>\
<script src="scripts/jquery-ui.min.js"><\/script>')</script>
        <script>jQuery(document).ready(function ($) { $('img').removeAttr('width height'); });</script>
        <script src="scripts/responsiveslides.js-v1.53/responsiveslides.min.js"></script>
        <script src="scripts/jquery-mobilemenu.min.js"></script>
        <script src="scripts/custom.js"></script>
        </div>
    </form>
</body>
</html>
