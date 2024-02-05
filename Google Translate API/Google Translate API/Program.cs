// See https://aka.ms/new-console-template for more information

using RestSharp;
using System.Diagnostics.CodeAnalysis;

string od;
string nd;
string statement;
string originaldil = "";
string translatedil = "";


Console.Write("İngilizce için 1, Turkçe için 2 \n");
Console.Write("Orijinal dil seçiniz: ");
od = Console.ReadLine();
Console.Write("Çevirilecek dil seçiniz: ");
nd = Console.ReadLine();

switch (od)
{
    case "1":
        originaldil = "English";
        break;
    case "2":
        originaldil = "Turkish";
        break;
}
switch (nd)
{
    case "1":
        translatedil = "English";
        break;
    case "2":
        translatedil = "Turkish";
        break;
}

Console.Write("Çevirmek istediğiniz cümle giriniz: ");
statement = Console.ReadLine();

Console.Write("Girdiğiniz cümle  " + originaldil + " dan  " + translatedil + " e çevirilecktir");

var client = new RestClient("https://google-translate1.p.rapidapi.com/language/translate/v2/detect");
var request = new RestRequest();
request.AddHeader("content-type", "application/x-www-form-urlencoded");
request.AddHeader("Accept-Encoding", "application/gzip");
request.AddHeader("X-RapidAPI-Key", "SIGN-UP-FOR-KEY");
request.AddHeader("X-RapidAPI-Host", "google-translate1.p.rapidapi.com");
request.AddParameter("application/x-www-form-urlencoded", "q=" + statement, ParameterType.RequestBody);
RestResponse response = client.Execute(request);
Console.WriteLine(response.Content);





//dil sectikten sonra dil bir degisken icinde tutacaksın


//kullanıcıdan cumle iste

//kullanıcının girdigi dil al ve APIye yolla

//APIden gelen response ekrana göster