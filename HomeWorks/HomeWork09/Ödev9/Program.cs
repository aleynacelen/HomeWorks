namespace Ödev9;


// //         CSS Seçicileri ve Kullanımı
// // CSS(Cascading Style Sheets), web sayfalarının görünümünü ve stilini tanımlamak için kullanılan bir dildir. CSS ile stil tanımlarken, farklı seçici türleri ve stillerin nasıl uygulanacağı önemli bir rol oynar.

// // Temel Seçiciler
// // Element Seçicisi: Belirli bir HTML etiketine uygulanan stildir. Örneğin, tüm<p> etiketlerinin metin rengini mavi yapmak için:

//         // css

//         // p {
//         // color: blue;
//         // }
//         // Class Seçicisi: Belirli bir sınıfa sahip HTML elementlerine uygulanır.Örneğin, "highlight" sınıfına sahip elementlerin arka planını sarı yapmak için:

// css

// .highlight {
//             background - color: yellow;
//         }
//         ID Seçicisi: Belirli bir ID'ye sahip HTML elementlerine uygulanır. Örneğin, "main-title" ID'sine sahip elementin font boyutunu 24px yapmak için:

//         css

// #main-title {
//     font - size: 24px;
//     }
//     Birleşik Seçiciler
// Birleşik seçiciler, bir elementin belirli bir sınıfa veya ID'ye sahip olduğu durumları seçmek için kullanılır.

// Element ve Class Seçicisi: Örneğin, "highlight" sınıfına sahip tüm<div> etiketlerine kırmızı kenarlık eklemek için:

// css

// div.highlight
//     {
//         border: 1px solid red;
//     }
//     Element ve ID Seçicisi: Örneğin, "main-paragraph" ID'sine sahip <p> etiketinin rengini yeşil yapmak için:

// css

// p#main-paragraph {
//     color: green; 
// }
// Pseudo-class Seçicileri
// Pseudo-class seçicileri, elementlerin durumlarına göre stil uygular.

// : Fare ile üzerine gelindiğinde uygulanan stil.

// css

// a:hover {
//     text - decoration: underline;
// }
// : Elementin odaklandığı durum.

// css

// input:focus {
//     border: 2px solid blue; 
// }
// : Elementin tıklandığı durum.

// css

// button:active {
//     background-color: gray; 
// }
// Box Model ve Layout
// CSS'de her HTML elemanı bir kutu modeli ile temsil edilir. Kutu modeli, dört ana bileşenden oluşur:

// Content: İçerik alanı(metin, resim vb.).
// Padding: İçerik ile kenarlık arasındaki boşluk.
// Border: Kenarlık, padding ve margin arasında bir sınır.
// Margin: Elemanın dışındaki boşluk.
// Box Model Diyagramı:

// lua

// +------------------------+
// |        Margin          |
// |  +------------------+  |
// |  |     Border       |  |
// |  |  +-----------+   |  |
// |  |  |  Padding  |   |  |
// |  |  |  +-----+  |   |  |
// |  |  |  |Content|  |   |  |
// |  |  |  +-----+  |   |  |
// |  |  +-----------+   |  |
// |  +------------------+  |
// +------------------------+
// Display Özellikleri
// CSS'deki eleman görünümünü etkileyen bazı önemli display değerleri şunlardır:

// block: Elemanı blok seviyesinde gösterir, yeni bir satırda başlar.

// css

// div {
//     display: block; 
// }
// inline: Elemanı satır içi gösterir, yeni bir satırda başlamaz.

// css
// Kodu kopyala
// span {
//     display: inline; 
// }
// inline - block: Elemanı hem blok hem de satır içi özelliklerini taşır.

// css

// .item {
//     display: inline - block; 
// }
// none: Elemanı görünmez yapar ve yer kaplamaz.

// css

// .hidden {
//     display: none; 
// }
// Positioning
// Elemanların sayfadaki konumunu belirlemek için kullanılan bazı positioning değerleri şunlardır:

// static: Varsayılan konumlandırma. Eleman normal akışta yer alır.

// css

// p {
//     position: static; 
// }
// relative: Elemanın normal konumuna göre yerini değiştirmeye olanak tanır.

// css

// div {
//     position: relative;
// top: 10px; 
// }
// absolute: En yakın konumlandırılmış elemana göre konumlanır.

// css

// .tooltip {
//     position: absolute;
// top: 20px; 
// }
// fixed: Sayfa kaydırıldığında sabit kalan konumlandırmadır.

// css

// .header {
//     position: fixed;
// top: 0; 
// }
// sticky: Normal akışta yer alırken belirli bir kaydırma noktasında sabit kalır.

// css

// .sticky-header {
//     position: sticky;
// top: 0; 
// }
// Renkler ve Arka Planlar
// CSS'de renkler ve arka planlar, sayfanın görünümünü zenginleştirmek için kullanılır.

// Renkler
// color: Metin rengini ayarlamak için kullanılır.

// css

// h1 {
//     color: red; 
// }
// background - color: Arka plan rengini ayarlamak için kullanılır.

// css

// body {
//     background-color: lightblue; 
// }
// Renk Değerleri:

// Hex: Örneğin, #ff5733.
// RGB: Örneğin, rgb(255, 87, 51).
// HSL: Örneğin, hsl(12, 100 %, 60 %).
// Arka Plan Özellikleri
// background-image: Arka plana resim ekler.

// css

// body {
//     background-image: url('image.jpg'); 
// }
// background - size: Arka plan resminin boyutunu ayarlar.

// css

// body {
//     background-size: cover; 
// }
// background - repeat: Arka plan resminin tekrarını ayarlar.

// css

// body {
//     background-repeat: no - repeat; 
// }
// background - position: Arka plan resminin konumunu ayarlar.

// css

// body {
//     background-position: center; 
// }
// Yazı Tipleri ve Metin Stilleri
// CSS, metinlerin görünümünü ayarlamak için bir dizi font ve metin stil özelliği sunar.

// Font Özellikleri
// font-family: Yazı tipini ayarlar.

// css

// p {
//     font-family: Arial, sans-serif; 
// }
// font - size: Yazı boyutunu ayarlar.

// css

// h2 {
//     font-size: 20px; 
// }
// font - weight: Yazı kalınlığını ayarlar.

// css

// strong {
//     font-weight: bold; 
// }
// font - style: Yazının stilini ayarlar.

// css

// em {
//     font-style: italic; 
// }
// line - height: Satır yüksekliğini ayarlar.

// css

// p {
//     line-height: 1.5; /* Satır yüksekliği 1.5 katı */
// }
// Metin Stilleri
// text-align: Metnin hizalamasını ayarlar.

// css

// h1 {
//     text-align: center; 
// }
// text - transform: Metin dönüşümünü ayarlar (büyük harf, küçük harf vb.).

// css

// h2 {
//     text-transform: uppercase; /* Metni büyük harfe çevirir */
// }
// text - decoration: Metin üzerindeki dekoratif çizgileri ayarlar (altı çizili, üstü çizili vb.).

// css

// a {
//     text-decoration: none; /* Linklerin altını çizmez */
// }
// letter - spacing: Harfler arasındaki boşluğu ayarlar.

// HTML Etiketleri
// HTML(HyperText Markup Language), web sayfalarının yapısını belirlemek için kullanılan bir işaretleme dilidir.Aşağıda, temel HTML etiketleri ve bunların işlevleri hakkında detaylı bilgiler verilmiştir.

// 1. Temel Yapı Etiketleri
// <html>: HTML belgesinin başlangıcını ve sonunu tanımlar. Tüm içerik bu etiketin içinde yer alır.

// <head>: Sayfanın başlık bilgilerini ve diğer meta bilgileri barındırır. Görünümde yer almaz.

// <title>: Sayfanın başlığını tanımlar.Tarayıcı sekmesinde görünen metni belirler.

// <meta>: Sayfanın karakter seti, yazar, açıklama gibi meta bilgilerini tanımlar.

// <link>: Dış kaynaklara (CSS dosyaları gibi) bağlantı vermek için kullanılır.

// <style>: Sayfa içi CSS stillerini tanımlar.

// <script>: JavaScript kodunu eklemek için kullanılır.

// <body>: Sayfanın görünür içeriğini barındırır.

// 2. Başlık ve Paragraf Etiketleri
// <h1> ile<h6>: Başlık etiketleri. <h1> en yüksek düzeyde başlıkken, <h6> en düşük düzeydedir.Hiyerarşik yapı olarak kullanılır ve SEO için önemlidir.

// <p>: Paragraf etiketidir. Metin parçalarını tanımlar.

// <br>: Satır sonu etiketi.Yeni bir satıra geçmek için kullanılır.

// <hr>: Yatay çizgi oluşturur, genellikle içerik arasında ayrım yapmak için kullanılır.

// 3. Metin Biçimlendirme Etiketleri
// <strong>: Önemli metni vurgulamak için kullanılır; tarayıcılar genellikle kalın gösterir.

// <b>: Kalın yazı için kullanılır, ancak anlam yüklemez.

// <em>: Vurgulamak için italik yazı oluşturur; içerik üzerinde önem taşır.

// <i>: İtalik yazı oluşturur; anlam yüklemez.

// <u>: Altı çizili yazı için kullanılır.

// <mark>: Vurgulu yazı oluşturur; genellikle arka plan rengi ile belirgin hale gelir.

// <sup>: Üst simge oluşturur (örneğin, matematiksel ifadelerde).

// <sub>: Alt simge oluşturur.

// <blockquote>: Alıntı için kullanılır, genellikle kenar boşluğu ile gösterilir.

// <cite>: Kaynak göstermek için kullanılır.

// 4. Liste Etiketleri
// <ul>: Sırasız liste oluşturur.

// <ol>: Sıralı liste oluşturur.

// <li>: Liste öğelerini tanımlar.

// 5. Bağlantı ve Medya Etiketleri
// <a>: Bağlantı oluşturur. href özniteliği ile yönlendirme yapılır.

// <img>: Görsel eklemek için kullanılır. src özniteliği ile resmin yolu belirlenir.

// <iframe>: Sayfa içinde başka bir sayfa ekler.

// <audio>: Ses dosyası eklemek için kullanılır.

// <video>: Video dosyası eklemek için kullanılır.

// <source>: Medya kaynağını belirlemek için kullanılır.

// <picture>: Resim kaynaklarını yönetmek için kullanılır.

// <figcaption>: Görsel veya içerik figürüne başlık ekler.

// <figure>: Gelişmiş görsel ve medya yönetimi için kullanılır.

// 6. Tablo Etiketleri
// <table>: Tablo oluşturur.

// <thead>: Tablo başlığını tanımlar.

// <tbody>: Tablo gövdesini tanımlar.

// <tfoot>: Tablo alt kısmını tanımlar.

// <tr>: Tablo satırını tanımlar.

// <td>: Tablo hücresini tanımlar.

// <th>: Tablo başlık hücresini tanımlar.

// <caption>: Tabloya başlık ekler.

// 7. Form ve Girdi Etiketleri
// <form>: Form oluşturur.

// <input>: Girdi alanı oluşturur.type özniteliği ile girdi türü belirlenir.

// <textarea>: Çok satırlı girdi alanı oluşturur.

// <button>: Buton oluşturur.

// <label>: Girdi alanlarına etiket ekler.

// <select>: Seçim kutusu oluşturur.

// <option>: Seçim kutusu içindeki seçenekleri tanımlar.

// <optgroup>: Seçenek gruplarını tanımlar.

// 8. Bölümleme Etiketleri
// <div>: Blok düzeyinde bir alan oluşturur, içerik gruplamak için kullanılır.

// <span>: Satır içi bir alan oluşturur, içerik gruplamak için kullanılır.

// <section>: Belirli bir bölüm oluşturur, anlamlı içerik gruplar.

// <article>: Kendi başına anlamlı bir içerik parçası tanımlar.

// <aside>: Ana içerikten bağımsız, ek bilgi alanları oluşturur.

// <header>: Sayfanın başlık bölümünü tanımlar.

// <footer>: Sayfanın alt bölümünü tanımlar.

// <nav>: Navigasyon bağlantılarını tanımlar.

// <main>: Sayfanın ana içeriğini tanımlar.

// 9. Diğer Faydalı Etiketler
// <details>: Kullanıcıya açılır/kapanır içerik sunar.

// <summary>: <details> etiketi içinde başlık olarak kullanılır.

// <dialog>: Dialog kutusu oluşturur.

// 10. Yazılım Geliştirme ile İlgili Etiketler
// <script>: JavaScript kodunu eklemek için kullanılır.

// <noscript>: Tarayıcıda JavaScript desteği olmadığında gösterilecek içeriği tanımlar.

// <template>: JavaScript ile dinamik içerik oluşturmak için kullanılır.




