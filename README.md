# C# & Gemini AI Chatbot 🤖

Bu proje, Google'ın **Gemini 1.5 Flash** modelini kullanan, Windows Forms tabanlı modern bir masaüstü chatbot uygulamasıdır. Kullanıcılara düşük gecikme süreli ve akıllı bir sohbet deneyimi sunar.

## 🚀 Kurulum Rehberi

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

### 1. Ön Gereksinimler
* **Visual Studio 2022** (.NET 8.0 veya üzeri) yüklü olmalıdır.
* Bir **Google Gemini API Key**'e ihtiyacınız vardır. [Google AI Studio](https://aistudio.google.com/) üzerinden ücretsiz alabilirsiniz.

### 2. API Güvenliği (Önemli)
Uygulama, güvenlik nedeniyle API anahtarını kod içerisinde barındırmaz. Projenin çalışması için bilgisayarınızda şu ortam değişkenini (Environment Variable) tanımlamanız gerekir:
* **Değişken Adı:** `GEMINI_API_KEY`
* **Değişken Değeri:** `SİZİN_API_ANAHTARINIZ`

*(Not: Değişkeni ekledikten sonra Visual Studio'yu yeniden başlatmayı unutmayın.)*

### 3. Çalıştırma
1. Bu depoyu klonlayın: `git clone https://github.com/MeralYavuzturk/LLM.git`
2. `LLM.sln` dosyasını Visual Studio ile açın.
3. NuGet paketlerini geri yükleyin (Restore NuGet Packages).
4. `F5` tuşuna basarak projeyi başlatın.

## 🛠️ Teknik Detaylar
* **Model:** Gemini 1.5 Flash
* **SDK:** `Mscc.GenerativeAI.Google`
* **Mimari:** Event-driven UI (WinForms) asenkron mimari.

## 📄 Lisans
Bu proje eğitim amaçlı geliştirilmiştir ve açık kaynaklıdır.
