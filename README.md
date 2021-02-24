# PAYMENT_SYSTEM
Ödeme Sistemi Projesi - Abonelerin ve gişe çalışanların fatura takibini ve ödemelerini yapabildikleri, ekstrelerini görüntüleyebildikleri bir web uygulamasıdır.

Projenin Çalıştırılması İçin Gerekenler,

1-) Öncelikle DB dizini altında bulunan "PAYMENT_SYSTEM.sql" ya da "PAYMENT_SYSTEM.bak" dosyalarından birisini kullanarak gerekli veritabanı "PAYMENT_SYSTEM" adıyla lokalinizde çalışan sunucunuzda MS-SQL Server Yönetim Sistemi ile oluşturulur.

2-) Ardından yeni oluşturulan "PAYMENT_SYSTEM" veritabanı altında "Job_INSERT_INVOICE.sql" Job oluşturma script'i çalıştırılarak fatura oluşturma Job'ı sisteme dahil edilir. (Fatura oluşturma Job'ı her ay sonunda sistemde aktif olan kullanıcıların faturalarını sisteme ekler.)

3-) Veritabanu işlemleri başarılı bir şekilde tamamlandıktan sonra "PaymentSystem.WebService" dizininde bulunan web servis projesi hiçbir değişiklik yapmadan çalıştırılır.

4-) Tarayıcınızda web servisin başarılı bir şekilde çalıştığını görüntüledikten sonra "PaymentSystemWeb" projesi açılır.

5-) "PaymentSystemWeb" projesi içerisindeki "Web.config" dosyasında aşağıdaki bölüm web portalin Abone veya Admin (Gişe Çalışanı) kullanımına uygun olarak açılmasını değiştirebileceğimiz bölümdür,

...
  <system.webServer>
  
    <defaultDocument>
	
      <files>
	  
        <add value="LoginOfficer.aspx"/>
		
      </files>
	  
    </defaultDocument>
	
  </system.webServer>
...  
  
  Bu kısımda "value" seçeneğini "LoginOfficer.aspx" olarak ayarlarsak portal gişe çalışanının, "LoginSubscriber.aspx" olarak ayarlarsak ise abonenin giriş yapabileceği şekilde açılacaktır.
  
6-) "Web.config" dosyasındaki ilgili kısmı gişe çalışanının giriş yapabileceği şekilde ayaralayarak "PaymentSystemWeb" projesini çalıştırdıktan sonra "Gişe Giriş" ekranı açılacaktır. Bu ekrandan mevcut veritabanında tanımlı olan gişe çalışanı kullanıcı bilgileri ile giriş yapabilirsiniz.
	
	Gişe Çalışanı
	
	Kullanıcı Kodu : MSTFZCN
			 
			 Şifre : 123

7-) Giriş yaptıktan sonra açılan ana sayfadan 4 farklı ekrana geçiş yapılabilmektedir. Bu ekranlardan,
    
	- Sisteme yeni bir abone ekleme,
	
	- Mevcutta varolan aboneliği kapatma(pasife çekme),
	
	- T.C. Kimlik/Vergi Numarası'na göre abonelik sorgulama,
	
	- Abonelerin ödenmemiş faturalarını görüntüleyip, fatura ödeme işlemleri yapılabilmektedir.
	
	Mevcut veritabanında varolan kullanıcı bilgileri aşağıda verilmiştir. Bu kullanıcılar üzerinden işlemler yapılabilir.
	
	T.C. Kimlik/Vergi Numaraları
	
	12345678900 - Bireysel Müşteri
	
	1234567890  - Tüzel Müşteri
	
	12345678901 - Bireysel Müşteri
	
8-) "Web.config" dosyasındaki ilgili kısmı abonenin giriş yapabileceği şekilde ayaralayarak "PaymentSystemWeb" projesini çalıştırdıktan sonra "Abone Giriş" ekranı açılacaktır. Bu ekrandan mevcut veritabanında tanımlı olan abone kullanıcı bilgileri ile giriş yapabilirsiniz.
	
	Abone
	
	T.C. Kimlik Numarası : 12345678900
			       Şifre : 111
				   
9-) Giriş yaptıktan sonra açılan ana sayfadan 2 farklı ekrana geçiş yapılabilmektedir. Bu ekranlardan,
    
	- Günü gelmiş ve ödenmemiş fatura bilgilerini görüntüleyip, fatura ödemesi yapma,
	
	- Ödenmiş fatura ekstrelerini görüntüleme işlemleri yapılabilmektedir.