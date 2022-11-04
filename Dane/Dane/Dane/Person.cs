//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace Dane
{
    public class Person
    {
        private string Name { get; set; }
        private string FirstName { get; set; }
        private byte? Wiek { get; set; }
        public Person(string Imie, string Nazwisko)
        {
            this.FirstName = Imie;
            this.Name = Nazwisko;
            this.Wiek = null;
        }
        public Person(string Imie, string Nazwisko, byte Wiek)
        {
            this.FirstName = Imie;
            this.Name = Nazwisko;
            this.Wiek = Wiek;
        }
        public Person() { }
        public void SetData(string Imie, string Nazwisko, byte? Wiek)
        {
            this.FirstName = Imie;
            this.Name = Nazwisko;
            this.Wiek = Wiek;
        }
        public string GetData()
        {
            if (this.FirstName == "" || this.Name == "")
            {
                return "Należy uzupełnić dane";
            }
            else
            {
                return this.FirstName + " " + this.Name + " " + WiekText();
            }
        }
        private string WiekText()
        {
            if (this.Wiek == null)
            {
                return "(Wiek nieznany)";
            }
            else
            {
                return "(" + this.Wiek + " l.)";
            }
        }
        public override string ToString()
        {
            return "Person:{Constrctors:[();(string, string);(string,string,byte)],Variables:[FirstName: \"" + this.FirstName + "\", Name: \"" + this.Name + "\", Wiek: \"" + this.Wiek + "\"], Methods:[void SetData(string, string, byte?)), string GetData()]}";
        }
        public string Klasa()
        {
            return "Dostępne metody: setData(string, string, byte)/*Nadaje wartość Imienia, Nazwiska oraz Wieku (opcjonalnie)*/, GetData()/*Zwraca w postaci string Imię, Nazwisko i Wiek*/";
        }
    }
}
