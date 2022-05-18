# QuizAutomation
AYŞE IRMAK KOÇ - 202803046

Ödevi geliştirmek için Visual Studio 2019 kullandım. 
Scrum tablosu için Trello kullandım.
![image](https://user-images.githubusercontent.com/79281832/169117444-5bf0d828-d4cc-4206-8fa7-02aae5f5e320.png)

Ödev için geliştirdiğim program ilk başta bir ‘Login’ sayfasıyla başlar. Login sayfası içerisinde kullanıcıya göre giriş ve ‘Üye Ol’ butonları vardır. ‘Sınav Sorumlusu’ girişe tıklandığında Sınav Sorumlusu için bir ekran çıkar ve içerisinde ‘Şifremi Unuttum’ kısmı da vardır. Şifremi unuttum kısmına basılırsa şifreyi değiştirmek için gerekli bilgilerin yer aldığı bir form sayfası karşımıza çıkar. 

Sınav sorumlusu giriş yaptığında karşısına ilk olarak ‘Soru Ekleme’ sayfası gelir. Ekranda yazı olarak yer alan ‘Üniteler’ ve ‘Sonucu Görüntüle’ olarak 2 sayfa daha vardır. Sağ tarafta ise bunlar resimli bir şekilde buton olarak vardır ve ek olarak direkt ‘Login’ sayfasına giden çıkış butonu da vardır.

Sınav Sorumlusu bu sayfalarda soru ekleyebilir, ünite başlıkları girebilir ve öğrencilerin durumlarını görüntüleyebilirler.

Yukarıda bahsedilen ‘Login’ ve ‘Şifremi Unuttum’ kısımları Öğrenci için de geçerlidir. Öğrenci giriş yaptığında karşısına ‘Öğrenci Ana Ekranı’ çıkar. Bu sayfada ‘Quiz ol’ ve ‘Durumunu gör olarak’ 2 buton ve ünite seçmesine yarayan bir seçme kutucuğu vardır. İlk olarak bu kutucuktan ünite seçer ve eğer ‘Quiz ol’ butonuna tıklarsa seçtiği üniteye göre veri tabanından rastgele 10 soru seçilir ve öğrencinin karşısına çıkar. Her soruyu işaretleyip ‘Kaydet’ butonuna bastığında ise soru geçilirken bir ‘MessageBox’ kutusu çıkar ve yaptığı soruya göre sorunun doğru olup olmadığını söyler. En son soruya gelindiğinde ise quiz sayfasından çıkar ve ‘Öğrenci Ana Ekran’ menüsüne geri döner. 

Daha sonra ‘Durumunu Gör’ butonuna tıkladığında ise  seçilen ünite ve konuya göre öğrencinin skoru gözükür.

Login sayfasında bir tane de ‘Admin Girişi’ vardır ve bu sayfada sadece parola kısmı vardır. Admin giriş yaptığında ‘Sorular’ sayfasına yönlendirilir ve burada ‘Sınav Sorumlusu’ gibi sorularda değişiklik yapabilir. Aynı şekilde ‘Üniteler’ ve ‘Sonuçları Gör’ sayfasına da bakabilir.

'Login' Formu 

![image](https://user-images.githubusercontent.com/79281832/169118459-5429bb2f-23e4-4343-9bba-91180aa09f1b.png)

'Register' Formu 

![image](https://user-images.githubusercontent.com/79281832/169118544-5af04475-20f4-4056-adb1-33e7e1ccd42f.png)

'Adim Login' Formu 

![image](https://user-images.githubusercontent.com/79281832/169119019-cad91582-1b25-4c31-89f9-ecf23a13190a.png)

'Student Login' Formu 

![image](https://user-images.githubusercontent.com/79281832/169119246-2bec4502-5520-463d-b832-57587420b906.png)

'Sınav Sormlusu Login' Formu 

![image](https://user-images.githubusercontent.com/79281832/169119519-f3e21705-c13f-4138-99d1-073845a202dc.png)

'Questions' Formu

![image](https://user-images.githubusercontent.com/79281832/169119972-1f7caea5-1b24-4a1d-9c87-e091af850dac.png)

'Subjects' Formu

![image](https://user-images.githubusercontent.com/79281832/169120225-31e3740b-e1c7-43a0-92bf-e796955aac66.png)

'View Results' Formu

![image](https://user-images.githubusercontent.com/79281832/169120419-05208405-a9e1-49db-b981-499cc608c484.png)

'Student Main Page' Formu

![image](https://user-images.githubusercontent.com/79281832/169120642-a544b61c-245a-4338-a87a-cfd814ba5d23.png)

'Exam 1' Formu

![image](https://user-images.githubusercontent.com/79281832/169120843-4a3d8035-87ec-4293-ab3a-1e3b56edd36a.png)

İSTERLER

![image](https://user-images.githubusercontent.com/79281832/169121122-6bdb8537-77ca-47a6-9f9d-71971413a761.png)

(Burada belirtilen her şey raporda da anlatılmaktadır.)
