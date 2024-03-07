using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionRepository
{
    public List<List<QuestionAndAnswer>> questions;

    void generateQuestionList()
    {
        questions = new List<List<QuestionAndAnswer>>();

        List<QuestionAndAnswer> level1 = new List<QuestionAndAnswer>();
        level1.Add(new QuestionAndAnswer("Która z poniższych planet jest najbliżej Słońca?", new string[] { "Mars", "Wenus", "Jowisz", "Saturn" }, 2));
        level1.Add(new QuestionAndAnswer("Która z tych liczb jest liczbą pierwszą?", new string[] { "20", "31", "42", "50" }, 2));
        level1.Add(new QuestionAndAnswer("Kto napisał powieść \"Harry Potter\"?", new string[] { "J.R.R. Tolkien", "J.D. Salinger", "J.K. Rowling", "J. K. Simmons" }, 3));
        level1.Add(new QuestionAndAnswer("Która z tych rzek jest najdłuższa?", new string[] { "Nil", "Amazonka", "Missisipi", "Jangcy" }, 2));
        level1.Add(new QuestionAndAnswer("Która z tych planet jest gazowa?", new string[] { "Mars", "Wenus", "Jowisz", "Ziemia" }, 3));
        level1.Add(new QuestionAndAnswer("Które państwo jest największe pod względem powierzchni?", new string[] { "Rosja", "Kanada", "Chiny", "Stany Zjednoczone" }, 1));
        level1.Add(new QuestionAndAnswer("Który pierwiastek chemiczny jest najlżejszy?", new string[] { "Azot", "Hel", "Tlen", "Wodór" }, 4));

        List<QuestionAndAnswer> level2 = new List<QuestionAndAnswer>();
        level2.Add(new QuestionAndAnswer("Które z poniższych zwierząt nie jest drapieżnikiem?", new string[] { "Lew", "Krokodyl", "Słoń", "Tygrys" }, 3));
        level2.Add(new QuestionAndAnswer("Które z poniższych zwierząt nie jest ssakiem?", new string[] { "Rekin", "Delfin", "Wieloryb", "Orka" }, 1));
        level2.Add(new QuestionAndAnswer("Jaki znak interpunkcyjny stawiany po cyfrze arabskiej sprawia, że odczytujemy ją jako liczebnik porządkowy?", new string[] { "Kropka", "Przecinek", "Dwukropek", "Kreska ukośna" }, 1));
        level2.Add(new QuestionAndAnswer("Ile kosztuje chleb, który pierwotnie kosztował 10 zł, następnie potaniał do 8 zł, a później jego cena wzrosła o 20 proc.? ", new string[] { "8,20 zł", "9 zł", "9,60 zł", "10 zł" }, 3));
        level2.Add(new QuestionAndAnswer("W Polsce wchodzimy po angielsku. Po jakiemu wchodzą Anglicy?", new string[] { "Po polsku", "Po niemiecku", "Po francusku", "Po rosyjsku" }, 3));
        level2.Add(new QuestionAndAnswer("Kuchenny synonim przekrętu...", new string[] { "Blat", "Dzban", "Garnek", "Wałek" }, 4));

        List<QuestionAndAnswer> level3 = new List<QuestionAndAnswer>();
        level3.Add(new QuestionAndAnswer("Gdzie Ślązaczki noszą laczki?", new string[] { "Na nogach", "Na rękach", "Na głowie", "Na szyi" }, 1));
        level3.Add(new QuestionAndAnswer("Jaka jest średnia wieku w grupie składającej się z trzech 4-latków, czterech 11-latków, dwóch 12-latków i jednego 20-latka?", new string[] { "5", "10", "15", "20" }, 2));
        level3.Add(new QuestionAndAnswer("Kto w marcu 2023 r. w meczu z Albanią w trakcie eliminacji do Euro strzelił zwycięskiego gola dla Polski?", new string[] { "Robert Lewandowski", "Jan Bednarek", "Arkadiusz Milik", "Karol Świderski" }, 4));
        level3.Add(new QuestionAndAnswer("Co pojawia się w znanym łamańcu językowym o czytającym tacie?", new string[] { "Passusy Passenta", "Wersy z Verne'a", "Maksymy Maksymusa", "Cytaty z Tacyta" }, 4));
        level3.Add(new QuestionAndAnswer("Do czego służy przyrząd łączony z filozofem Williamem Ockhamem, który uważał, że zawsze trzeba dążyć do prostoty?", new string[] { "Do golenia", "Do jedzenia", "Do ważenia", "Do grania" }, 1));
        level3.Add(new QuestionAndAnswer("Który to legendarny angielski pirat?", new string[] { "Czarnobrody", "Czarnowłosy", "Czarnooki", "Czarnowąsy" }, 1));

        List<QuestionAndAnswer> level4 = new List<QuestionAndAnswer>();
        level4.Add(new QuestionAndAnswer("Która z tych krain geograficznych jest najbardziej sucha?", new string[] { "Sahara", "Gobi", "Atacama", "Antarktyda" }, 4));
        level4.Add(new QuestionAndAnswer("Ragdoll, czyli szmaciana lalka, to rasa...", new string[] { "Kota", "Psa", "Królika", "Krowy" }, 1));
        level4.Add(new QuestionAndAnswer("Kojot wygląda jak coś pomiędzy...", new string[] { "Kuną a łasicą", "Bobrem a wiewiórką", "Wilkiem a szakalem", "Rysiem a żbikiem" }, 3));
        level4.Add(new QuestionAndAnswer("W którym tytule pojawia się wyraz, który brzmi najprawdopodobniej do niemieckiej czterdziestki?", new string[] { "Laura i Filon", "Fircyk w zalotach", "Ferdydurke", "Fortepian Szopena" }, 2));
        level4.Add(new QuestionAndAnswer("Słynna w Polsce średniowieczna Krzywa Wieża ma 34 metry wysokości i odchyla się od pionu o ponad 2 metry, a znajduje się...", new string[] { "W Mińsku Mazowieckim", "W Kamieniu Pomorskim", "W Ząbkowicach Śląskich", "W Bielsku Podlaskim" }, 3));

        List<QuestionAndAnswer> level5 = new List<QuestionAndAnswer>();
        level5.Add(new QuestionAndAnswer("Druga para odnóży gębowych pajęczaków, która służy do rozdrabniania pokarmów i jako narządy dotykowe, to...", new string[] { "Rękochwytki", "Nogogłaszczki", "Łapkomyjki", "Zębołapki" }, 2));
        level5.Add(new QuestionAndAnswer("Agnieszka Osiecka w piosence \"Aspiryna blues\" napisała, że \"Ludzie mają cudne sny po kokainie i po winie, po chininie...", new string[] { "po Darku\"", "po Halinie\"", "po Marku\"", "po Czarku\"" }, 2));
        level5.Add(new QuestionAndAnswer("Który z ptaków kuka?", new string[] { "Samica kukułki", "Samica gżegżółki", "Samiec kukułki", "Samica zazuli" }, 3));
        level5.Add(new QuestionAndAnswer("To klasyczny kształt kobiecych brwi...", new string[] { "Mysie ogonki", "Kocie grzbiety", "Strzały Amora", "Skrzydła jaskółki" }, 4));

        List<QuestionAndAnswer> level6 = new List<QuestionAndAnswer>();
        level6.Add(new QuestionAndAnswer("Żona której z tych postaci została bohaterką niemieckiej opery \"Światło\"?", new string[] { "Nicolae Ceausescu", "Helmuta Kohla", "Józefa Piłsudskiego", "Viktora Orbana" }, 2));
        level6.Add(new QuestionAndAnswer("Czyjego pędzla portrety mieli filmowiec i przedsiębiorca Jack Warner, sopranistka Claire Dux i bizneswoman Helena Rubinstein?", new string[] { "Pablo Picasso", "Salvadora Dali", "Vincenta van Gogha", "Rene Magritte'a" }, 2));
        level6.Add(new QuestionAndAnswer("O co chodzi we frazeologizmie: coś jest warte lub niewarte zachodu?", new string[] { "O kierunek geograficzny", "O mekkę dla Polaków za PRL-u", "O czasownik wybieganie", "O czasownik zabieganie" }, 4));
        level6.Add(new QuestionAndAnswer("Zzuć, a nawet zezuć, to...", new string[] { "Pociotek bąka", "Przeżuty tytoń", "Zdjąć buty z nóg", "Spoglądać ukradkiem" }, 3));

        List<QuestionAndAnswer> level7 = new List<QuestionAndAnswer>();
        level7.Add(new QuestionAndAnswer("Gdzie najczęściej można spotkać aparaty słuchowe telefoniczne samoinkasujące?", new string[] { "W więzieniach", "W sklepach", "W szpitalach", "W urzędach" }, 1));
        level7.Add(new QuestionAndAnswer("Co jest prawdą o podkarpackim mieście, które ma w nazwie urządzenie włókiennicze?", new string[] { "Słynie z hut szkła", "W X w. było stolicą Polski", "Ma milion mieszkańców", "Ma w herbie łódź" }, 1));
        level7.Add(new QuestionAndAnswer("W wilka i w owce najczęściej gra się na planszy...", new string[] { "Do gry w szachy", "Do gry w warcaby", "Do gry w chińczyka", "Do gry w kółko i krzyżyk" }, 2));
        level7.Add(new QuestionAndAnswer("Ile odcinków prostych znajdziemy w rzymskiej cyfrze 50?", new string[] { "2", "3", "4", "5" }, 1));

        List<QuestionAndAnswer> level8 = new List<QuestionAndAnswer>();
        level8.Add(new QuestionAndAnswer("Awanturka to pasta...", new string[] { "Do zębów", "Do kanapek", "Do rąk", "Do włosów" }, 2));
        level8.Add(new QuestionAndAnswer("Z kim Bruce Springsteen prowadził podcast \"Renegades: Born in the USA\"?", new string[] { "Z Meghan Markle", "Z Barackiem Obamą", "Z Jamesem Brownem", "Z Hugh Hefnerem" }, 2));
        level8.Add(new QuestionAndAnswer("Jakie lekarstwo na problemy z pamięcią zaordynował Słoniowi Trąbalskiemu kowal z wiersza Juliana Tuwima??", new string[] { "Podkucie przednich nóg", "Przekłucie uszu", "Supełek na trąbie", "Kokardkę na ogonie" }, 3));

        List<QuestionAndAnswer> level9 = new List<QuestionAndAnswer>();
        level9.Add(new QuestionAndAnswer("Trzy zwyczaje łączą się z nocą świętojańską, a jeden nie. Który?", new string[] { "Puszczanie wianków nad wodę", "Skoki przez ognisko", "Topienie marzanny", "Szukanie kwiatu paproci" }, 3));
        level9.Add(new QuestionAndAnswer("Z jaką chorobą zmaga się norweski policjant Harry Hole w serii kryminałów Jo Nesbo?", new string[] { "Z cukrzycą", "Z astmą", "Z alkoholizmem", "Z epilepsją" }, 3));
        level9.Add(new QuestionAndAnswer("W piosence Kabaretu Starszych Panów: \"Porwał dziewczę zdrady poryw...", new string[] { "...pojechała na jamboree\"", "..stłukła wazon millefiori\"", "...i ją zepchnął na złe tory\"", "...i zabrała pomidory\"" }, 3));

        List<QuestionAndAnswer> level10 = new List<QuestionAndAnswer>();
        level10.Add(new QuestionAndAnswer("Mogą grasować i mogą grasejować...", new string[] { "Kozy śruborogie", "Kózki kaspijskie", "Kozieradki", "Koziegłowianki" }, 4));
        level10.Add(new QuestionAndAnswer("Który utwór Juliusza Słowackiego napisany jest prozą?", new string[] { "Anhelli", "Balladyna", "Kordian", "Lilla Weneda" }, 1));
        level10.Add(new QuestionAndAnswer("Mowa w obronie poety Archiasza przeszła do historii jako jeden z najświetniejszych popisów retorycznych:", new string[] { "Cycerona", "Demostenesa", "Lysjasza", "Quintiliana" }, 1));

        List<QuestionAndAnswer> level11 = new List<QuestionAndAnswer>();
        level11.Add(new QuestionAndAnswer("Kiedy rozpoczęło się drugie tysiąclecie?", new string[] { "1 stycznia 1000 r.", "1 stycznia 1001 r.", "1 stycznia 2000 r.", "1 stycznia 2001 r." }, 2));
        level11.Add(new QuestionAndAnswer("Który instrument stroi muzyk?", new string[] { "Tamburyn", "Kocioł", "Okarynę", "Czynele" }, 2));

        List<QuestionAndAnswer> level12 = new List<QuestionAndAnswer>();
        level12.Add(new QuestionAndAnswer("Z gry na jakim instrumencie słynie Czesław Mozil?", new string[] { "Na akordeonie", "Na kornecie", "Na djembe", "Na ksylofonie" }, 1));
        level12.Add(new QuestionAndAnswer("Ile to jest 1111 razy 1111, jeśli 1 razy 1 to 1, a 11 razy 11 to 121?", new string[] { "12321", "1 234 321", "123 454 321", "111 111 111" }, 2));

        questions.Add(level1);
        questions.Add(level2);
        questions.Add(level3);
        questions.Add(level4);
        questions.Add(level5);
        questions.Add(level6);
        questions.Add(level7);
        questions.Add(level8);
        questions.Add(level9);
        questions.Add(level10);
        questions.Add(level11);
        questions.Add(level12);
    }

    public QuestionRepository()
    {
        generateQuestionList();
    }

    public QuestionAndAnswer GetRandomQuestion(int level)
    {
        int index = Random.Range(0, questions[level].Count);
        return questions[level][index];
    }
}
