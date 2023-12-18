Лабораториска вежба 3 - за групите со префикс А
Спецификација за лабораториската вежба 
1. Во оваа вежба ќе треба да продолжите со работа во рамки на проектот од претходната лабораториска вежба, притоа имплементирајќи перзистирање на податоците со користење на Spring Data JPA и Hibernate. 

2. Најпрво, додадете ги соодветните зависности за `spring-boot-starter-data-jpa`, `h2` и `postgresql` во рамки на `pom.xml`, како што е направено во проектот од аудиториски вежби. 

3. Симнете PostgreSQL. 

4. Креирајте два профили `h2` и `prod`, како што е направено во рамки на аудиториските вежби. Активниот профил нека биде оној за кој конекцијата е со PostgreSQL база на податоци. 

5. Доколку користите Docker, можете да креирате фајл `docker-compose.yml`, кој ќе има сличен формат како оној од аудиториските вежби. Во спротивно, внимавајте кои `user` и `password` параметри ги побарува PostgreSQL (оние кои вие сте ги ставиле при инсталацијата).

6. Поврзете се со базата на податоци преку IntelliJ, како што се прави во рамки на аудиториските вежби. Внимавајте на податоците за `port`, `user`, `password` и `database`. Кај вас името на базата на податоци нека биде `cinema`. 

7. Во рамки на `application-prod.properties`, проверете дека `spring.datasource.url`, `spring.datasource.username` и `spring.datasource.password` се точно поставени. 

8. Во рамки на пакетот `mk.ukim.finki.wp.lab.model` додадете класа `User`. Во истата ќе чувате:

    - `private Long id`

    - `private String username`

    - `private String name`

    - `private String surname`

    - `private String password`

    - `private LocalDate dateOfBirth`

    - `private List<ShoppingCart> carts`

9. Во истиот пакет додадете и класа `ShoppingCart`, во која ќе чувате:

    - `private Long id`

    - `private User user`

    - `private LocalDateTime dateCreated`

    - `private List<TicketOrder> ticketOrders`

10. Дополнително, направете промена во класата `TicketOrder`,  т.ш. таа не чува `private String clientName` и `private String clientAddress`.

11. Потребно е класите `Movie`, `Production`, `TicketOrder`, `User` и `ShoppingCart` да ги направите ентитети, кои ќе бидат соодветно мапирани во табели во базата на податоци. Внимавајте на името на табелата за ентитетот `User`, бидејќи табелата не може да се вика така. Променете го името на оваа табела, како што е направено во аудиториските вежби.

12. Секаде каде е потребно, искористете ги @ManyToOne, @OneToMany, @ManyToMany анотациите за дефинирање на релации помеѓу табелите. Внимавајте да не креирате циклични врски. 

13. Треба да се обезбеди целосната досегашна функционалност на апликацијата, заедно со перзистирање на податоците. За ова, направете ги соодветните промени во `repository` и `service` слојот. Поконкретно, во `service` слојот инјектирајте ги новите интерфејси од `repository` слојот, оние кои наследуваат од JpaRepository.

14. Дополнително, потребни ќе бидат и промени секаде каде се користеа својствата на класата `TicketOrder` кои ги отстранивте. За таа цел, секаде каде користевте `clientName`, користете го `username` својството на `User`. 

15. Управувањето со датуми направете го со помош на `LocalDate` и `LocalDateTime` класите од `java.time` библиотеката (https://www.baeldung.com/java-8-date-time-intro). 



 15.1. Форматот на `dateCreated` атрибутот во `ShoppingCart` треба да биде "yyyy-MM-dd'T'HH:mm:ss". Hint: Анотирајте го атрибутот со `@DateTimeFormat` и поставете вредност за `pattern` својството.



 15.2. Форматот на `dateOfBirth` атрибутот во `User` да биде `"dd-MM-yyyy"`. 



 15.3. Додадете можност при креирање на нарачката, корисникот да може сам да одбере датум и време на нејзино креирање. За таа цел, користете ја `<input type="datetime-local"/>` HTML контролата. Внимавајте на начинот на кој го пречекувате dateCreated параметарот кај контролерот. Потребно е да додете и @DateTimeFormat анотација со соодветниот формат на датумот и времето кои контролерот треба да ги пречека (https://www.baeldung.com/spring-date-parameters).



 15.4. При преглед на сите нарачки, овозможете форматирање на датумот на креирање на нарачките во следниот формат `dd-MM-yyyy HH:mm:ss`. (https://www.baeldung.com/dates-in-thymeleaf).



 15.5. Направете метод во `TicketOrderRepository` со кој ќе се овозможи филтрирање на нарачките во даден временски интервал `[LocalDateTime from, LocalDateTime to]`.



#### Употреба на JPA Attribute Converters



Attribute Converter-ите овозможуваат методи за мапирање на JDBC типовите во Java класи и обратно. 



16. Направете замена на атрибутите `name` и `surname` од ентитетот `User`, со атрибут-класата `UserFullname` во која ќе ги содржи двата атрибута кои ги заменивме `name` и `surname`. Следете ја постапката која е објаснета на следниот ресурс: https://www.baeldung.com/jpa-attribute-converters.



 16.1. Креирајте нова Java класа `UserFullname` во која ќе ги сместете променливите од тип `String`, `name` и `surname`. Истата треба да го имплементира интерфејсот `Serializable`.



 16.2. Заменете ги атрибутите `name` и `surname` од ентитетот `User` со нов атрибут од типот `UserFullname`.



 16.3. Креирајте нова класа `UserFullnameConverter` која ќе го трансформира `UserFullname` атрибутот во соодветна колона во база и обратно. Анотирајте ја со анотацијата `@Converter` и направете да го имплементира интерфејсот AttributeConverter.



 16.4. Имплементирајте ги методите `convertToDatabaseColumn()` и `convertToEntityAttribute()`. Првиот метод треба да направи серијализација на `Java` објектот во `String`, а вториот од `String` во `Java` објектот `UserFullname`.



 16.5. Анотирајте го атрибутот `UserFullname` во `User` со `@Convert` анотацијата.