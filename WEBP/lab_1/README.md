Спецификација за лабораториската вежба
Креирајте нов Spring Boot проект со група mk.finki.ukim.mk и artefactId=lab кој ги има истите зависности како проектот од аудиториските вежби (зависностите може да ги видите во <dependency> тагoвите во pom.xml.
Дефинирајте пакет mk.ukim.finki.wp.lab.model и во него креирајте ја TicketOrder класата. Таа треба да содржи:
String movieTitle,
String clientName,
String clientAddress и
Long numberOfTickets.
Во mk.ukim.finki.wp.lab.model креирајте Movie класа која ќе содржи:
String title,
String summary,
double rating,
Креирајте класа MovieRepository во пакетот mk.ukim.finki.wp.lab.repository, во која ќе чувате List<Movie> иницијализирана со 10 вредности.
Имплементирајте метод public List<Movie> findAll(); кој само ќе ја врати листата.
Имплементирајте метод public List<Movie> searchMovies(String text); кој ќе направи пребарување низ листата на филмови и ќе ги врати оние во чиј наслов или кратка содржина се содржи текстот text кој се праќа како аргумент на методот.
Дефинирајте ги следните интерфејси во mk.ukim.finki.wp.lab.service кои ќе ги претставуваат бизнис функционалностите на апликацијата:

public interface MovieService {
    List<Movie> listAll();
    List<Movie> searchMovies(String text);
}
public interface TicketOrderService{
    TicketOrder placeOrder(String movieTitle, String clientName, String address, int numberOfTickets);
}
Имплементирајте ги сервисите (MovieService треба да зависи од MovieRepository).
Креирајте сервлет MovieListSevlet во пакетот mk.ukim.finki.lab.web и мапирајте го на патеката /. Овој сервлет треба да зависи од MovieService и да ги прикаже сите добиени филмови од методот listAll(). Овозможете корисникот да избере еден од филмовите и за истиот да наведе број на карти што сака да ги нарача. Креирајте по едно радио копче за секој филм каде што вредноста на копчето ќе биде насловот на филмот, а текстот кој ќе се прикаже ќе биде во форматот: Title: <movie_title>, Summary:<movie_summary>, Rating: <movie_rating>

Прилагодете го фајлот listMovies.html за изгледот на оваа страница.
<html>
    <head>
        <meta charset="utf-8">
        <title>Movie Ticket Order page - Welcome and choose a Movie</title>
        <style type="text/css">
            body {
                width: 800px;
                margin: auto;
            }
        </style>
    </head>
    <body>
        <header>
             <h1>Welcome to our Movie Ticket Shop App</h1>
        </header>
        <main>
            <h2>Choose movie:</h2>
            <!-- Display radio buttons for each movie,
                    the value should be the movie title 
                    and the displayed text should be Title: <movie_title>, Summary:<movie_summary>, Rating: <movie_rating> -->

             <h2>Choose number of tickets:</h2>
             <input type="number" name="numTickets" min="1" max="10"><br/>
             <br/>
             <input type="submit" value="Submit">
    </main>
</body>
</html>
При избор на филм, треба да ја прикажете нарачката на корисникот. За оваа цел креирајте сервлет TicketOrderServlet мапиран на /ticketOrder.

Овој сервлет треба да ја прикажете страната за потврда на нарачката
Во фолдерот src/main/resources/templates додадете фајл orderConfirmation.html.

Прилагодете го фајлот orderConfirmation.html за изгледот на оваа страница.

<html>
    <head>
        <meta charset="utf-8">
        <title>Ordered Ticket - Confirmation</title>
        <style type="text/css">
             body {
                 width: 800px;
                 margin: auto;
            }
            table {
                 width:100%;
            }
            table, td, th {
                border: 1px solid black;
                padding: 3px 2px;
            }
       </style>
</head>
<body>
   <section>
       <header>
           <h1>Movie Order page - Order confirmation </h1>
       </header>
       <table>
           <tr>
               <th colspan="2">
                   Your Order Status
              </th>
          </tr>
           <tr>
               <td><b>Client Name </b></td>
               <td>Petko Petkov</td>
          </tr>
          <tr>
              <td><b>Client IP Address</b></td>
              <td>127.0.0.1</td>
         </tr>
         <tr>
             <td><b>Ticket for Movie</b></td>
             <td>Oppenheimer</td>
         </tr>
         <tr>
             <td><b>Number of tickets</b></td>
             <td>2</td>
         </tr>
     </table>
   </section>
</body>
</html>
Да се имплементира можност за пребарување на филмовите на почетната страна listMovies.html. Треба да се прикажат само филмовите кои ги исполнуваат условите од пребарувањето. Пребарувањето треба да се изврши според два параметри:
филмови кои го содржи текстот испратен од страна на корисникот во нивниот наслов
филмови кои имаат рејтинг поголем или еднаков на внесената вредност од страна на корисникот


Дополително барање:
Да се прикажува филмот со најмногу купени билети.