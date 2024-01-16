# Dernek Takip

Dernek üyelerinin takibi için windows form uygulaması.
Uygulamada n-tier architecture, generic repository design pattern ve dependency injection kullanıldı.
Veritabanı olarak dersin şartları doğrultusunda MS Access veritabanı code first yaklaşımıyla kullanıldı. 
ORM olarak EF Core kullanıldı.
***

> Uygulama nihai bir ürün değildir, bir ödev için yapılmıştır.

***
## Uygulama Özellikleri
- Üye CRUD işlemleri ve TC kimlik numarası doğrulama.
- Aylara göre aidat belirleyip üyelere bu aylar üzerinden aidat ödemesi ekleme.
- Zedgraph grafik kütüphanesi aracılığıyla şehirlere göre üye dağılımını ve aylara göre toplam aidat gelirini görüntüleme. *
- İText7 kütüphanesi ile borcu olan üyelerin pdf olarak dışa aktarılması.
- Mailkit ve Mimekit kütüphaneleriyle borcu olan üyeye borç maili gönderme. *

*İşaretli alanlarda geliştirme süreci devam etmekte. 
